namespace SSISH.Vistas
{
    partial class sis_principal
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
            this.P_menu = new System.Windows.Forms.Panel();
            this.BT_farmacia = new System.Windows.Forms.Button();
            this.BT_salir = new System.Windows.Forms.Button();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.PB_menu = new System.Windows.Forms.PictureBox();
            this.P_farmacia = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LB_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.P_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_menu)).BeginInit();
            this.P_farmacia.SuspendLayout();
            this.Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // P_menu
            // 
            this.P_menu.BackColor = System.Drawing.Color.Teal;
            this.P_menu.Controls.Add(this.button2);
            this.P_menu.Controls.Add(this.BT_farmacia);
            this.P_menu.Controls.Add(this.PB_menu);
            this.P_menu.Controls.Add(this.BT_salir);
            this.P_menu.Controls.Add(this.PB_logo);
            this.P_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_menu.Location = new System.Drawing.Point(0, 0);
            this.P_menu.Name = "P_menu";
            this.P_menu.Size = new System.Drawing.Size(158, 666);
            this.P_menu.TabIndex = 1;
            this.P_menu.MouseEnter += new System.EventHandler(this.P_menu_MouseEnter);
            // 
            // BT_farmacia
            // 
            this.BT_farmacia.BackColor = System.Drawing.Color.Teal;
            this.BT_farmacia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_farmacia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_farmacia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_farmacia.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_farmacia.FlatAppearance.BorderSize = 0;
            this.BT_farmacia.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_farmacia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.BT_farmacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_farmacia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_farmacia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_farmacia.Image = global::SSISH.Properties.Resources.pharmacist__1_;
            this.BT_farmacia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_farmacia.Location = new System.Drawing.Point(0, 160);
            this.BT_farmacia.Name = "BT_farmacia";
            this.BT_farmacia.Size = new System.Drawing.Size(158, 38);
            this.BT_farmacia.TabIndex = 35;
            this.BT_farmacia.Text = "Farmacia";
            this.BT_farmacia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_farmacia.UseVisualStyleBackColor = false;
            this.BT_farmacia.MouseEnter += new System.EventHandler(this.BT_farmacia_MouseEnter);
            this.BT_farmacia.MouseLeave += new System.EventHandler(this.BT_farmacia_MouseLeave);
            // 
            // BT_salir
            // 
            this.BT_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_salir.BackColor = System.Drawing.Color.Teal;
            this.BT_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_salir.FlatAppearance.BorderSize = 0;
            this.BT_salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.BT_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_salir.Location = new System.Drawing.Point(0, 624);
            this.BT_salir.Name = "BT_salir";
            this.BT_salir.Size = new System.Drawing.Size(158, 42);
            this.BT_salir.TabIndex = 40;
            this.BT_salir.Text = "Salir";
            this.BT_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_salir.UseVisualStyleBackColor = false;
            // 
            // PB_logo
            // 
            this.PB_logo.Image = global::SSISH.Properties.Resources.cita;
            this.PB_logo.Location = new System.Drawing.Point(43, 54);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(76, 80);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_logo.TabIndex = 2;
            this.PB_logo.TabStop = false;
            // 
            // PB_menu
            // 
            this.PB_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_menu.Image = global::SSISH.Properties.Resources.menu_onn;
            this.PB_menu.Location = new System.Drawing.Point(3, 0);
            this.PB_menu.Name = "PB_menu";
            this.PB_menu.Size = new System.Drawing.Size(41, 39);
            this.PB_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_menu.TabIndex = 1;
            this.PB_menu.TabStop = false;
            // 
            // P_farmacia
            // 
            this.P_farmacia.BackColor = System.Drawing.Color.Teal;
            this.P_farmacia.Controls.Add(this.button1);
            this.P_farmacia.Location = new System.Drawing.Point(158, 160);
            this.P_farmacia.Name = "P_farmacia";
            this.P_farmacia.Size = new System.Drawing.Size(168, 42);
            this.P_farmacia.TabIndex = 3;
            this.P_farmacia.Visible = false;
            this.P_farmacia.MouseEnter += new System.EventHandler(this.P_farmacia_MouseEnter);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::SSISH.Properties.Resources.pharmacist__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 42;
            this.button1.Text = "   NO Dispensado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::SSISH.Properties.Resources.horario;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 38);
            this.button2.TabIndex = 41;
            this.button2.Text = "Admision";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuario.BackColor = System.Drawing.Color.Teal;
            this.Usuario.Controls.Add(this.label1);
            this.Usuario.Controls.Add(this.LB_nombre);
            this.Usuario.Controls.Add(this.pictureBox2);
            this.Usuario.Location = new System.Drawing.Point(825, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(232, 69);
            this.Usuario.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::SSISH.Properties.Resources.persona;
            this.pictureBox2.Location = new System.Drawing.Point(167, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // LB_nombre
            // 
            this.LB_nombre.BackColor = System.Drawing.Color.Transparent;
            this.LB_nombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_nombre.ForeColor = System.Drawing.Color.White;
            this.LB_nombre.Location = new System.Drawing.Point(3, 9);
            this.LB_nombre.Name = "LB_nombre";
            this.LB_nombre.Size = new System.Drawing.Size(158, 22);
            this.LB_nombre.TabIndex = 110;
            this.LB_nombre.Text = "N_ usuario";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 111;
            this.label1.Text = "Uunidad...";
            // 
            // sis_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 666);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.P_farmacia);
            this.Controls.Add(this.P_menu);
            this.Name = "sis_principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sis_principal_Load);
            this.MouseEnter += new System.EventHandler(this.Sis_principal_MouseEnter);
            this.P_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_menu)).EndInit();
            this.P_farmacia.ResumeLayout(false);
            this.Usuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_menu;
        private System.Windows.Forms.Button BT_salir;
        private System.Windows.Forms.PictureBox PB_logo;
        private System.Windows.Forms.PictureBox PB_menu;
        private System.Windows.Forms.FlowLayoutPanel P_farmacia;
        private System.Windows.Forms.Button BT_farmacia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Usuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_nombre;
    }
}