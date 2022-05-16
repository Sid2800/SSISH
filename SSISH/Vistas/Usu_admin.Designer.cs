namespace SSISH.Vistas
{
    partial class Usu_admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.P_titulo = new System.Windows.Forms.Panel();
            this.TX_buscar = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_datos = new System.Windows.Forms.DataGridView();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.BT_editar = new FontAwesome.Sharp.IconButton();
            this.BT_agregar = new FontAwesome.Sharp.IconButton();
            this.BT_cerrar = new FontAwesome.Sharp.IconButton();
            this.PB_foto = new System.Windows.Forms.PictureBox();
            this.P_titulo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // P_titulo
            // 
            this.P_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.P_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_titulo.Controls.Add(this.TX_buscar);
            this.P_titulo.Controls.Add(this.label2);
            this.P_titulo.Controls.Add(this.label1);
            this.P_titulo.Controls.Add(this.BT_cerrar);
            this.P_titulo.Controls.Add(this.PB_foto);
            this.P_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_titulo.Location = new System.Drawing.Point(0, 0);
            this.P_titulo.Name = "P_titulo";
            this.P_titulo.Size = new System.Drawing.Size(732, 62);
            this.P_titulo.TabIndex = 67;
            this.P_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseDown);
            this.P_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseMove);
            this.P_titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_titulo_MouseUp);
            // 
            // TX_buscar
            // 
            this.TX_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TX_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.TX_buscar.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.TX_buscar.BorderFocusColor = System.Drawing.Color.DarkTurquoise;
            this.TX_buscar.BorderRadius = 0;
            this.TX_buscar.BorderSize = 2;
            this.TX_buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TX_buscar.Location = new System.Drawing.Point(423, 12);
            this.TX_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.TX_buscar.Multiline = false;
            this.TX_buscar.Name = "TX_buscar";
            this.TX_buscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TX_buscar.PasswordChar = false;
            this.TX_buscar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TX_buscar.PlaceholderText = "";
            this.TX_buscar.Size = new System.Drawing.Size(250, 35);
            this.TX_buscar.TabIndex = 113;
            this.TX_buscar.Texts = "";
            this.TX_buscar.UnderlinedStyle = false;
            this.TX_buscar._TextChanged += new System.EventHandler(this.TX_buscar__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trajan Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(92, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 112;
            this.label2.Text = "Usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(337, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Busqueda";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.BT_editar);
            this.panel2.Controls.Add(this.BT_agregar);
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 42);
            this.panel2.TabIndex = 68;
            // 
            // DGV_datos
            // 
            this.DGV_datos.AllowUserToAddRows = false;
            this.DGV_datos.AllowUserToDeleteRows = false;
            this.DGV_datos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_datos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGV_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_datos.EnableHeadersVisualStyles = false;
            this.DGV_datos.Location = new System.Drawing.Point(0, 59);
            this.DGV_datos.Name = "DGV_datos";
            this.DGV_datos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_datos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_datos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_datos.Size = new System.Drawing.Size(732, 300);
            this.DGV_datos.TabIndex = 69;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 40;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton3.Location = new System.Drawing.Point(622, -1);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(104, 43);
            this.iconButton3.TabIndex = 114;
            this.iconButton3.Text = "PDF";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // BT_editar
            // 
            this.BT_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BT_editar.FlatAppearance.BorderSize = 0;
            this.BT_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_editar.ForeColor = System.Drawing.Color.White;
            this.BT_editar.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.BT_editar.IconColor = System.Drawing.Color.White;
            this.BT_editar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BT_editar.IconSize = 40;
            this.BT_editar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BT_editar.Location = new System.Drawing.Point(116, 0);
            this.BT_editar.Name = "BT_editar";
            this.BT_editar.Size = new System.Drawing.Size(116, 42);
            this.BT_editar.TabIndex = 113;
            this.BT_editar.Text = "Editar";
            this.BT_editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BT_editar.UseVisualStyleBackColor = false;
            // 
            // BT_agregar
            // 
            this.BT_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_agregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BT_agregar.FlatAppearance.BorderSize = 0;
            this.BT_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.BT_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregar.ForeColor = System.Drawing.Color.White;
            this.BT_agregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.BT_agregar.IconColor = System.Drawing.Color.White;
            this.BT_agregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BT_agregar.IconSize = 40;
            this.BT_agregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BT_agregar.Location = new System.Drawing.Point(0, 0);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(116, 42);
            this.BT_agregar.TabIndex = 112;
            this.BT_agregar.Text = "Agregar";
            this.BT_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BT_agregar.UseVisualStyleBackColor = false;
            // 
            // BT_cerrar
            // 
            this.BT_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
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
            this.BT_cerrar.Location = new System.Drawing.Point(685, 0);
            this.BT_cerrar.Name = "BT_cerrar";
            this.BT_cerrar.Size = new System.Drawing.Size(45, 60);
            this.BT_cerrar.TabIndex = 111;
            this.BT_cerrar.UseVisualStyleBackColor = false;
            this.BT_cerrar.Click += new System.EventHandler(this.BT_cerrar_Click);
            // 
            // PB_foto
            // 
            this.PB_foto.BackColor = System.Drawing.Color.Transparent;
            this.PB_foto.Enabled = false;
            this.PB_foto.Image = global::SSISH.Properties.Resources.usuario;
            this.PB_foto.Location = new System.Drawing.Point(4, 2);
            this.PB_foto.Margin = new System.Windows.Forms.Padding(2);
            this.PB_foto.Name = "PB_foto";
            this.PB_foto.Size = new System.Drawing.Size(52, 51);
            this.PB_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_foto.TabIndex = 102;
            this.PB_foto.TabStop = false;
            // 
            // Usu_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 398);
            this.Controls.Add(this.DGV_datos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.P_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "Usu_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usu_admin";
            this.P_titulo.ResumeLayout(false);
            this.P_titulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_titulo;
        private System.Windows.Forms.PictureBox PB_foto;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BT_cerrar;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox TX_buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_datos;
        private FontAwesome.Sharp.IconButton BT_agregar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton BT_editar;
    }
}