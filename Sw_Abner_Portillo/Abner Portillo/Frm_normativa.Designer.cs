namespace Abner_Portillo
{
    partial class Frm_normativa
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
            this.navegador1 = new CapaDisenoNavegador.Navegador();
            this.dgv_Normativa = new System.Windows.Forms.DataGridView();
            this.Lbl_IdNormativa = new System.Windows.Forms.Label();
            this.Txt_IdNormativa = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.ventana1 = new ventanaDiseno.ventana();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Normativa)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(88, 103);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 1;
            // 
            // dgv_Normativa
            // 
            this.dgv_Normativa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Normativa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Normativa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Normativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Normativa.EnableHeadersVisualStyles = false;
            this.dgv_Normativa.Location = new System.Drawing.Point(298, 449);
            this.dgv_Normativa.Name = "dgv_Normativa";
            this.dgv_Normativa.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Normativa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Normativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Normativa.Size = new System.Drawing.Size(497, 150);
            this.dgv_Normativa.TabIndex = 2;
            this.dgv_Normativa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Normativa_CellDoubleClick);
            // 
            // Lbl_IdNormativa
            // 
            this.Lbl_IdNormativa.AutoSize = true;
            this.Lbl_IdNormativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_IdNormativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdNormativa.Location = new System.Drawing.Point(385, 361);
            this.Lbl_IdNormativa.Name = "Lbl_IdNormativa";
            this.Lbl_IdNormativa.Size = new System.Drawing.Size(119, 21);
            this.Lbl_IdNormativa.TabIndex = 3;
            this.Lbl_IdNormativa.Text = "ID Normativa:";
            this.Lbl_IdNormativa.Visible = false;
            // 
            // Txt_IdNormativa
            // 
            this.Txt_IdNormativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdNormativa.Location = new System.Drawing.Point(531, 358);
            this.Txt_IdNormativa.Name = "Txt_IdNormativa";
            this.Txt_IdNormativa.Size = new System.Drawing.Size(97, 27);
            this.Txt_IdNormativa.TabIndex = 4;
            this.Txt_IdNormativa.Tag = "1";
            this.Txt_IdNormativa.Visible = false;
            this.Txt_IdNormativa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(424, 280);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(297, 27);
            this.Txt_Nombre.TabIndex = 6;
            this.Txt_Nombre.Tag = "2";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(329, 283);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(77, 21);
            this.Lbl_Nombre.TabIndex = 5;
            this.Lbl_Nombre.Text = "Nombre:";
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
            // Frm_normativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_IdNormativa);
            this.Controls.Add(this.Lbl_IdNormativa);
            this.Controls.Add(this.dgv_Normativa);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_normativa";
            this.Text = "Frm_normativa";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Normativa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private CapaDisenoNavegador.Navegador navegador1;
        private System.Windows.Forms.DataGridView dgv_Normativa;
        private System.Windows.Forms.Label Lbl_IdNormativa;
        private System.Windows.Forms.TextBox Txt_IdNormativa;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Nombre;
    }
}