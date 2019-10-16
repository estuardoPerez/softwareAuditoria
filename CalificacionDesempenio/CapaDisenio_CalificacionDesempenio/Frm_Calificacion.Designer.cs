namespace CapaDisenio_CalificacionDesempenio
{
    partial class Frm_Calificacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.Lbl_norma = new System.Windows.Forms.Label();
            this.Lbl_objetivo = new System.Windows.Forms.Label();
            this.Lbl_calificacion = new System.Windows.Forms.Label();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_norma = new System.Windows.Forms.ComboBox();
            this.Cbo_objetivo = new System.Windows.Forms.ComboBox();
            this.Txt_calificacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.navegador1 = new CapaDisenoNavegador.Navegador();
            this.Dgv_datos = new System.Windows.Forms.DataGridView();
            this.ventana1 = new ventanaDiseno.ventana();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cliente.Location = new System.Drawing.Point(115, 208);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.Size = new System.Drawing.Size(61, 21);
            this.Lbl_cliente.TabIndex = 1;
            this.Lbl_cliente.Text = "Cliente:";
            // 
            // Lbl_norma
            // 
            this.Lbl_norma.AutoSize = true;
            this.Lbl_norma.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_norma.Location = new System.Drawing.Point(713, 211);
            this.Lbl_norma.Name = "Lbl_norma";
            this.Lbl_norma.Size = new System.Drawing.Size(87, 21);
            this.Lbl_norma.TabIndex = 2;
            this.Lbl_norma.Text = "Normativa:";
            // 
            // Lbl_objetivo
            // 
            this.Lbl_objetivo.AutoSize = true;
            this.Lbl_objetivo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_objetivo.Location = new System.Drawing.Point(405, 302);
            this.Lbl_objetivo.Name = "Lbl_objetivo";
            this.Lbl_objetivo.Size = new System.Drawing.Size(72, 21);
            this.Lbl_objetivo.TabIndex = 3;
            this.Lbl_objetivo.Text = "Objetivo:";
            // 
            // Lbl_calificacion
            // 
            this.Lbl_calificacion.AutoSize = true;
            this.Lbl_calificacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calificacion.Location = new System.Drawing.Point(619, 302);
            this.Lbl_calificacion.Name = "Lbl_calificacion";
            this.Lbl_calificacion.Size = new System.Drawing.Size(92, 21);
            this.Lbl_calificacion.TabIndex = 4;
            this.Lbl_calificacion.Text = "Calificación:";
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(182, 205);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(275, 29);
            this.Cbo_cliente.TabIndex = 5;
            this.Cbo_cliente.Tag = "1";
            // 
            // Cbo_norma
            // 
            this.Cbo_norma.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_norma.FormattingEnabled = true;
            this.Cbo_norma.Location = new System.Drawing.Point(825, 208);
            this.Cbo_norma.Name = "Cbo_norma";
            this.Cbo_norma.Size = new System.Drawing.Size(121, 29);
            this.Cbo_norma.TabIndex = 6;
            this.Cbo_norma.Tag = "2";
            this.Cbo_norma.SelectedIndexChanged += new System.EventHandler(this.Cbo_norma_SelectedIndexChanged);
            this.Cbo_norma.DisplayMemberChanged += new System.EventHandler(this.Cbo_norma_DisplayMemberChanged);
            // 
            // Cbo_objetivo
            // 
            this.Cbo_objetivo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_objetivo.FormattingEnabled = true;
            this.Cbo_objetivo.Location = new System.Drawing.Point(483, 299);
            this.Cbo_objetivo.Name = "Cbo_objetivo";
            this.Cbo_objetivo.Size = new System.Drawing.Size(121, 29);
            this.Cbo_objetivo.TabIndex = 7;
            // 
            // Txt_calificacion
            // 
            this.Txt_calificacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_calificacion.Location = new System.Drawing.Point(717, 299);
            this.Txt_calificacion.Name = "Txt_calificacion";
            this.Txt_calificacion.Size = new System.Drawing.Size(48, 29);
            this.Txt_calificacion.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(835, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Resumen Calificación procesos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(119, 75);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 12;
            // 
            // Dgv_datos
            // 
            this.Dgv_datos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dgv_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_datos.EnableHeadersVisualStyles = false;
            this.Dgv_datos.GridColor = System.Drawing.Color.MediumAquamarine;
            this.Dgv_datos.Location = new System.Drawing.Point(97, 341);
            this.Dgv_datos.Name = "Dgv_datos";
            this.Dgv_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_datos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_datos.Size = new System.Drawing.Size(953, 190);
            this.Dgv_datos.TabIndex = 206;
            this.Dgv_datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_datos_CellDoubleClick);
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 207;
            // 
            // Frm_Calificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Dgv_datos);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_calificacion);
            this.Controls.Add(this.Cbo_objetivo);
            this.Controls.Add(this.Cbo_norma);
            this.Controls.Add(this.Cbo_cliente);
            this.Controls.Add(this.Lbl_calificacion);
            this.Controls.Add(this.Lbl_objetivo);
            this.Controls.Add(this.Lbl_norma);
            this.Controls.Add(this.Lbl_cliente);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Calificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Calificacion";
            this.Load += new System.EventHandler(this.Frm_Calificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_cliente;
        private System.Windows.Forms.Label Lbl_norma;
        private System.Windows.Forms.Label Lbl_objetivo;
        private System.Windows.Forms.Label Lbl_calificacion;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_norma;
        private System.Windows.Forms.ComboBox Cbo_objetivo;
        private System.Windows.Forms.TextBox Txt_calificacion;
        private System.Windows.Forms.Button button1;
        private CapaDisenoNavegador.Navegador navegador1;
        private System.Windows.Forms.DataGridView Dgv_datos;
        private ventanaDiseno.ventana ventana1;
    }
}