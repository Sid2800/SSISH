namespace SSISH.Vistas
{
    partial class Far_nodispensadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Titulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_cita = new System.Windows.Forms.MaskedTextBox();
            this.TX_ate = new System.Windows.Forms.TextBox();
            this.PB_foto = new System.Windows.Forms.PictureBox();
            this.LB_siguiente = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.PB_sexo = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TX_edad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TX_direccion = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TX_1nombre = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.LB_nombre_med = new System.Windows.Forms.Label();
            this.TP_observaciones = new System.Windows.Forms.TabPage();
            this.TX_observaciones = new System.Windows.Forms.TextBox();
            this.TP_medicamentos = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_eliminar_diag = new System.Windows.Forms.Button();
            this.BT_agregar_diag = new System.Windows.Forms.Button();
            this.DGV_diag = new System.Windows.Forms.DataGridView();
            this.TC_evaluacion = new System.Windows.Forms.TabControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LB_modo = new System.Windows.Forms.Label();
            this.BT_cerrar = new FontAwesome.Sharp.IconButton();
            this.BT_guardar = new FontAwesome.Sharp.IconButton();
            this.BT_agregar = new FontAwesome.Sharp.IconButton();
            this.Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_sexo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.TP_observaciones.SuspendLayout();
            this.TP_medicamentos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_diag)).BeginInit();
            this.TC_evaluacion.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Controls.Add(this.BT_cerrar);
            this.Titulo.Controls.Add(this.label2);
            this.Titulo.Controls.Add(this.TX_cita);
            this.Titulo.Controls.Add(this.TX_ate);
            this.Titulo.Controls.Add(this.PB_foto);
            this.Titulo.Controls.Add(this.LB_siguiente);
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(674, 64);
            this.Titulo.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(101, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 108;
            this.label2.Text = "Receta";
            // 
            // TX_cita
            // 
            this.TX_cita.BackColor = System.Drawing.SystemColors.Info;
            this.TX_cita.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TX_cita.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_cita.ForeColor = System.Drawing.Color.OliveDrab;
            this.TX_cita.Location = new System.Drawing.Point(445, 18);
            this.TX_cita.Mask = "0000000000000";
            this.TX_cita.Name = "TX_cita";
            this.TX_cita.Size = new System.Drawing.Size(161, 30);
            this.TX_cita.TabIndex = 0;
            // 
            // TX_ate
            // 
            this.TX_ate.BackColor = System.Drawing.Color.Ivory;
            this.TX_ate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX_ate.Enabled = false;
            this.TX_ate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_ate.ForeColor = System.Drawing.Color.OliveDrab;
            this.TX_ate.Location = new System.Drawing.Point(237, 22);
            this.TX_ate.Name = "TX_ate";
            this.TX_ate.Size = new System.Drawing.Size(71, 29);
            this.TX_ate.TabIndex = 500;
            this.TX_ate.Text = "00000";
            this.TX_ate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PB_foto
            // 
            this.PB_foto.BackColor = System.Drawing.Color.Transparent;
            this.PB_foto.BackgroundImage = global::SSISH.Properties.Resources.Baucher;
            this.PB_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_foto.Enabled = false;
            this.PB_foto.Location = new System.Drawing.Point(14, 5);
            this.PB_foto.Margin = new System.Windows.Forms.Padding(2);
            this.PB_foto.Name = "PB_foto";
            this.PB_foto.Size = new System.Drawing.Size(49, 46);
            this.PB_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_foto.TabIndex = 101;
            this.PB_foto.TabStop = false;
            // 
            // LB_siguiente
            // 
            this.LB_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.LB_siguiente.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_siguiente.ForeColor = System.Drawing.Color.Transparent;
            this.LB_siguiente.Location = new System.Drawing.Point(337, 22);
            this.LB_siguiente.Name = "LB_siguiente";
            this.LB_siguiente.Size = new System.Drawing.Size(89, 22);
            this.LB_siguiente.TabIndex = 107;
            this.LB_siguiente.Text = "Indentidad";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.maskedTextBox1);
            this.groupBox5.Controls.Add(this.PB_sexo);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TX_edad);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.TX_direccion);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.TX_1nombre);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(662, 144);
            this.groupBox5.TabIndex = 130;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos Paciente";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.maskedTextBox1.Location = new System.Drawing.Point(456, 46);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(153, 30);
            this.maskedTextBox1.TabIndex = 117;
            // 
            // PB_sexo
            // 
            this.PB_sexo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PB_sexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_sexo.Enabled = false;
            this.PB_sexo.Image = global::SSISH.Properties.Resources.HOmbre;
            this.PB_sexo.Location = new System.Drawing.Point(614, 41);
            this.PB_sexo.Margin = new System.Windows.Forms.Padding(2);
            this.PB_sexo.Name = "PB_sexo";
            this.PB_sexo.Size = new System.Drawing.Size(38, 41);
            this.PB_sexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_sexo.TabIndex = 102;
            this.PB_sexo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(608, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 116;
            this.label9.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Exp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 115;
            this.label8.Text = "Edad";
            // 
            // TX_edad
            // 
            this.TX_edad.BackColor = System.Drawing.SystemColors.InfoText;
            this.TX_edad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX_edad.Enabled = false;
            this.TX_edad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_edad.ForeColor = System.Drawing.Color.YellowGreen;
            this.TX_edad.Location = new System.Drawing.Point(13, 101);
            this.TX_edad.Name = "TX_edad";
            this.TX_edad.Size = new System.Drawing.Size(141, 29);
            this.TX_edad.TabIndex = 44;
            this.TX_edad.Text = "0";
            this.TX_edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 114;
            this.label6.Text = "Direccion";
            // 
            // TX_direccion
            // 
            this.TX_direccion.Enabled = false;
            this.TX_direccion.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_direccion.Location = new System.Drawing.Point(160, 99);
            this.TX_direccion.Name = "TX_direccion";
            this.TX_direccion.Size = new System.Drawing.Size(492, 30);
            this.TX_direccion.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nombre Completo";
            // 
            // TX_1nombre
            // 
            this.TX_1nombre.Enabled = false;
            this.TX_1nombre.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.TX_1nombre.Location = new System.Drawing.Point(13, 46);
            this.TX_1nombre.Name = "TX_1nombre";
            this.TX_1nombre.Size = new System.Drawing.Size(430, 30);
            this.TX_1nombre.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.DT_inicio);
            this.groupBox2.Controls.Add(this.LB_nombre_med);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 58);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            // 
            // DT_inicio
            // 
            this.DT_inicio.CalendarFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Enabled = false;
            this.DT_inicio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_inicio.Location = new System.Drawing.Point(98, 19);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(179, 27);
            this.DT_inicio.TabIndex = 123;
            // 
            // LB_nombre_med
            // 
            this.LB_nombre_med.BackColor = System.Drawing.Color.Transparent;
            this.LB_nombre_med.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_nombre_med.ForeColor = System.Drawing.Color.Black;
            this.LB_nombre_med.Location = new System.Drawing.Point(17, 23);
            this.LB_nombre_med.Name = "LB_nombre_med";
            this.LB_nombre_med.Size = new System.Drawing.Size(86, 22);
            this.LB_nombre_med.TabIndex = 122;
            this.LB_nombre_med.Text = "Fecha";
            this.LB_nombre_med.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TP_observaciones
            // 
            this.TP_observaciones.Controls.Add(this.TX_observaciones);
            this.TP_observaciones.Location = new System.Drawing.Point(4, 27);
            this.TP_observaciones.Name = "TP_observaciones";
            this.TP_observaciones.Size = new System.Drawing.Size(653, 186);
            this.TP_observaciones.TabIndex = 3;
            this.TP_observaciones.Text = "Observaciones";
            this.TP_observaciones.UseVisualStyleBackColor = true;
            // 
            // TX_observaciones
            // 
            this.TX_observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TX_observaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_observaciones.Location = new System.Drawing.Point(0, 0);
            this.TX_observaciones.Multiline = true;
            this.TX_observaciones.Name = "TX_observaciones";
            this.TX_observaciones.Size = new System.Drawing.Size(653, 186);
            this.TX_observaciones.TabIndex = 142;
            // 
            // TP_medicamentos
            // 
            this.TP_medicamentos.BackColor = System.Drawing.Color.Transparent;
            this.TP_medicamentos.Controls.Add(this.panel2);
            this.TP_medicamentos.Controls.Add(this.DGV_diag);
            this.TP_medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_medicamentos.Location = new System.Drawing.Point(4, 27);
            this.TP_medicamentos.Name = "TP_medicamentos";
            this.TP_medicamentos.Padding = new System.Windows.Forms.Padding(3);
            this.TP_medicamentos.Size = new System.Drawing.Size(653, 186);
            this.TP_medicamentos.TabIndex = 1;
            this.TP_medicamentos.Text = "Diagnostico";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BT_eliminar_diag);
            this.panel2.Controls.Add(this.BT_agregar_diag);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(605, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 180);
            this.panel2.TabIndex = 131;
            // 
            // BT_eliminar_diag
            // 
            this.BT_eliminar_diag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_eliminar_diag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.BT_eliminar_diag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_eliminar_diag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_eliminar_diag.Enabled = false;
            this.BT_eliminar_diag.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_eliminar_diag.FlatAppearance.BorderSize = 0;
            this.BT_eliminar_diag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_eliminar_diag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_eliminar_diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar_diag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_eliminar_diag.Image = global::SSISH.Properties.Resources.limpiar24;
            this.BT_eliminar_diag.Location = new System.Drawing.Point(-2, 138);
            this.BT_eliminar_diag.Name = "BT_eliminar_diag";
            this.BT_eliminar_diag.Size = new System.Drawing.Size(47, 38);
            this.BT_eliminar_diag.TabIndex = 19;
            this.BT_eliminar_diag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_eliminar_diag.UseVisualStyleBackColor = false;
            // 
            // BT_agregar_diag
            // 
            this.BT_agregar_diag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_agregar_diag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.BT_agregar_diag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_agregar_diag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_agregar_diag.Enabled = false;
            this.BT_agregar_diag.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_agregar_diag.FlatAppearance.BorderSize = 0;
            this.BT_agregar_diag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_agregar_diag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_agregar_diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregar_diag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_agregar_diag.Image = global::SSISH.Properties.Resources.Nuevo224;
            this.BT_agregar_diag.Location = new System.Drawing.Point(-2, 99);
            this.BT_agregar_diag.Name = "BT_agregar_diag";
            this.BT_agregar_diag.Size = new System.Drawing.Size(47, 38);
            this.BT_agregar_diag.TabIndex = 18;
            this.BT_agregar_diag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_agregar_diag.UseVisualStyleBackColor = false;
            // 
            // DGV_diag
            // 
            this.DGV_diag.AllowUserToAddRows = false;
            this.DGV_diag.AllowUserToDeleteRows = false;
            this.DGV_diag.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_diag.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGV_diag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_diag.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGV_diag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_diag.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_diag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGV_diag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_diag.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_diag.DefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_diag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_diag.EnableHeadersVisualStyles = false;
            this.DGV_diag.Location = new System.Drawing.Point(3, 3);
            this.DGV_diag.Name = "DGV_diag";
            this.DGV_diag.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_diag.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_diag.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_diag.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGV_diag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_diag.Size = new System.Drawing.Size(647, 180);
            this.DGV_diag.TabIndex = 130;
            // 
            // TC_evaluacion
            // 
            this.TC_evaluacion.Controls.Add(this.TP_medicamentos);
            this.TC_evaluacion.Controls.Add(this.TP_observaciones);
            this.TC_evaluacion.Enabled = false;
            this.TC_evaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_evaluacion.Location = new System.Drawing.Point(7, 287);
            this.TC_evaluacion.Margin = new System.Windows.Forms.Padding(6);
            this.TC_evaluacion.Name = "TC_evaluacion";
            this.TC_evaluacion.SelectedIndex = 0;
            this.TC_evaluacion.Size = new System.Drawing.Size(661, 217);
            this.TC_evaluacion.TabIndex = 131;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(108)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BT_guardar);
            this.panel4.Controls.Add(this.BT_agregar);
            this.panel4.Controls.Add(this.LB_modo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(674, 42);
            this.panel4.TabIndex = 137;
            // 
            // LB_modo
            // 
            this.LB_modo.BackColor = System.Drawing.Color.Transparent;
            this.LB_modo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_modo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.LB_modo.Location = new System.Drawing.Point(11, 11);
            this.LB_modo.Name = "LB_modo";
            this.LB_modo.Size = new System.Drawing.Size(128, 22);
            this.LB_modo.TabIndex = 114;
            this.LB_modo.Text = "########";
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
            this.BT_cerrar.Location = new System.Drawing.Point(632, 0);
            this.BT_cerrar.Name = "BT_cerrar";
            this.BT_cerrar.Size = new System.Drawing.Size(40, 62);
            this.BT_cerrar.TabIndex = 501;
            this.BT_cerrar.UseVisualStyleBackColor = false;
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
            this.BT_guardar.Location = new System.Drawing.Point(420, 0);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(126, 40);
            this.BT_guardar.TabIndex = 116;
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
            this.BT_agregar.Location = new System.Drawing.Point(546, 0);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(126, 40);
            this.BT_agregar.TabIndex = 115;
            this.BT_agregar.Text = "Cancelar";
            this.BT_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BT_agregar.UseVisualStyleBackColor = false;
            // 
            // Far_nodispensadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 567);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TC_evaluacion);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Far_nodispensadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos no dispensados";
            this.Titulo.ResumeLayout(false);
            this.Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_sexo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.TP_observaciones.ResumeLayout(false);
            this.TP_observaciones.PerformLayout();
            this.TP_medicamentos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_diag)).EndInit();
            this.TC_evaluacion.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TX_cita;
        private System.Windows.Forms.TextBox TX_ate;
        private System.Windows.Forms.PictureBox PB_foto;
        private System.Windows.Forms.Label LB_siguiente;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox PB_sexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TX_edad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TX_direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TX_1nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LB_nombre_med;
        private System.Windows.Forms.TabPage TP_observaciones;
        private System.Windows.Forms.TextBox TX_observaciones;
        private System.Windows.Forms.TabPage TP_medicamentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_eliminar_diag;
        private System.Windows.Forms.Button BT_agregar_diag;
        private System.Windows.Forms.DataGridView DGV_diag;
        private System.Windows.Forms.TabControl TC_evaluacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LB_modo;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private FontAwesome.Sharp.IconButton BT_cerrar;
        private FontAwesome.Sharp.IconButton BT_guardar;
        private FontAwesome.Sharp.IconButton BT_agregar;
    }
}