using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSISH.Modelos
{
    class M_user
    {
        public string Id_user { get; set; }

        public string Identidad { get; set; }
        public string Nombre { get; set; } 

        public string Contra { get; set; }

        public int Id_depto { get; set; }

        public string Depto { get; set; }

        public Boolean Estado { get; set; }

     
        /// Metodos para uso para procesos del sistema
        public static Boolean Existe { get; set; } // metodo

        public static DataTable Datos { get; set; } // metodo

        public static string Usuario_activo { get; set; }

    }
}
