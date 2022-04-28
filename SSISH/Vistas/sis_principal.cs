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
    public partial class sis_principal : Form
    {
        public sis_principal()
        {
            InitializeComponent();
        }

        private void Sis_principal_Load(object sender, EventArgs e)
        {

        }

        private void BT_farmacia_MouseEnter(object sender, EventArgs e)
        {
            P_farmacia.Visible = true;
        }

        private void BT_farmacia_MouseLeave(object sender, EventArgs e)
        {
           // P_farmacia.Visible = false;
        }

        private void P_farmacia_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void BT_nodispensado_MouseEnter(object sender, EventArgs e)
        {
            P_farmacia.Visible = true;
        }

        private void P_menu_MouseEnter(object sender, EventArgs e)
        {
            Limpiar_paneles();
        }

        void Limpiar_paneles()

        {
            //Ocultar todo
            P_farmacia.Visible = false;
        }

        private void P_fondo_MouseEnter(object sender, EventArgs e)
        {
            Limpiar_paneles();
        }

        private void Sis_principal_MouseEnter(object sender, EventArgs e)
        {
            Limpiar_paneles();
        }
    }
}
