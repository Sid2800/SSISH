using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSISH.Modelos
{
    internal class M_sesion
    {
        public int Id_sesion { get; set; }

        public string Depto { get; set; }

        public Byte[] Foto { get; set; }

        public string Id_user { get; set;}


        public String Inicio { get; set; }

        public String Fin { get; set; }

        public DateTime Dia { get; set; }

        public Boolean Estado { get; set; } 






        /// Metodos para uso para procesos del sistema
        public static Boolean Existe { get; set; } // metodo

        public static int Sesion_activa { get; set; }


    }
}
