using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSISH.Controles
{
    class Conexion
    {
        public SqlConnection CadenaConexionBD()
        {
            string NombreConexion = "ConexionDB";
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings[NombreConexion].ToString());
            return sqlCon;
        }

        public SqlConnection CadenaConexionBit()
        {
            string NombreConexion = "ConexionBIT";
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings[NombreConexion].ToString());
            return sqlCon;
        }

        public SqlConnection CadenaConexionFARMA()
        {
            string NombreConexion = "ConexionFARMA";
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings[NombreConexion].ToString());
            return sqlCon;
        }

    }
}
