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
    public partial class sis_login : Form
    {
        M_user usuario = new M_user();

        readonly C_sesion controlS = new C_sesion();

        readonly C_user control = new C_user();

        public sis_login()
        {
            InitializeComponent();
        }

  


        Boolean Comprobar_lleno()
        {
            Boolean lleno;
            if (string.IsNullOrEmpty(TX_usuario.Text )
                || string.IsNullOrEmpty(TX_contrasenia.Text)

                )
            { lleno = false; }
            else { lleno = true; }
            return lleno;
        }
                
        #region efectos visuales TXtbox

        private void TX_usuario_Enter(object sender, EventArgs e)
        {
            if (TX_usuario.Text == "Usuario")
            {
                TX_usuario.Clear();
                TX_usuario.ForeColor = Color.DarkSlateGray;
            }
        }

        private void TX_contrasenia_Enter(object sender, EventArgs e)
        {
            if (TX_contrasenia.Text == "Contraseña")
            {
                TX_contrasenia.Clear();
                TX_contrasenia.ForeColor = Color.DarkSlateGray;
                TX_contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void TX_usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TX_usuario.Text))
            {
                TX_usuario.Text = "Usuario";
                TX_usuario.ForeColor = Color.DarkGray;
            }
        }

        private void TX_contrasenia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TX_contrasenia.Text))
            {
                TX_contrasenia.UseSystemPasswordChar = false;
                TX_contrasenia.Text = "Contraseña";
                TX_contrasenia.ForeColor = Color.DarkGray;
                
            }
        }

        #endregion

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_ingresar_Click(object sender, EventArgs e)
        {
            {
                string user = TX_usuario.Text;                
                string contra = TX_contrasenia.Text.ToString();
                /// coomprobar si usuario existe 

                usuario = control.Buscar_usuario(user);
                // comprobar texbox llenos
                if (Comprobar_lleno())
                {
                    if (M_user.Existe == true)// Si existe el ID Usuario
                    {
                        // Vefiricacion  estado de Usuario
                        if (usuario.Estado == true)
                        {
                            if (usuario.Contra == contra)
                            {
                                MessageBox.Show("Te has logeado correctamente, Bienvenido al sistema ",
                                       "SSISH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Inicio_sesion();
                            }
                            else
                            {
                
                                MessageBox.Show("Datos Incorrectos, o contraseña erronea", 
                                           "SSISH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Limpiar();
                            }
                        }
                        // En caso de Usario inactivo
                        else
                        {
                            MessageBox.Show("El usuario " + user + " esta desactivado, utiliza un usuario valido",
                            "SSISH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Limpiar();

                        }

                        // en caso que el usuario no existe
                    }
                    else
                    {
                        MessageBox.Show("El usuario " + user + " no existe, corrije y vuelve a intentar ",
                                 "SSISH", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                // en caso que los texbx estan vacios         
                else
                {
                    MessageBox.Show("Hay campos sin ingresar, tu deberias saber esto",
                "SSISH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

           
            }
        }

         void Limpiar()
        {
            TX_usuario.Text = "Usuario";
            TX_usuario.ForeColor = Color.DarkGray;
            TX_contrasenia.Text = "Contraseña";
            TX_contrasenia.ForeColor = Color.DarkGray;
            TX_contrasenia.UseSystemPasswordChar = false;
        }

        /// llamado y regsitro de secion
        void Inicio_sesion()
        {
            this.Hide();
            M_user.Usuario_activo = usuario.Id_user;
            // Modelamos la sesion de inicio
            M_sesion sesion = new M_sesion
            {
                Inicio = DateTime.Now.ToString("hh:mm:ss"),
                Fin = "0",
                Id_user = usuario.Id_user,
                Dia = DateTime.Now.Date
            };
            controlS.Inicio_sesion(sesion);

            sesion = controlS.Buscar_sesion_recienagregada();

            M_sesion.Sesion_activa = sesion.Id_sesion;


            //llamado al formulario
            sis_principal principal = new sis_principal();
            principal.Show();
        
        
        }

        private void LP_recuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlS.Cerrar_Sesion(1, DateTime.Now.ToString("hh:mm:ss"));
        }
    }
}
