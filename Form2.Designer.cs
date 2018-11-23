namespace PE_1._0
{
    partial class sign_in_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_in_frm));
            this.sign_in_pnl = new System.Windows.Forms.Panel();
            this.codigo_bx = new System.Windows.Forms.TextBox();
            this.show2_cbx = new System.Windows.Forms.CheckBox();
            this.show1_cbx = new System.Windows.Forms.CheckBox();
            this.semestre_cmbx = new System.Windows.Forms.ComboBox();
            this.confirm_password_lbl = new System.Windows.Forms.Label();
            this.confirm_password_txtbx = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.sign_in_image_pnl = new System.Windows.Forms.Panel();
            this.nombres_lbl = new System.Windows.Forms.Label();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.codigo_lbl = new System.Windows.Forms.Label();
            this.apellidos_txtbx = new System.Windows.Forms.TextBox();
            this.apellidos_lbl = new System.Windows.Forms.Label();
            this.semestre_lbl = new System.Windows.Forms.Label();
            this.carrera_cmbx = new System.Windows.Forms.ComboBox();
            this.nombres_txtbx = new System.Windows.Forms.TextBox();
            this.carrera_lbl = new System.Windows.Forms.Label();
            this.sign_in_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_in_pnl
            // 
            this.sign_in_pnl.BackColor = System.Drawing.Color.SteelBlue;
            this.sign_in_pnl.Controls.Add(this.codigo_bx);
            this.sign_in_pnl.Controls.Add(this.show2_cbx);
            this.sign_in_pnl.Controls.Add(this.show1_cbx);
            this.sign_in_pnl.Controls.Add(this.semestre_cmbx);
            this.sign_in_pnl.Controls.Add(this.confirm_password_lbl);
            this.sign_in_pnl.Controls.Add(this.confirm_password_txtbx);
            this.sign_in_pnl.Controls.Add(this.password_lbl);
            this.sign_in_pnl.Controls.Add(this.password_txtbx);
            this.sign_in_pnl.Controls.Add(this.sign_in_image_pnl);
            this.sign_in_pnl.Controls.Add(this.nombres_lbl);
            this.sign_in_pnl.Controls.Add(this.sign_in_button);
            this.sign_in_pnl.Controls.Add(this.codigo_lbl);
            this.sign_in_pnl.Controls.Add(this.apellidos_txtbx);
            this.sign_in_pnl.Controls.Add(this.apellidos_lbl);
            this.sign_in_pnl.Controls.Add(this.semestre_lbl);
            this.sign_in_pnl.Controls.Add(this.carrera_cmbx);
            this.sign_in_pnl.Controls.Add(this.nombres_txtbx);
            this.sign_in_pnl.Controls.Add(this.carrera_lbl);
            this.sign_in_pnl.Location = new System.Drawing.Point(12, 12);
            this.sign_in_pnl.Name = "sign_in_pnl";
            this.sign_in_pnl.Size = new System.Drawing.Size(767, 411);
            this.sign_in_pnl.TabIndex = 14;
            // 
            // codigo_bx
            // 
            this.codigo_bx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_bx.Location = new System.Drawing.Point(245, 194);
            this.codigo_bx.MaxLength = 9;
            this.codigo_bx.Name = "codigo_bx";
            this.codigo_bx.Size = new System.Drawing.Size(433, 22);
            this.codigo_bx.TabIndex = 23;
            this.codigo_bx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_bx_KeyPress);
            // 
            // show2_cbx
            // 
            this.show2_cbx.AutoSize = true;
            this.show2_cbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.show2_cbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show2_cbx.Location = new System.Drawing.Point(684, 297);
            this.show2_cbx.Name = "show2_cbx";
            this.show2_cbx.Size = new System.Drawing.Size(72, 21);
            this.show2_cbx.TabIndex = 20;
            this.show2_cbx.Text = "Mostrar";
            this.show2_cbx.UseVisualStyleBackColor = true;
            this.show2_cbx.CheckedChanged += new System.EventHandler(this.show2_cbx_CheckedChanged);
            // 
            // show1_cbx
            // 
            this.show1_cbx.AutoSize = true;
            this.show1_cbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.show1_cbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show1_cbx.Location = new System.Drawing.Point(684, 271);
            this.show1_cbx.Name = "show1_cbx";
            this.show1_cbx.Size = new System.Drawing.Size(72, 21);
            this.show1_cbx.TabIndex = 19;
            this.show1_cbx.Text = "Mostrar";
            this.show1_cbx.UseVisualStyleBackColor = true;
            this.show1_cbx.CheckedChanged += new System.EventHandler(this.show1_cbx_CheckedChanged);
            // 
            // semestre_cmbx
            // 
            this.semestre_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestre_cmbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre_cmbx.FormattingEnabled = true;
            this.semestre_cmbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.semestre_cmbx.Location = new System.Drawing.Point(245, 245);
            this.semestre_cmbx.Name = "semestre_cmbx";
            this.semestre_cmbx.Size = new System.Drawing.Size(433, 21);
            this.semestre_cmbx.TabIndex = 18;
            // 
            // confirm_password_lbl
            // 
            this.confirm_password_lbl.AutoSize = true;
            this.confirm_password_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirm_password_lbl.Location = new System.Drawing.Point(114, 294);
            this.confirm_password_lbl.Name = "confirm_password_lbl";
            this.confirm_password_lbl.Size = new System.Drawing.Size(199, 25);
            this.confirm_password_lbl.TabIndex = 17;
            this.confirm_password_lbl.Text = "Confirmar contraseña:";
            // 
            // confirm_password_txtbx
            // 
            this.confirm_password_txtbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_txtbx.Location = new System.Drawing.Point(319, 296);
            this.confirm_password_txtbx.MaxLength = 30;
            this.confirm_password_txtbx.Name = "confirm_password_txtbx";
            this.confirm_password_txtbx.Size = new System.Drawing.Size(359, 22);
            this.confirm_password_txtbx.TabIndex = 16;
            this.confirm_password_txtbx.UseSystemPasswordChar = true;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_lbl.Location = new System.Drawing.Point(114, 268);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(190, 25);
            this.password_lbl.TabIndex = 15;
            this.password_lbl.Text = "Crea una contraseña:";
            // 
            // password_txtbx
            // 
            this.password_txtbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txtbx.Location = new System.Drawing.Point(319, 270);
            this.password_txtbx.MaxLength = 30;
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(359, 22);
            this.password_txtbx.TabIndex = 14;
            this.password_txtbx.UseSystemPasswordChar = true;
            // 
            // sign_in_image_pnl
            // 
            this.sign_in_image_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sign_in_image_pnl.BackgroundImage")));
            this.sign_in_image_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sign_in_image_pnl.Location = new System.Drawing.Point(319, 11);
            this.sign_in_image_pnl.Name = "sign_in_image_pnl";
            this.sign_in_image_pnl.Size = new System.Drawing.Size(130, 122);
            this.sign_in_image_pnl.TabIndex = 13;
            // 
            // nombres_lbl
            // 
            this.nombres_lbl.AutoSize = true;
            this.nombres_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombres_lbl.Location = new System.Drawing.Point(114, 166);
            this.nombres_lbl.Name = "nombres_lbl";
            this.nombres_lbl.Size = new System.Drawing.Size(105, 25);
            this.nombres_lbl.TabIndex = 6;
            this.nombres_lbl.Text = "Nombre(s):";
            // 
            // sign_in_button
            // 
            this.sign_in_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.sign_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_button.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.sign_in_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sign_in_button.Location = new System.Drawing.Point(610, 352);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(146, 43);
            this.sign_in_button.TabIndex = 0;
            this.sign_in_button.Text = "Registrarme";
            this.sign_in_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sign_in_button.UseVisualStyleBackColor = false;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
            // 
            // codigo_lbl
            // 
            this.codigo_lbl.AutoSize = true;
            this.codigo_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.codigo_lbl.Location = new System.Drawing.Point(114, 191);
            this.codigo_lbl.Name = "codigo_lbl";
            this.codigo_lbl.Size = new System.Drawing.Size(77, 25);
            this.codigo_lbl.TabIndex = 12;
            this.codigo_lbl.Text = "Código:";
            // 
            // apellidos_txtbx
            // 
            this.apellidos_txtbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidos_txtbx.Location = new System.Drawing.Point(245, 142);
            this.apellidos_txtbx.MaxLength = 50;
            this.apellidos_txtbx.Name = "apellidos_txtbx";
            this.apellidos_txtbx.Size = new System.Drawing.Size(433, 22);
            this.apellidos_txtbx.TabIndex = 2;
            this.apellidos_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidos_txtbx_KeyPress);
            // 
            // apellidos_lbl
            // 
            this.apellidos_lbl.AutoSize = true;
            this.apellidos_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidos_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.apellidos_lbl.Location = new System.Drawing.Point(114, 140);
            this.apellidos_lbl.Name = "apellidos_lbl";
            this.apellidos_lbl.Size = new System.Drawing.Size(94, 25);
            this.apellidos_lbl.TabIndex = 3;
            this.apellidos_lbl.Text = "Apellidos:";
            // 
            // semestre_lbl
            // 
            this.semestre_lbl.AutoSize = true;
            this.semestre_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.semestre_lbl.Location = new System.Drawing.Point(114, 242);
            this.semestre_lbl.Name = "semestre_lbl";
            this.semestre_lbl.Size = new System.Drawing.Size(93, 25);
            this.semestre_lbl.TabIndex = 10;
            this.semestre_lbl.Text = "Semestre:";
            // 
            // carrera_cmbx
            // 
            this.carrera_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carrera_cmbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrera_cmbx.FormattingEnabled = true;
            this.carrera_cmbx.Items.AddRange(new object[] {
            "Licenciatura en Administración de Negocios",
            "Licenciatura en Ciencias Forenses",
            "Licenciatura en Contaduría Pública",
            "Licenciatura en Derecho / Abogado",
            "Licenciatura en Diseño de Artesanía",
            "Licenciatura en Estudios Liberales",
            "Licenciatura en Gerontología",
            "Licenciatura en Historia del Arte",
            "Licenciatura en Ingeniería en Ciencias Computacionales",
            "Licenciatura en Ingeniería en Energía",
            "Licenciatura en Ingeniería en Nanotecnología",
            "Licenciatura en Médico, Cirujano y Partero",
            "Licenciatura en Nutrición",
            "Licenciatura en Salud Pública"});
            this.carrera_cmbx.Location = new System.Drawing.Point(245, 219);
            this.carrera_cmbx.Name = "carrera_cmbx";
            this.carrera_cmbx.Size = new System.Drawing.Size(433, 21);
            this.carrera_cmbx.TabIndex = 4;
            // 
            // nombres_txtbx
            // 
            this.nombres_txtbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres_txtbx.Location = new System.Drawing.Point(245, 168);
            this.nombres_txtbx.MaxLength = 50;
            this.nombres_txtbx.Name = "nombres_txtbx";
            this.nombres_txtbx.Size = new System.Drawing.Size(433, 22);
            this.nombres_txtbx.TabIndex = 5;
            this.nombres_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombres_txtbx_KeyPress);
            // 
            // carrera_lbl
            // 
            this.carrera_lbl.AutoSize = true;
            this.carrera_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrera_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carrera_lbl.Location = new System.Drawing.Point(114, 216);
            this.carrera_lbl.Name = "carrera_lbl";
            this.carrera_lbl.Size = new System.Drawing.Size(79, 25);
            this.carrera_lbl.TabIndex = 8;
            this.carrera_lbl.Text = "Carrera:";
            // 
            // sign_in_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(791, 435);
            this.Controls.Add(this.sign_in_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sign_in_frm";
            this.Text = "Registro";
            this.sign_in_pnl.ResumeLayout(false);
            this.sign_in_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sign_in_pnl;
        private System.Windows.Forms.CheckBox show2_cbx;
        private System.Windows.Forms.CheckBox show1_cbx;
        private System.Windows.Forms.ComboBox semestre_cmbx;
        private System.Windows.Forms.Label confirm_password_lbl;
        private System.Windows.Forms.TextBox confirm_password_txtbx;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Panel sign_in_image_pnl;
        private System.Windows.Forms.Label nombres_lbl;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.Label codigo_lbl;
        private System.Windows.Forms.TextBox apellidos_txtbx;
        private System.Windows.Forms.Label apellidos_lbl;
        private System.Windows.Forms.Label semestre_lbl;
        private System.Windows.Forms.ComboBox carrera_cmbx;
        private System.Windows.Forms.TextBox nombres_txtbx;
        private System.Windows.Forms.Label carrera_lbl;
        private System.Windows.Forms.TextBox codigo_bx;
    }
}