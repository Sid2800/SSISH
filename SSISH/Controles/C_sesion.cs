using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SSISH.Modelos;
using System.Data;

namespace SSISH.Controles
{
    internal class C_sesion
    {
        readonly M_sesion sesion = new M_sesion();

        public Boolean Inicio_sesion(M_sesion var)
        {
            Boolean Inicio = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexionBD())
                {
                    sqlCon.Open();
                    string Qry = $"PC_SESION_CREAR";
       
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id_user", SqlDbType.VarChar);      cmd.Parameters["@id_user"].Value = var.Id_user;
                        cmd.Parameters.Add("@inicio", SqlDbType.Time);          cmd.Parameters["@inicio"].Value = var.Inicio;
                        cmd.Parameters.Add("@dia", SqlDbType.Date);             cmd.Parameters["@dia"].Value = var.Dia;
                        cmd.ExecuteNonQuery();
                        Inicio = true;
                    }

                    sqlCon.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Inicio de Sesion");
                Inicio = false;
            }

            return Inicio;
        }

        public Boolean Cerrar_Sesion(int id, string fin) {
            Boolean cerrado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexionBD())
                {
                    sqlCon.Open();
                    string Qry = "PC_SESION_CERRAR";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@id_sesion", SqlDbType.Int); 
                        cmd.Parameters["@id_sesion"].Value = id;
                        cmd.Parameters.Add("@fin", SqlDbType.Time); 
                        cmd.Parameters["@fin"].Value = fin;
                        cmd.ExecuteNonQuery();
                        cerrado = true;
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Cerrar Sesion");
                cerrado = false;
            }
            return cerrado;
        }


        public M_sesion Buscar_sesion_recienagregada()
        {
            M_sesion.Existe = false;
            string Qry = "execute dbo.PC_SESION_BULTIMA";
            try
            {
                DataTable dt1 = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexionBD())
                    {

                        sqlCon.Open();
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {

                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt1);
                        }
                        sqlCon.Close();
                    }
                    if (dt1.Rows.Count >= 1)
                    {
                        //Datos base de la table 
                        M_sesion sesion = new M_sesion
                        {
                            Id_sesion = (int)dt1.Rows[0]["id_sesion"],
                            Id_user = dt1.Rows[0]["id_user"].ToString(),
                            Depto = dt1.Rows[0]["descripcion"].ToString(),
                            Foto = (byte[])dt1.Rows[0]["foto"]
                        };
                        M_sesion.Existe = true;

                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Buscar_sesion_recien agregada"); }
            return sesion;

        }


    }
}
