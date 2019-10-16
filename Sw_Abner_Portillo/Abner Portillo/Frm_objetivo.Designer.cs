namespace Abner_Portillo
{
    partial class Frm_objetivo
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
            this.ventana1 = new ventanaDiseno.ventana();
            this.navegador1 = new CapaDisenoNavegador.Navegador();
            this.Lbl_IdNormativa = new System.Windows.Forms.Label();
            this.Txt_IdDomino = new System.Windows.Forms.TextBox();
            this.Lbl_Domino = new System.Windows.Forms.Label();
            this.cbo_dominio = new System.Windows.Forms.ComboBox();
            this.Txt_DescripcionObjetivo = new System.Windows.Forms.TextBox();
            this.Lbl_DescripcionObjetivo = new System.Windows.Forms.Label();
            this.Txt_nombreObjetivo = new System.Windows.Forms.TextBox();
            this.Lbl_NombreObjetivo = new System.Windows.Forms.Label();
            this.Txt_Objetivo = new System.Windows.Forms.TextBox();
            this.Lbl_IdObjetivo = new System.Windows.Forms.Label();
            this.dgv_Objetivo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Objetivo)).BeginInit();
            this.SuspendLayout();
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 0;
            this.ventana1.Load += new System.EventHandler(this.ventana1_Load);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(121, 117);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1213, 80);
            this.navegador1.TabIndex = 2;
            // 
            // Lbl_IdNormativa
            // 
            this.Lbl_IdNormativa.AutoSize = true;
            this.Lbl_IdNormativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_IdNormativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdNormativa.Location = new System.Drawing.Point(1056, 506);
            this.Lbl_IdNormativa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IdNormativa.Name = "Lbl_IdNormativa";
            this.Lbl_IdNormativa.Size = new System.Drawing.Size(119, 23);
            this.Lbl_IdNormativa.TabIndex = 26;
            this.Lbl_IdNormativa.Text = "Normativa:";
            // 
            // Txt_IdDomino
            // 
            this.Txt_IdDomino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdDomino.Location = new System.Drawing.Point(1195, 502);
            this.Txt_IdDomino.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IdDomino.Name = "Txt_IdDomino";
            this.Txt_IdDomino.Size = new System.Drawing.Size(85, 32);
            this.Txt_IdDomino.TabIndex = 25;
            this.Txt_IdDomino.Tag = "4";
            // 
            // Lbl_Domino
            // 
            this.Lbl_Domino.AutoSize = true;
            this.Lbl_Domino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_Domino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Domino.Location = new System.Drawing.Point(468, 506);
            this.Lbl_Domino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Domino.Name = "Lbl_Domino";
            this.Lbl_Domino.Size = new System.Drawing.Size(93, 23);
            this.Lbl_Domino.TabIndex = 24;
            this.Lbl_Domino.Text = "Dominio:";
            // 
            // cbo_dominio
            // 
            this.cbo_dominio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbo_dominio.FormattingEnabled = true;
            this.cbo_dominio.Location = new System.Drawing.Point(630, 502);
            this.cbo_dominio.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_dominio.Name = "cbo_dominio";
            this.cbo_dominio.Size = new System.Drawing.Size(395, 31);
            this.cbo_dominio.TabIndex = 23;
            this.cbo_dominio.Tag = "";
            this.cbo_dominio.SelectedIndexChanged += new System.EventHandler(this.cbo_dominio_SelectedIndexChanged);
            // 
            // Txt_DescripcionObjetivo
            // 
            this.Txt_DescripcionObjetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DescripcionObjetivo.Location = new System.Drawing.Point(630, 377);
            this.Txt_DescripcionObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DescripcionObjetivo.Multiline = true;
            this.Txt_DescripcionObjetivo.Name = "Txt_DescripcionObjetivo";
            this.Txt_DescripcionObjetivo.Size = new System.Drawing.Size(395, 117);
            this.Txt_DescripcionObjetivo.TabIndex = 22;
            this.Txt_DescripcionObjetivo.Tag = "3";
            // 
            // Lbl_DescripcionObjetivo
            // 
            this.Lbl_DescripcionObjetivo.AutoSize = true;
            this.Lbl_DescripcionObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_DescripcionObjetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DescripcionObjetivo.Location = new System.Drawing.Point(460, 381);
            this.Lbl_DescripcionObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DescripcionObjetivo.Name = "Lbl_DescripcionObjetivo";
            this.Lbl_DescripcionObjetivo.Size = new System.Drawing.Size(128, 23);
            this.Lbl_DescripcionObjetivo.TabIndex = 21;
            this.Lbl_DescripcionObjetivo.Text = "Descripcion:";
            // 
            // Txt_nombreObjetivo
            // 
            this.Txt_nombreObjetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreObjetivo.Location = new System.Drawing.Point(630, 323);
            this.Txt_nombreObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombreObjetivo.Name = "Txt_nombreObjetivo";
            this.Txt_nombreObjetivo.Size = new System.Drawing.Size(395, 32);
            this.Txt_nombreObjetivo.TabIndex = 20;
            this.Txt_nombreObjetivo.Tag = "2";
            // 
            // Lbl_NombreObjetivo
            // 
            this.Lbl_NombreObjetivo.AutoSize = true;
            this.Lbl_NombreObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NombreObjetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreObjetivo.Location = new System.Drawing.Point(496, 326);
            this.Lbl_NombreObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreObjetivo.Name = "Lbl_NombreObjetivo";
            this.Lbl_NombreObjetivo.Size = new System.Drawing.Size(95, 23);
            this.Lbl_NombreObjetivo.TabIndex = 19;
            this.Lbl_NombreObjetivo.Text = "Nombre:";
            // 
            // Txt_Objetivo
            // 
            this.Txt_Objetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Objetivo.Location = new System.Drawing.Point(630, 271);
            this.Txt_Objetivo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Objetivo.Name = "Txt_Objetivo";
            this.Txt_Objetivo.Size = new System.Drawing.Size(395, 32);
            this.Txt_Objetivo.TabIndex = 18;
            this.Txt_Objetivo.Tag = "1";
            // 
            // Lbl_IdObjetivo
            // 
            this.Lbl_IdObjetivo.AutoSize = true;
            this.Lbl_IdObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_IdObjetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdObjetivo.Location = new System.Drawing.Point(504, 271);
            this.Lbl_IdObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IdObjetivo.Name = "Lbl_IdObjetivo";
            this.Lbl_IdObjetivo.Size = new System.Drawing.Size(87, 23);
            this.Lbl_IdObjetivo.TabIndex = 17;
            this.Lbl_IdObjetivo.Text = "Codigo:";
            // 
            // dgv_Objetivo
            // 
            this.dgv_Objetivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Objetivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Objetivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Objetivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Objetivo.EnableHeadersVisualStyles = false;
            this.dgv_Objetivo.Location = new System.Drawing.Point(433, 567);
            this.dgv_Objetivo.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Objetivo.Name = "dgv_Objetivo";
            this.dgv_Objetivo.RowHeadersVisible = false;
            this.dgv_Objetivo.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Objetivo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Objetivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Objetivo.Size = new System.Drawing.Size(663, 185);
            this.dgv_Objetivo.TabIndex = 27;
            this.dgv_Objetivo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Objetivo_CellDoubleClick);
            // 
            // Frm_objetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.dgv_Objetivo);
            this.Controls.Add(this.Lbl_IdNormativa);
            this.Controls.Add(this.Txt_IdDomino);
            this.Controls.Add(this.Lbl_Domino);
            this.Controls.Add(this.cbo_dominio);
            this.Controls.Add(this.Txt_DescripcionObjetivo);
            this.Controls.Add(this.Lbl_DescripcionObjetivo);
            this.Controls.Add(this.Txt_nombreObjetivo);
            this.Controls.Add(this.Lbl_NombreObjetivo);
            this.Controls.Add(this.Txt_Objetivo);
            this.Controls.Add(this.Lbl_IdObjetivo);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_objetivo";
            this.Text = "Frm_objetivo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Objetivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private CapaDisenoNavegador.Navegador navegador1;
        private System.Windows.Forms.Label Lbl_IdNormativa;
        private System.Windows.Forms.TextBox Txt_IdDomino;
        private System.Windows.Forms.Label Lbl_Domino;
        private System.Windows.Forms.ComboBox cbo_dominio;
        private System.Windows.Forms.TextBox Txt_DescripcionObjetivo;
        private System.Windows.Forms.Label Lbl_DescripcionObjetivo;
        private System.Windows.Forms.TextBox Txt_nombreObjetivo;
        private System.Windows.Forms.Label Lbl_NombreObjetivo;
        private System.Windows.Forms.TextBox Txt_Objetivo;
        private System.Windows.Forms.Label Lbl_IdObjetivo;
        private System.Windows.Forms.DataGridView dgv_Objetivo;
    }
}