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

        public M_user Buscar_usuario(string id)
        {
            M_user.Existe = false;
            string Qry = $"execute SSISH.dbo.PC_USUARIO_BUSCARXID '{id}'";
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
                        usuario.Id_user = dt1.Rows[0]["id_user"].ToString();
                        usuario.Identidad = dt1.Rows[0]["identidad"].ToString();
                        usuario.Nombre = dt1.Rows[0]["Nombre"].ToString();
                        usuario.Contra = dt1.Rows[0]["Contraseña"].ToString();
                        usuario.Id_depto = (int)dt1.Rows[0]["id_depto"];
                        usuario.Depto = dt1.Rows[0]["descripcion"].ToString();
                        usuario.Estado = (Boolean)dt1.Rows[0]["Estado"];
                        M_user.Existe = true;

                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return usuario;

        }

        
        
    }
}
