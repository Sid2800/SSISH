namespace SSISH.Vistas
{
    partial class Usu_usu
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
            this.P_titulo = new System.Windows.Forms.Panel();
            this.BT_cerrar = new FontAwesome.Sharp.IconButton();
            this.LB_titulo = new System.Windows.Forms.Label();
            this.PB_user = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_guardar = new FontAwesome.Sharp.IconButton();
            this.BT_agregar = new FontAwesome.Sharp.IconButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TX_identidad = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TX_1nombre = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PB_foto = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_servicio = new System.Windows.Forms.ComboBox();
            this.TX_observaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LB_estadoimc = new System.Windows.Forms.Label();
            this.TX_temperatura = new System.Windows.Forms.MaskedTextBox();
            this.TX_imc = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TX_fr1 = new System.Windows.Forms.MaskedTextBox();
            this.TX_peso = new System.Windows.Forms.MaskedTextBox();
            this.TX_fr2 = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CK_activo = new MetroFramework.Controls.MetroToggle();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.P_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_user)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_titulo
            // 
            this.P_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.P_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_titulo.Controls.Add(this.BT_cerrar);
            this.P_titulo.Controls.Add(this.LB_titulo);
            this.P_titulo.Controls.Add(this.PB_user);
            this.P_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_titulo.Location = new System.Drawing.Point(0, 0);
            this.P_titulo.Name = "P_titulo";
            this.P_titulo.Size = new System.Drawing.Size(484, 60);
            this.P_titulo.TabIndex = 62;
            this.P_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseDown_1);
            this.P_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseMove_1);
            this.P_titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseUp_1);
            // 
            // BT_cerrar
            // 
            this.BT_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BT_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_cerrar.FlatAppearance.BorderSize = 0;
            this.BT_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cerrar.ForeColor = System.Drawing.Color.White;
            this.BT_cerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BT_cerrar.IconColor = System.Drawing.Color.White;
            this.BT_cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BT_cerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_cerrar.Location = new System.Drawing.Point(437, 0);
            this.BT_cerrar.Name = "BT_cerrar";
            this.BT_cerrar.Size = new System.Drawing.Size(45, 58);
            this.BT_cerrar.TabIndex = 112;
            this.BT_cerrar.UseVisualStyleBackColor = false;
            this.BT_cerrar.Click += new System.EventHandler(this.BT_cerrar_Click);
            // 
            // LB_titulo
            // 
            this.LB_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_titulo.BackColor = System.Drawing.Color.Transparent;
            this.LB_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_titulo.ForeColor = System.Drawing.Color.Cornsilk;
            this.LB_titulo.Location = new System.Drawing.Point(98, 10);
            this.LB_titulo.Name = "LB_titulo";
            this.LB_titulo.Size = new System.Drawing.Size(292, 37);
            this.LB_titulo.TabIndex = 108;
            this.LB_titulo.Text = "Agregar Usuario";
            this.LB_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_user
            // 
            this.PB_user.BackColor = System.Drawing.Color.Transparent;
            this.PB_user.Enabled = false;
            this.PB_user.Image = global::SSISH.Properties.Resources.persona;
            this.PB_user.Location = new System.Drawing.Point(8, 5);
            this.PB_user.Margin = new System.Windows.Forms.Padding(2);
            this.PB_user.Name = "PB_user";
            this.PB_user.Size = new System.Drawing.Size(54, 48);
            this.PB_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_user.TabIndex = 101;
            this.PB_user.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.BT_guardar);
            this.panel2.Controls.Add(this.BT_agregar);
            this.panel2.Location = new System.Drawing.Point(0, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 42);
            this.panel2.TabIndex = 69;
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.BT_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_guardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_guardar.FlatAppearance.BorderSize = 0;
            this.BT_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BT_guardar.IconColor = System.Drawing.Color.White;
            this.BT_guardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BT_guardar.IconSize = 40;
            this.BT_guardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BT_guardar.Location = new System.Drawing.Point(227, 0);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(126, 42);
            this.BT_guardar.TabIndex = 113;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BT_guardar.UseVisualStyleBackColor = false;
            // 
            // BT_agregar
            // 
            this.BT_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.BT_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_agregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_agregar.FlatAppearance.BorderSize = 0;
            this.BT_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregar.ForeColor = System.Drawing.Color.White;
            this.BT_agregar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BT_agregar.IconColor = System.Drawing.Color.White;
            this.BT_agregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BT_agregar.IconSize = 40;
            this.BT_agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BT_agregar.Location = new System.Drawing.Point(353, 0);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(126, 42);
            this.BT_agregar.TabIndex = 112;
            this.BT_agregar.Text = "Cancelar";
            this.BT_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BT_agregar.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.TX_identidad);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.TX_1nombre);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(9, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(469, 84);
            this.groupBox5.TabIndex = 130;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos generales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nombre Completo";
            // 
            // TX_identidad
            // 
            this.TX_identidad.BackColor = System.Drawing.SystemColors.Info;
            this.TX_identidad.Enabled = false;
            this.TX_identidad.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_identidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TX_identidad.Location = new System.Drawing.Point(9, 43);
            this.TX_identidad.Mask = "0000000000000";
            this.TX_identidad.Name = "TX_identidad";
            this.TX_identidad.Size = new System.Drawing.Size(145, 30);
            this.TX_identidad.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Identidad";
            // 
            // TX_1nombre
            // 
            this.TX_1nombre.Enabled = false;
            this.TX_1nombre.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_1nombre.Location = new System.Drawing.Point(160, 44);
            this.TX_1nombre.Name = "TX_1nombre";
            this.TX_1nombre.Size = new System.Drawing.Size(302, 30);
            this.TX_1nombre.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.PB_foto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CB_servicio);
            this.groupBox3.Controls.Add(this.TX_observaciones);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.LB_estadoimc);
            this.groupBox3.Controls.Add(this.TX_temperatura);
            this.groupBox3.Controls.Add(this.TX_imc);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TX_fr1);
            this.groupBox3.Controls.Add(this.TX_peso);
            this.groupBox3.Controls.Add(this.TX_fr2);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 279);
            this.groupBox3.TabIndex = 134;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario";
            // 
            // PB_foto
            // 
            this.PB_foto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PB_foto.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PB_foto.BorderColor2 = System.Drawing.Color.HotPink;
            this.PB_foto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PB_foto.BorderSize = 2;
            this.PB_foto.GradientAngle = 50F;
            this.PB_foto.Image = global::SSISH.Properties.Resources._036_man;
            this.PB_foto.Location = new System.Drawing.Point(307, 93);
            this.PB_foto.Name = "PB_foto";
            this.PB_foto.Size = new System.Drawing.Size(126, 126);
            this.PB_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_foto.TabIndex = 146;
            this.PB_foto.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 145;
            this.label9.Text = "Correo Electronico";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.maskedTextBox1.Location = new System.Drawing.Point(156, 236);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(302, 30);
            this.maskedTextBox1.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 143;
            this.label2.Text = "Confirmacion";
            // 
            // CB_servicio
            // 
            this.CB_servicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CB_servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_servicio.Enabled = false;
            this.CB_servicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_servicio.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.CB_servicio.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CB_servicio.FormattingEnabled = true;
            this.CB_servicio.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.CB_servicio.Location = new System.Drawing.Point(230, 51);
            this.CB_servicio.Name = "CB_servicio";
            this.CB_servicio.Size = new System.Drawing.Size(228, 31);
            this.CB_servicio.TabIndex = 142;
            // 
            // TX_observaciones
            // 
            this.TX_observaciones.Enabled = false;
            this.TX_observaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_observaciones.Location = new System.Drawing.Point(9, 183);
            this.TX_observaciones.Multiline = true;
            this.TX_observaciones.Name = "TX_observaciones";
            this.TX_observaciones.Size = new System.Drawing.Size(246, 30);
            this.TX_observaciones.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 140;
            this.label5.Text = "Unidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 138;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 137;
            this.label4.Text = "IMC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 134;
            this.label11.Text = "PA";
            // 
            // LB_estadoimc
            // 
            this.LB_estadoimc.BackColor = System.Drawing.Color.Transparent;
            this.LB_estadoimc.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_estadoimc.ForeColor = System.Drawing.Color.Black;
            this.LB_estadoimc.Location = new System.Drawing.Point(470, 70);
            this.LB_estadoimc.Name = "LB_estadoimc";
            this.LB_estadoimc.Size = new System.Drawing.Size(176, 18);
            this.LB_estadoimc.TabIndex = 125;
            this.LB_estadoimc.Text = "99/99/9999";
            this.LB_estadoimc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TX_temperatura
            // 
            this.TX_temperatura.Enabled = false;
            this.TX_temperatura.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_temperatura.Location = new System.Drawing.Point(9, 52);
            this.TX_temperatura.Name = "TX_temperatura";
            this.TX_temperatura.Size = new System.Drawing.Size(215, 30);
            this.TX_temperatura.TabIndex = 133;
            // 
            // TX_imc
            // 
            this.TX_imc.Enabled = false;
            this.TX_imc.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_imc.Location = new System.Drawing.Point(525, 22);
            this.TX_imc.Name = "TX_imc";
            this.TX_imc.Size = new System.Drawing.Size(119, 30);
            this.TX_imc.TabIndex = 132;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-62, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 131;
            this.label16.Text = "IMC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-34, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 20);
            this.label15.TabIndex = 129;
            this.label15.Text = "FR";
            // 
            // TX_fr1
            // 
            this.TX_fr1.Enabled = false;
            this.TX_fr1.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_fr1.Location = new System.Drawing.Point(527, 110);
            this.TX_fr1.Name = "TX_fr1";
            this.TX_fr1.Size = new System.Drawing.Size(61, 30);
            this.TX_fr1.TabIndex = 126;
            // 
            // TX_peso
            // 
            this.TX_peso.Enabled = false;
            this.TX_peso.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_peso.Location = new System.Drawing.Point(9, 116);
            this.TX_peso.Name = "TX_peso";
            this.TX_peso.Size = new System.Drawing.Size(246, 30);
            this.TX_peso.TabIndex = 124;
            // 
            // TX_fr2
            // 
            this.TX_fr2.Enabled = false;
            this.TX_fr2.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_fr2.Location = new System.Drawing.Point(585, 110);
            this.TX_fr2.Name = "TX_fr2";
            this.TX_fr2.Size = new System.Drawing.Size(59, 30);
            this.TX_fr2.TabIndex = 123;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 20);
            this.label20.TabIndex = 122;
            this.label20.Text = "User ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CK_activo);
            this.groupBox1.Controls.Add(this.DT_inicio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 66);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // CK_activo
            // 
            this.CK_activo.AutoSize = true;
            this.CK_activo.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CK_activo.Location = new System.Drawing.Point(52, 29);
            this.CK_activo.Name = "CK_activo";
            this.CK_activo.Size = new System.Drawing.Size(80, 24);
            this.CK_activo.Style = MetroFramework.MetroColorStyle.Orange;
            this.CK_activo.TabIndex = 118;
            this.CK_activo.Text = "Off";
            this.CK_activo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CK_activo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CK_activo.UseSelectable = true;
            // 
            // DT_inicio
            // 
            this.DT_inicio.CalendarFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Enabled = false;
            this.DT_inicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_inicio.Location = new System.Drawing.Point(339, 26);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(120, 27);
            this.DT_inicio.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vencimiento";
            // 
            // Usu_usu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.P_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "Usu_usu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usu_usu";
            this.P_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_user)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_titulo;
        private System.Windows.Forms.Label LB_titulo;
        private System.Windows.Forms.PictureBox PB_user;
        private FontAwesome.Sharp.IconButton BT_cerrar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BT_agregar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TX_identidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TX_1nombre;
        private FontAwesome.Sharp.IconButton BT_guardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_servicio;
        private System.Windows.Forms.TextBox TX_observaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LB_estadoimc;
        private System.Windows.Forms.MaskedTextBox TX_temperatura;
        private System.Windows.Forms.MaskedTextBox TX_imc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox TX_fr1;
        private System.Windows.Forms.MaskedTextBox TX_peso;
        private System.Windows.Forms.MaskedTextBox TX_fr2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroToggle CK_activo;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJCircularPictureBox PB_foto;
    }
}