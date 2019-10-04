namespace modulaKarla
{
    partial class ventanaPrincipal
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
            this.ventana1 = new ventanaDiseno.ventana();
            this.navegador1 = new CapaDisenoNavegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgModulo = new System.Windows.Forms.DataGridView();
            this.cboEncargado = new System.Windows.Forms.ComboBox();
            this.cboAuditor = new System.Windows.Forms.ComboBox();
            this.cboObjetivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtAuditor = new System.Windows.Forms.TextBox();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgModulo)).BeginInit();
            this.SuspendLayout();
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 0;
            this.ventana1.Load += new System.EventHandler(this.Ventana1_Load);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(118, 69);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(254, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encargado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(254, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Auditor";
            // 
            // dgModulo
            // 
            this.dgModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModulo.Location = new System.Drawing.Point(501, 370);
            this.dgModulo.Name = "dgModulo";
            this.dgModulo.Size = new System.Drawing.Size(240, 150);
            this.dgModulo.TabIndex = 7;
            // 
            // cboEncargado
            // 
            this.cboEncargado.FormattingEnabled = true;
            this.cboEncargado.Location = new System.Drawing.Point(379, 206);
            this.cboEncargado.Name = "cboEncargado";
            this.cboEncargado.Size = new System.Drawing.Size(121, 21);
            this.cboEncargado.TabIndex = 8;
            // 
            // cboAuditor
            // 
            this.cboAuditor.FormattingEnabled = true;
            this.cboAuditor.Location = new System.Drawing.Point(379, 287);
            this.cboAuditor.Name = "cboAuditor";
            this.cboAuditor.Size = new System.Drawing.Size(121, 21);
            this.cboAuditor.TabIndex = 9;
            // 
            // cboObjetivo
            // 
            this.cboObjetivo.FormattingEnabled = true;
            this.cboObjetivo.Location = new System.Drawing.Point(823, 232);
            this.cboObjetivo.Name = "cboObjetivo";
            this.cboObjetivo.Size = new System.Drawing.Size(121, 21);
            this.cboObjetivo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(727, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Objetivo Cobit";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(521, 206);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 20);
            this.txtEncargado.TabIndex = 12;
            // 
            // txtAuditor
            // 
            this.txtAuditor.Location = new System.Drawing.Point(525, 285);
            this.txtAuditor.Name = "txtAuditor";
            this.txtAuditor.Size = new System.Drawing.Size(100, 20);
            this.txtAuditor.TabIndex = 13;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(968, 234);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(100, 20);
            this.txtObjetivo.TabIndex = 14;
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.txtAuditor);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboObjetivo);
            this.Controls.Add(this.cboAuditor);
            this.Controls.Add(this.cboEncargado);
            this.Controls.Add(this.dgModulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ventanaPrincipal";
            this.Text = "ventanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgModulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private CapaDisenoNavegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgModulo;
        private System.Windows.Forms.ComboBox cboEncargado;
        private System.Windows.Forms.ComboBox cboAuditor;
        private System.Windows.Forms.ComboBox cboObjetivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.TextBox txtAuditor;
        private System.Windows.Forms.TextBox txtObjetivo;
    }
}