namespace Mantenimientos_EP
{
    partial class mantenimiento_Departamento
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
            this.disenoNavegador1 = new Navegador_.DisenoNavegador();
            this.Dtg_datos = new System.Windows.Forms.DataGridView();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Txt_nameProyecto = new System.Windows.Forms.TextBox();
            this.Lbl_NombreDepartamento = new System.Windows.Forms.Label();
            this.Txt_NoDepto = new System.Windows.Forms.TextBox();
            this.Lbl_NoDepto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_datos)).BeginInit();
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
            // disenoNavegador1
            // 
            this.disenoNavegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(175)))));
            this.disenoNavegador1.Location = new System.Drawing.Point(262, 118);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(674, 43);
            this.disenoNavegador1.TabIndex = 1;
            // 
            // Dtg_datos
            // 
            this.Dtg_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dtg_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_datos.EnableHeadersVisualStyles = false;
            this.Dtg_datos.Location = new System.Drawing.Point(548, 249);
            this.Dtg_datos.Name = "Dtg_datos";
            this.Dtg_datos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtg_datos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtg_datos.Size = new System.Drawing.Size(534, 261);
            this.Dtg_datos.TabIndex = 38;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_Descripcion.Location = new System.Drawing.Point(221, 363);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(296, 68);
            this.Txt_Descripcion.TabIndex = 54;
            this.Txt_Descripcion.Tag = "3";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_descripcion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_descripcion.Location = new System.Drawing.Point(41, 363);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(94, 21);
            this.Lbl_descripcion.TabIndex = 53;
            this.Lbl_descripcion.Text = "Descripción:";
            // 
            // Txt_nameProyecto
            // 
            this.Txt_nameProyecto.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_nameProyecto.Location = new System.Drawing.Point(221, 313);
            this.Txt_nameProyecto.Name = "Txt_nameProyecto";
            this.Txt_nameProyecto.Size = new System.Drawing.Size(296, 27);
            this.Txt_nameProyecto.TabIndex = 52;
            this.Txt_nameProyecto.Tag = "2";
            // 
            // Lbl_NombreDepartamento
            // 
            this.Lbl_NombreDepartamento.AutoSize = true;
            this.Lbl_NombreDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NombreDepartamento.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NombreDepartamento.Location = new System.Drawing.Point(41, 310);
            this.Lbl_NombreDepartamento.Name = "Lbl_NombreDepartamento";
            this.Lbl_NombreDepartamento.Size = new System.Drawing.Size(175, 21);
            this.Lbl_NombreDepartamento.TabIndex = 51;
            this.Lbl_NombreDepartamento.Text = "Nombre Departamento:";
            // 
            // Txt_NoDepto
            // 
            this.Txt_NoDepto.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_NoDepto.Location = new System.Drawing.Point(221, 280);
            this.Txt_NoDepto.Name = "Txt_NoDepto";
            this.Txt_NoDepto.Size = new System.Drawing.Size(296, 27);
            this.Txt_NoDepto.TabIndex = 50;
            this.Txt_NoDepto.Tag = "1";
            // 
            // Lbl_NoDepto
            // 
            this.Lbl_NoDepto.AutoSize = true;
            this.Lbl_NoDepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NoDepto.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NoDepto.Location = new System.Drawing.Point(41, 275);
            this.Lbl_NoDepto.Name = "Lbl_NoDepto";
            this.Lbl_NoDepto.Size = new System.Drawing.Size(138, 21);
            this.Lbl_NoDepto.TabIndex = 49;
            this.Lbl_NoDepto.Text = "No. Departamento";
            // 
            // mantenimiento_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_descripcion);
            this.Controls.Add(this.Txt_nameProyecto);
            this.Controls.Add(this.Lbl_NombreDepartamento);
            this.Controls.Add(this.Txt_NoDepto);
            this.Controls.Add(this.Lbl_NoDepto);
            this.Controls.Add(this.Dtg_datos);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantenimiento_Departamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mantenimiento_Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private Navegador_.DisenoNavegador disenoNavegador1;
        private System.Windows.Forms.DataGridView Dtg_datos;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.TextBox Txt_nameProyecto;
        private System.Windows.Forms.Label Lbl_NombreDepartamento;
        private System.Windows.Forms.TextBox Txt_NoDepto;
        private System.Windows.Forms.Label Lbl_NoDepto;
    }
}