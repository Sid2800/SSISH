using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSISH.Modelos;
using SSISH.Controles;

namespace SSISH.Controles
{
    class C_user
    {
        readonly M_user usuario = new M_user();
        public void Listar_usuario(string Qry)
        {

            try
            {
                DataTable dt = new DataTable();
                {
                    using (SqlConnection sqlCon = new Conexion().CadenaConexionBD())
                    {

                        sqlCon.Open();
                        using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                        {

                            SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                            LeerDatos.Fill(dt);
                        }
                        sqlCon.Close();
                    }
                    M_user.Datos = dt;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        public M_user Buscar_usuario(int id)
        {
            M_user.Existe = false;
            string Qry = $"execute [dbo].[PC_USER_BUSCAR_XID] '{id}'";
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
                        usuario.Descripcion = dt1.Rows[0]["Descripcion"].ToString();
                        usuario.Estado = (Boolean)dt1.Rows[0]["Estado"];
                        usuario.Contra = dt1.Rows[0]["Contraseña"].ToString();
                        usuario.Identidad = dt1.Rows[0]["Identidad_usu"].ToString();
                        usuario.Id_acc = (int)dt1.Rows[0]["Id_acc"];
                        M_user.Existe = true;

                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return usuario;

        }

        public Boolean Desactivar_usuario(int id)
        {

            Boolean desactivado = false;
            try
            {
                using (SqlConnection sqlCon = new Conexion().CadenaConexionBD())
                {
                    sqlCon.Open();
                    string Qry = $"execute [dbo].[PC_USER_DESACTIVAR] '{id}'";
                    using (SqlCommand cmd = new SqlCommand(Qry, sqlCon))
                    {
                        cmd.ExecuteNonQuery();
                        desactivado = true;
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                desactivado = false;
            }
            return desactivado;
        }
        
    }
}
