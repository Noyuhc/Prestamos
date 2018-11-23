namespace PE_1._0
{
    partial class login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_frm));
            this.sign_in_pnl = new System.Windows.Forms.Panel();
            this.show_password_cbx = new System.Windows.Forms.CheckBox();
            this.pswrd_lbl = new System.Windows.Forms.Label();
            this.pswrd_txtbx = new System.Windows.Forms.TextBox();
            this.login_image_pnl = new System.Windows.Forms.Panel();
            this.start_btn = new System.Windows.Forms.Button();
            this.user_txtbx = new System.Windows.Forms.TextBox();
            this.user_lbl = new System.Windows.Forms.Label();
            this.sign_in_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_in_pnl
            // 
            this.sign_in_pnl.BackColor = System.Drawing.Color.SteelBlue;
            this.sign_in_pnl.Controls.Add(this.show_password_cbx);
            this.sign_in_pnl.Controls.Add(this.pswrd_lbl);
            this.sign_in_pnl.Controls.Add(this.pswrd_txtbx);
            this.sign_in_pnl.Controls.Add(this.login_image_pnl);
            this.sign_in_pnl.Controls.Add(this.start_btn);
            this.sign_in_pnl.Controls.Add(this.user_txtbx);
            this.sign_in_pnl.Controls.Add(this.user_lbl);
            this.sign_in_pnl.Location = new System.Drawing.Point(12, 12);
            this.sign_in_pnl.Name = "sign_in_pnl";
            this.sign_in_pnl.Size = new System.Drawing.Size(767, 411);
            this.sign_in_pnl.TabIndex = 15;
            // 
            // show_password_cbx
            // 
            this.show_password_cbx.AutoSize = true;
            this.show_password_cbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_password_cbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_password_cbx.Location = new System.Drawing.Point(516, 219);
            this.show_password_cbx.Name = "show_password_cbx";
            this.show_password_cbx.Size = new System.Drawing.Size(72, 21);
            this.show_password_cbx.TabIndex = 20;
            this.show_password_cbx.Text = "Mostrar";
            this.show_password_cbx.UseVisualStyleBackColor = true;
            this.show_password_cbx.CheckedChanged += new System.EventHandler(this.check_password_ckbx_CheckedChanged);
            // 
            // pswrd_lbl
            // 
            this.pswrd_lbl.AutoSize = true;
            this.pswrd_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswrd_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pswrd_lbl.Location = new System.Drawing.Point(331, 192);
            this.pswrd_lbl.Name = "pswrd_lbl";
            this.pswrd_lbl.Size = new System.Drawing.Size(114, 25);
            this.pswrd_lbl.TabIndex = 17;
            this.pswrd_lbl.Text = "Contraseña:";
            // 
            // pswrd_txtbx
            // 
            this.pswrd_txtbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswrd_txtbx.Location = new System.Drawing.Point(267, 217);
            this.pswrd_txtbx.MaxLength = 30;
            this.pswrd_txtbx.Name = "pswrd_txtbx";
            this.pswrd_txtbx.Size = new System.Drawing.Size(243, 22);
            this.pswrd_txtbx.TabIndex = 16;
            this.pswrd_txtbx.UseSystemPasswordChar = true;
            // 
            // login_image_pnl
            // 
            this.login_image_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_image_pnl.BackgroundImage")));
            this.login_image_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_image_pnl.Location = new System.Drawing.Point(325, 20);
            this.login_image_pnl.Name = "login_image_pnl";
            this.login_image_pnl.Size = new System.Drawing.Size(130, 122);
            this.login_image_pnl.TabIndex = 13;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.start_btn.Location = new System.Drawing.Point(324, 254);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(146, 43);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Iniciar sesión";
            this.start_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // user_txtbx
            // 
            this.user_txtbx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txtbx.Location = new System.Drawing.Point(267, 170);
            this.user_txtbx.MaxLength = 9;
            this.user_txtbx.Name = "user_txtbx";
            this.user_txtbx.Size = new System.Drawing.Size(243, 22);
            this.user_txtbx.TabIndex = 2;
            this.user_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_txtbx_KeyPress);
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_lbl.Location = new System.Drawing.Point(346, 145);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(78, 25);
            this.user_lbl.TabIndex = 3;
            this.user_lbl.Text = "Código:";
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(791, 435);
            this.Controls.Add(this.sign_in_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(807, 474);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(807, 474);
            this.Name = "login_frm";
            this.Text = "Form3";
            this.sign_in_pnl.ResumeLayout(false);
            this.sign_in_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sign_in_pnl;
        private System.Windows.Forms.CheckBox show_password_cbx;
        private System.Windows.Forms.Label pswrd_lbl;
        private System.Windows.Forms.TextBox pswrd_txtbx;
        private System.Windows.Forms.Panel login_image_pnl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox user_txtbx;
        private System.Windows.Forms.Label user_lbl;
    }
}