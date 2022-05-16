using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSISH.Vistas
{
    public partial class Usu_usu : Form
    {


        #region   Inteaciion con la ventana del formulario

        public int mouseX = 0, mouseY = 0;
        public Boolean arrastre = false;


        //  Extender o reducir el tamaño del formulario

        private const int cGrip = 32;      // Grip size

        private void P_titulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            arrastre = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void P_titulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (arrastre)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void P_titulo_MouseUp_1(object sender, MouseEventArgs e)
        {
            arrastre = false;
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }



        #endregion



        public Usu_usu()
        {
            InitializeComponent();
        }

        private void BT_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
