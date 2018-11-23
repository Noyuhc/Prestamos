namespace PE_1._0
{
    partial class home_frm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_frm));
            this.home_image_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.home_image_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_image_pnl
            // 
            this.home_image_pnl.BackColor = System.Drawing.Color.AliceBlue;
            this.home_image_pnl.Controls.Add(this.panel2);
            this.home_image_pnl.Controls.Add(this.login_btn);
            this.home_image_pnl.Controls.Add(this.sign_in_btn);
            this.home_image_pnl.Controls.Add(this.label1);
            this.home_image_pnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.home_image_pnl.Location = new System.Drawing.Point(12, 12);
            this.home_image_pnl.Name = "home_image_pnl";
            this.home_image_pnl.Size = new System.Drawing.Size(767, 411);
            this.home_image_pnl.TabIndex = 2;
            this.home_image_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.home_image_pnl_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(345, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 90);
            this.panel2.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(316, 208);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(155, 49);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Iniciar sesión";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.sign_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_btn.ForeColor = System.Drawing.Color.White;
            this.sign_in_btn.Location = new System.Drawing.Point(316, 263);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(155, 50);
            this.sign_in_btn.TabIndex = 2;
            this.sign_in_btn.Text = "Registrarme";
            this.sign_in_btn.UseVisualStyleBackColor = false;
            this.sign_in_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(176, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRESTAMO DE EQUIPOS";
            // 
            // home_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(791, 435);
            this.ControlBox = false;
            this.Controls.Add(this.home_image_pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(807, 474);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(807, 474);
            this.Name = "home_frm";
            this.Text = "Préstamo de Equipos";
            this.home_image_pnl.ResumeLayout(false);
            this.home_image_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel home_image_pnl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

