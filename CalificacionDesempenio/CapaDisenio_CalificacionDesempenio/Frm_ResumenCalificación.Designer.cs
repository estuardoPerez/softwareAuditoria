namespace CapaDisenio_CalificacionDesempenio
{
    partial class Frm_ResumenCalificación
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gpb_filtros = new System.Windows.Forms.GroupBox();
            this.Cbo_rangoSuperior = new System.Windows.Forms.ComboBox();
            this.Lbl_procesos2 = new System.Windows.Forms.Label();
            this.Cbo_rangoInferior = new System.Windows.Forms.ComboBox();
            this.Lbl_procesos = new System.Windows.Forms.Label();
            this.Cbo_clasificacion = new System.Windows.Forms.ComboBox();
            this.Lbl_clasificación = new System.Windows.Forms.Label();
            this.Dgv_datos = new System.Windows.Forms.DataGridView();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_cliente = new System.Windows.Forms.Label();
            this.ventana1 = new ventanaDiseno.ventana();
            this.navegador1 = new CapaDisenoNavegador.Navegador();
            this.Gpb_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_filtros
            // 
            this.Gpb_filtros.Controls.Add(this.Cbo_cliente);
            this.Gpb_filtros.Controls.Add(this.Lbl_cliente);
            this.Gpb_filtros.Controls.Add(this.Cbo_rangoSuperior);
            this.Gpb_filtros.Controls.Add(this.Lbl_procesos2);
            this.Gpb_filtros.Controls.Add(this.Cbo_rangoInferior);
            this.Gpb_filtros.Controls.Add(this.Lbl_procesos);
            this.Gpb_filtros.Controls.Add(this.Cbo_clasificacion);
            this.Gpb_filtros.Controls.Add(this.Lbl_clasificación);
            this.Gpb_filtros.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_filtros.Location = new System.Drawing.Point(44, 108);
            this.Gpb_filtros.Name = "Gpb_filtros";
            this.Gpb_filtros.Size = new System.Drawing.Size(1066, 90);
            this.Gpb_filtros.TabIndex = 2;
            this.Gpb_filtros.TabStop = false;
            this.Gpb_filtros.Text = "Filtros";
            this.Gpb_filtros.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Cbo_rangoSuperior
            // 
            this.Cbo_rangoSuperior.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_rangoSuperior.FormattingEnabled = true;
            this.Cbo_rangoSuperior.Location = new System.Drawing.Point(944, 40);
            this.Cbo_rangoSuperior.Name = "Cbo_rangoSuperior";
            this.Cbo_rangoSuperior.Size = new System.Drawing.Size(77, 29);
            this.Cbo_rangoSuperior.TabIndex = 10;
            // 
            // Lbl_procesos2
            // 
            this.Lbl_procesos2.AutoSize = true;
            this.Lbl_procesos2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_procesos2.Location = new System.Drawing.Point(916, 43);
            this.Lbl_procesos2.Name = "Lbl_procesos2";
            this.Lbl_procesos2.Size = new System.Drawing.Size(22, 21);
            this.Lbl_procesos2.TabIndex = 9;
            this.Lbl_procesos2.Text = "al";
            // 
            // Cbo_rangoInferior
            // 
            this.Cbo_rangoInferior.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_rangoInferior.FormattingEnabled = true;
            this.Cbo_rangoInferior.Location = new System.Drawing.Point(833, 40);
            this.Cbo_rangoInferior.Name = "Cbo_rangoInferior";
            this.Cbo_rangoInferior.Size = new System.Drawing.Size(77, 29);
            this.Cbo_rangoInferior.TabIndex = 8;
            // 
            // Lbl_procesos
            // 
            this.Lbl_procesos.AutoSize = true;
            this.Lbl_procesos.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_procesos.Location = new System.Drawing.Point(752, 43);
            this.Lbl_procesos.Name = "Lbl_procesos";
            this.Lbl_procesos.Size = new System.Drawing.Size(75, 21);
            this.Lbl_procesos.TabIndex = 7;
            this.Lbl_procesos.Text = "Procesos:";
            // 
            // Cbo_clasificacion
            // 
            this.Cbo_clasificacion.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_clasificacion.FormattingEnabled = true;
            this.Cbo_clasificacion.Location = new System.Drawing.Point(500, 40);
            this.Cbo_clasificacion.Name = "Cbo_clasificacion";
            this.Cbo_clasificacion.Size = new System.Drawing.Size(228, 29);
            this.Cbo_clasificacion.TabIndex = 6;
            // 
            // Lbl_clasificación
            // 
            this.Lbl_clasificación.AutoSize = true;
            this.Lbl_clasificación.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_clasificación.Location = new System.Drawing.Point(395, 43);
            this.Lbl_clasificación.Name = "Lbl_clasificación";
            this.Lbl_clasificación.Size = new System.Drawing.Size(99, 21);
            this.Lbl_clasificación.TabIndex = 3;
            this.Lbl_clasificación.Text = "Clasificación:";
            this.Lbl_clasificación.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Dgv_datos
            // 
            this.Dgv_datos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgv_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dgv_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_datos.DefaultCellStyle = dataGridViewCellStyle13;
            this.Dgv_datos.EnableHeadersVisualStyles = false;
            this.Dgv_datos.GridColor = System.Drawing.Color.MediumAquamarine;
            this.Dgv_datos.Location = new System.Drawing.Point(90, 204);
            this.Dgv_datos.Name = "Dgv_datos";
            this.Dgv_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Dgv_datos.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_datos.Size = new System.Drawing.Size(953, 375);
            this.Dgv_datos.TabIndex = 207;
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(95, 40);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(275, 29);
            this.Cbo_cliente.TabIndex = 12;
            this.Cbo_cliente.Tag = "1";
            // 
            // Lbl_cliente
            // 
            this.Lbl_cliente.AutoSize = true;
            this.Lbl_cliente.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cliente.Location = new System.Drawing.Point(28, 43);
            this.Lbl_cliente.Name = "Lbl_cliente";
            this.Lbl_cliente.Size = new System.Drawing.Size(61, 21);
            this.Lbl_cliente.TabIndex = 11;
            this.Lbl_cliente.Text = "Cliente:";
            // 
            // ventana1
            // 
            this.ventana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ventana1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventana1.Location = new System.Drawing.Point(0, 0);
            this.ventana1.Name = "ventana1";
            this.ventana1.Size = new System.Drawing.Size(1140, 643);
            this.ventana1.TabIndex = 208;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(103, 57);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(910, 65);
            this.navegador1.TabIndex = 209;
            // 
            // Frm_ResumenCalificación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Gpb_filtros);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Dgv_datos);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ResumenCalificación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_ResumenCalificación";
            this.Load += new System.EventHandler(this.Frm_ResumenCalificación_Load);
            this.Gpb_filtros.ResumeLayout(false);
            this.Gpb_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Gpb_filtros;
        private System.Windows.Forms.Label Lbl_clasificación;
        private System.Windows.Forms.ComboBox Cbo_rangoSuperior;
        private System.Windows.Forms.Label Lbl_procesos2;
        private System.Windows.Forms.ComboBox Cbo_rangoInferior;
        private System.Windows.Forms.Label Lbl_procesos;
        private System.Windows.Forms.ComboBox Cbo_clasificacion;
        private System.Windows.Forms.DataGridView Dgv_datos;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.Label Lbl_cliente;
        private ventanaDiseno.ventana ventana1;
        private CapaDisenoNavegador.Navegador navegador1;
    }
}