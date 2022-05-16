using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSISH.Controles;
using SSISH.Modelos;


namespace SSISH.Vistas
{


    public partial class Usu_admin : Form
    {
        //INstancias a clases-entidades
        C_user Cusuario = new C_user();

        public Usu_admin()
        {
            InitializeComponent();
            Llenar_Grid();

        }



        #region   Inteaciion con la ventana del formulario


        public int mouseX = 0, mouseY = 0;
        public Boolean arrastre = false;

        private void P_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            arrastre = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void P_titulo_MouseUp(object sender, MouseEventArgs e)
        {
            arrastre = false;
        }


        private void P_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastre)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX,MousePosition.Y - mouseY);
            }
        }

 


        //  Extender o reducir el tamaño del formulario

        private const int cGrip = 48;      // Grip size
        private const int cCaption = 32;   // Altura de barra de título;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }





        #endregion

        public void Llenar_Grid()
        {
            string Qry = $"EXECUTE [dbo].[PC_USUARIOS_LISTAR]";
            Cusuario.Listar_usuario(Qry);
            DGV_datos.DataSource = M_user.Datos;
        }

        public void Filtrar_datos()
        {
            if (M_user.Datos != null)
            {
                M_user.Datos.DefaultView.RowFilter =
                $"Identidad + Usuario + Nombre + Unidad like'%" +
                this.TX_buscar.Texts + "%'";
            }
        }

        private void TX_buscar__TextChanged(object sender, EventArgs e)
        {
            Filtrar_datos();
        }

        private void BT_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
