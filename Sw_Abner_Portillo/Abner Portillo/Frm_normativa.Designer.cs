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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.navegador1.Location = new System.Drawing.Point(121, 117);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(1213, 80);
            this.navegador1.TabIndex = 1;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // dgv_Normativa
            // 
            this.dgv_Normativa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Normativa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Normativa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Normativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Normativa.EnableHeadersVisualStyles = false;
            this.dgv_Normativa.Location = new System.Drawing.Point(397, 553);
            this.dgv_Normativa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Normativa.Name = "dgv_Normativa";
            this.dgv_Normativa.RowHeadersVisible = false;
            this.dgv_Normativa.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Normativa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Normativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Normativa.Size = new System.Drawing.Size(663, 185);
            this.dgv_Normativa.TabIndex = 2;
            this.dgv_Normativa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Normativa_CellDoubleClick);
            // 
            // Lbl_IdNormativa
            // 
            this.Lbl_IdNormativa.AutoSize = true;
            this.Lbl_IdNormativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_IdNormativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdNormativa.Location = new System.Drawing.Point(534, 335);
            this.Lbl_IdNormativa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IdNormativa.Name = "Lbl_IdNormativa";
            this.Lbl_IdNormativa.Size = new System.Drawing.Size(145, 23);
            this.Lbl_IdNormativa.TabIndex = 3;
            this.Lbl_IdNormativa.Text = "ID Normativa:";
            this.Lbl_IdNormativa.Visible = false;
            // 
            // Txt_IdNormativa
            // 
            this.Txt_IdNormativa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdNormativa.Location = new System.Drawing.Point(739, 335);
            this.Txt_IdNormativa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_IdNormativa.Name = "Txt_IdNormativa";
            this.Txt_IdNormativa.Size = new System.Drawing.Size(128, 32);
            this.Txt_IdNormativa.TabIndex = 4;
            this.Txt_IdNormativa.Tag = "1";
            this.Txt_IdNormativa.Visible = false;
            this.Txt_IdNormativa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(589, 425);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(395, 32);
            this.Txt_Nombre.TabIndex = 6;
            this.Txt_Nombre.Tag = "2";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(463, 428);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(95, 23);
            this.Lbl_Nombre.TabIndex = 5;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1520, 791);
            this.ventana1.TabIndex = 0;
            this.ventana1.Load += new System.EventHandler(this.ventana1_Load);
            // 
            // Frm_normativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 791);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_IdNormativa);
            this.Controls.Add(this.Lbl_IdNormativa);
            this.Controls.Add(this.dgv_Normativa);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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