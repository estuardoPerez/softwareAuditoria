namespace InicioSesion
{
    partial class pnl_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnl_Menu));
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_loginAyuda = new System.Windows.Forms.Button();
            this.Lbl_loginPass = new System.Windows.Forms.Label();
            this.Lbl_loginUser = new System.Windows.Forms.Label();
            this.Txt_loginPass = new System.Windows.Forms.TextBox();
            this.Txt_loginUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.Image")));
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptar.Location = new System.Drawing.Point(454, 322);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(120, 40);
            this.Btn_Aceptar.TabIndex = 55;
            this.Btn_Aceptar.Text = "INGRESAR";
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_loginAyuda
            // 
            this.Btn_loginAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(133)))));
            this.Btn_loginAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_loginAyuda.FlatAppearance.BorderSize = 0;
            this.Btn_loginAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_loginAyuda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_loginAyuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_loginAyuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_loginAyuda.Image")));
            this.Btn_loginAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_loginAyuda.Location = new System.Drawing.Point(587, 445);
            this.Btn_loginAyuda.Name = "Btn_loginAyuda";
            this.Btn_loginAyuda.Size = new System.Drawing.Size(101, 43);
            this.Btn_loginAyuda.TabIndex = 54;
            this.Btn_loginAyuda.Text = "AYUDA";
            this.Btn_loginAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_loginAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_loginAyuda.UseVisualStyleBackColor = false;
            this.Btn_loginAyuda.Click += new System.EventHandler(this.Btn_loginAyuda_Click);
            // 
            // Lbl_loginPass
            // 
            this.Lbl_loginPass.AutoSize = true;
            this.Lbl_loginPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_loginPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginPass.Location = new System.Drawing.Point(115, 240);
            this.Lbl_loginPass.Name = "Lbl_loginPass";
            this.Lbl_loginPass.Size = new System.Drawing.Size(111, 21);
            this.Lbl_loginPass.TabIndex = 53;
            this.Lbl_loginPass.Text = "CONTRASEÑA";
            this.Lbl_loginPass.Click += new System.EventHandler(this.Lbl_loginPass_Click);
            // 
            // Lbl_loginUser
            // 
            this.Lbl_loginUser.AutoSize = true;
            this.Lbl_loginUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_loginUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginUser.Location = new System.Drawing.Point(115, 172);
            this.Lbl_loginUser.Name = "Lbl_loginUser";
            this.Lbl_loginUser.Size = new System.Drawing.Size(77, 21);
            this.Lbl_loginUser.TabIndex = 52;
            this.Lbl_loginUser.Text = "USUARIO";
            this.Lbl_loginUser.Click += new System.EventHandler(this.Lbl_loginUser_Click);
            // 
            // Txt_loginPass
            // 
            this.Txt_loginPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_loginPass.Location = new System.Drawing.Point(117, 264);
            this.Txt_loginPass.MaxLength = 30;
            this.Txt_loginPass.Name = "Txt_loginPass";
            this.Txt_loginPass.Size = new System.Drawing.Size(457, 25);
            this.Txt_loginPass.TabIndex = 51;
            this.Txt_loginPass.UseSystemPasswordChar = true;
            this.Txt_loginPass.TextChanged += new System.EventHandler(this.Txt_loginPass_TextChanged);
            // 
            // Txt_loginUser
            // 
            this.Txt_loginUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_loginUser.Location = new System.Drawing.Point(118, 196);
            this.Txt_loginUser.MaxLength = 30;
            this.Txt_loginUser.Name = "Txt_loginUser";
            this.Txt_loginUser.Size = new System.Drawing.Size(454, 25);
            this.Txt_loginUser.TabIndex = 50;
            this.Txt_loginUser.TextChanged += new System.EventHandler(this.Txt_loginUser_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(328, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 56;
            this.button1.Text = "CANCELAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "LOGIN DE USUARIOS";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(452, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 58;
            this.button2.Text = "NUEVO USUARIO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pnl_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(105)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_loginAyuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_loginPass);
            this.Controls.Add(this.Lbl_loginUser);
            this.Controls.Add(this.Txt_loginPass);
            this.Controls.Add(this.Txt_loginUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pnl_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.InicioSesionForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_loginAyuda;
        private System.Windows.Forms.Label Lbl_loginPass;
        private System.Windows.Forms.Label Lbl_loginUser;
        private System.Windows.Forms.TextBox Txt_loginPass;
        private System.Windows.Forms.TextBox Txt_loginUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}