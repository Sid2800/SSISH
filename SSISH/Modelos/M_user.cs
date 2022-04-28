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
        public int Id_usu { get; set; }

        public Boolean Estado { get; set; }

        public string Descripcion { get; set; }

        public string Contra { get; set; }


        public int Id_acc { get; set; }

        public string Identidad { get; set; } // metodo


        /// Metodos para uso para procesos del sistema
        public static Boolean Existe { get; set; } // metodo

        public static DataTable Datos { get; set; } // metodo

        public static int Usuario_activo { get; set; }

    }
}
