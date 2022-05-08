namespace SSISH.Vistas
{
    partial class sis_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sis_login));
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.LP_recuperar = new System.Windows.Forms.LinkLabel();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.TX_contrasenia = new System.Windows.Forms.TextBox();
            this.TX_usuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.SteelBlue;
            this.BT_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BT_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ingresar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BT_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_ingresar.Location = new System.Drawing.Point(42, 447);
            this.BT_ingresar.Name = "BT_ingresar";
            this.BT_ingresar.Size = new System.Drawing.Size(296, 49);
            this.BT_ingresar.TabIndex = 51;
            this.BT_ingresar.Text = "Ingresar";
            this.BT_ingresar.UseVisualStyleBackColor = false;
            this.BT_ingresar.Click += new System.EventHandler(this.BT_ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 46);
            this.label1.TabIndex = 50;
            this.label1.Text = "SSISH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 68);
            this.panel1.TabIndex = 54;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.White;
            this.btncerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btncerrar.IconColor = System.Drawing.Color.White;
            this.btncerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncerrar.Location = new System.Drawing.Point(335, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(45, 68);
            this.btncerrar.TabIndex = 63;
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 36;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(23, 358);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 46);
            this.iconButton1.TabIndex = 55;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(41, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "______________________________________";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 36;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(23, 278);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(36, 46);
            this.iconButton2.TabIndex = 57;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(41, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "______________________________________";
            // 
            // LP_recuperar
            // 
            this.LP_recuperar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LP_recuperar.AutoSize = true;
            this.LP_recuperar.BackColor = System.Drawing.Color.Transparent;
            this.LP_recuperar.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(69)))), ((int)(((byte)(135)))));
            this.LP_recuperar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_recuperar.LinkColor = System.Drawing.Color.Silver;
            this.LP_recuperar.Location = new System.Drawing.Point(116, 513);
            this.LP_recuperar.Name = "LP_recuperar";
            this.LP_recuperar.Size = new System.Drawing.Size(167, 19);
            this.LP_recuperar.TabIndex = 59;
            this.LP_recuperar.TabStop = true;
            this.LP_recuperar.Text = "Recuperar Contraseña";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 0;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::SSISH.Properties.Resources.HOSP_LOGO_png;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(110, 78);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(166, 166);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 60;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // TX_contrasenia
            // 
            this.TX_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TX_contrasenia.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F);
            this.TX_contrasenia.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TX_contrasenia.Location = new System.Drawing.Point(74, 367);
            this.TX_contrasenia.Name = "TX_contrasenia";
            this.TX_contrasenia.Size = new System.Drawing.Size(257, 24);
            this.TX_contrasenia.TabIndex = 61;
            this.TX_contrasenia.Text = "Contraseña";
            this.TX_contrasenia.Enter += new System.EventHandler(this.TX_contrasenia_Enter);
            this.TX_contrasenia.Leave += new System.EventHandler(this.TX_contrasenia_Leave);
            // 
            // TX_usuario
            // 
            this.TX_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TX_usuario.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F);
            this.TX_usuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TX_usuario.Location = new System.Drawing.Point(74, 288);
            this.TX_usuario.Name = "TX_usuario";
            this.TX_usuario.Size = new System.Drawing.Size(257, 24);
            this.TX_usuario.TabIndex = 62;
            this.TX_usuario.Text = "Usuario";
            this.TX_usuario.Enter += new System.EventHandler(this.TX_usuario_Enter);
            this.TX_usuario.Leave += new System.EventHandler(this.TX_usuario_Leave);
            // 
            // sis_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 573);
            this.Controls.Add(this.TX_usuario);
            this.Controls.Add(this.TX_contrasenia);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.LP_recuperar);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sis_login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sis_login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LP_recuperar;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.TextBox TX_contrasenia;
        private System.Windows.Forms.TextBox TX_usuario;
        private FontAwesome.Sharp.IconButton btncerrar;
    }
}