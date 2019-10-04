namespace Abner_Portillo
{
    partial class Frm_dominio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventana1 = new ventanaDiseno.ventana();
            this.navegador1 = new CapaDisenoNavegador.Navegador();
            this.dgv_Dominio = new System.Windows.Forms.DataGridView();
            this.Txt_Dominio = new System.Windows.Forms.TextBox();
            this.Lbl_IdDominio = new System.Windows.Forms.Label();
            this.Txt_nombreDominio = new System.Windows.Forms.TextBox();
            this.Lbl_NombreDominio = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lbl_DescripcionDominio = new System.Windows.Forms.Label();
            this.cbo_nomativa = new System.Windows.Forms.ComboBox();
            this.Lbl_Normativa = new System.Windows.Forms.Label();
            this.Lbl_IdNormativa = new System.Windows.Forms.Label();
            this.Txt_IdNormativa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dominio)).BeginInit();
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
            this.ventana1.Load += new System.EventHandler(this.ventana1_Load);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(104, 92);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 1;
            // 
            // dgv_Dominio
            // 
            this.dgv_Dominio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Dominio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Dominio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Dominio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dominio.EnableHeadersVisualStyles = false;
            this.dgv_Dominio.Location = new System.Drawing.Point(325, 461);
            this.dgv_Dominio.Name = "dgv_Dominio";
            this.dgv_Dominio.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Dominio.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Dominio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Dominio.Size = new System.Drawing.Size(497, 150);
            this.dgv_Dominio.TabIndex = 3;
            this.dgv_Dominio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Dominio_CellDoubleClick);
            // 
            // Txt_Dominio
            // 
            this.Txt_Dominio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dominio.Location = new System.Drawing.Point(473, 217);
            this.Txt_Dominio.Name = "Txt_Dominio";
            this.Txt_Dominio.Size = new System.Drawing.Size(297, 27);
            this.Txt_Dominio.TabIndex = 8;
            this.Txt_Dominio.Tag = "1";
            // 
            // Lbl_IdDominio
            // 
            this.Lbl_IdDominio.AutoSize = true;
            this.Lbl_IdDominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_IdDominio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdDominio.Location = new System.Drawing.Point(378, 220);
            this.Lbl_IdDominio.Name = "Lbl_IdDominio";
            this.Lbl_IdDominio.Size = new System.Drawing.Size(72, 21);
            this.Lbl_IdDominio.TabIndex = 7;
            this.Lbl_IdDominio.Text = "Codigo:";
            // 
            // Txt_nombreDominio
            // 
            this.Txt_nombreDominio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreDominio.Location = new System.Drawing.Point(473, 259);
            this.Txt_nombreDominio.Name = "Txt_nombreDominio";
            this.Txt_nombreDominio.Size = new System.Drawing.Size(297, 27);
            this.Txt_nombreDominio.TabIndex = 10;
            this.Txt_nombreDominio.Tag = "2";
            // 
            // Lbl_NombreDominio
            // 
            this.Lbl_NombreDominio.AutoSize = true;
            this.Lbl_NombreDominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NombreDominio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreDominio.Location = new System.Drawing.Point(373, 262);
            this.Lbl_NombreDominio.Name = "Lbl_NombreDominio";
            this.Lbl_NombreDominio.Size = new System.Drawing.Size(77, 21);
            this.Lbl_NombreDominio.TabIndex = 9;
            this.Lbl_NombreDominio.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(473, 303);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 96);
            this.textBox2.TabIndex = 12;
            this.textBox2.Tag = "3";
            // 
            // Lbl_DescripcionDominio
            // 
            this.Lbl_DescripcionDominio.AutoSize = true;
            this.Lbl_DescripcionDominio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_DescripcionDominio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DescripcionDominio.Location = new System.Drawing.Point(346, 306);
            this.Lbl_DescripcionDominio.Name = "Lbl_DescripcionDominio";
            this.Lbl_DescripcionDominio.Size = new System.Drawing.Size(104, 21);
            this.Lbl_DescripcionDominio.TabIndex = 11;
            this.Lbl_DescripcionDominio.Text = "Descripcion:";
            // 
            // cbo_nomativa
            // 
            this.cbo_nomativa.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbo_nomativa.FormattingEnabled = true;
            this.cbo_nomativa.Location = new System.Drawing.Point(473, 405);
            this.cbo_nomativa.Name = "cbo_nomativa";
            this.cbo_nomativa.Size = new System.Drawing.Size(297, 29);
            this.cbo_nomativa.TabIndex = 13;
            this.cbo_nomativa.Tag = "4";
            // 
            // Lbl_Normativa
            // 
            this.Lbl_Normativa.AutoSize = true;
            this.Lbl_Normativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_Normativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Normativa.Location = new System.Drawing.Point(352, 408);
            this.Lbl_Normativa.Name = "Lbl_Normativa";
            this.Lbl_Normativa.Size = new System.Drawing.Size(98, 21);
            this.Lbl_Normativa.TabIndex = 14;
            this.Lbl_Normativa.Text = "Normativa:";
            // 
            // Lbl_IdNormativa
            // 
            this.Lbl_IdNormativa.AutoSize = true;
            this.Lbl_IdNormativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_IdNormativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdNormativa.Location = new System.Drawing.Point(793, 408);
            this.Lbl_IdNormativa.Name = "Lbl_IdNormativa";
            this.Lbl_IdNormativa.Size = new System.Drawing.Size(98, 21);
            this.Lbl_IdNormativa.TabIndex = 16;
            this.Lbl_IdNormativa.Text = "Normativa:";
            // 
            // Txt_IdNormativa
            // 
            this.Txt_IdNormativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdNormativa.Location = new System.Drawing.Point(897, 405);
            this.Txt_IdNormativa.Name = "Txt_IdNormativa";
            this.Txt_IdNormativa.Size = new System.Drawing.Size(65, 27);
            this.Txt_IdNormativa.TabIndex = 15;
            this.Txt_IdNormativa.Tag = "2";
            // 
            // Frm_dominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Lbl_IdNormativa);
            this.Controls.Add(this.Txt_IdNormativa);
            this.Controls.Add(this.Lbl_Normativa);
            this.Controls.Add(this.cbo_nomativa);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lbl_DescripcionDominio);
            this.Controls.Add(this.Txt_nombreDominio);
            this.Controls.Add(this.Lbl_NombreDominio);
            this.Controls.Add(this.Txt_Dominio);
            this.Controls.Add(this.Lbl_IdDominio);
            this.Controls.Add(this.dgv_Dominio);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_dominio";
            this.Text = "Frm_dominio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dominio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private CapaDisenoNavegador.Navegador navegador1;
        private System.Windows.Forms.DataGridView dgv_Dominio;
        private System.Windows.Forms.TextBox Txt_Dominio;
        private System.Windows.Forms.Label Lbl_IdDominio;
        private System.Windows.Forms.TextBox Txt_nombreDominio;
        private System.Windows.Forms.Label Lbl_NombreDominio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lbl_DescripcionDominio;
        private System.Windows.Forms.ComboBox cbo_nomativa;
        private System.Windows.Forms.Label Lbl_Normativa;
        private System.Windows.Forms.Label Lbl_IdNormativa;
        private System.Windows.Forms.TextBox Txt_IdNormativa;
    }
}