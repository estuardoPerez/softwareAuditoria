namespace Mantenimientos_EP
{
    partial class mantenimiento_Proyectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventana1 = new ventanaDiseno.ventana();
            this.Dtp_final = new System.Windows.Forms.DateTimePicker();
            this.Dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DateEnd = new System.Windows.Forms.Label();
            this.Lbl_dateIncio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Txt_nameProyecto = new System.Windows.Forms.TextBox();
            this.Lbl_NameProyecto = new System.Windows.Forms.Label();
            this.Dtg_datos = new System.Windows.Forms.DataGridView();
            this.Txt_NoAsignación = new System.Windows.Forms.TextBox();
            this.Lbl_NoRecurso = new System.Windows.Forms.Label();
            this.Lbl_TipoProyect = new System.Windows.Forms.Label();
            this.Cmb_Normativa = new System.Windows.Forms.ComboBox();
            this.Txt_NoNormativa = new System.Windows.Forms.TextBox();
            this.disenoNavegador1 = new Navegador_.DisenoNavegador();
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
            // Dtp_final
            // 
            this.Dtp_final.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.Dtp_final.Location = new System.Drawing.Point(683, 199);
            this.Dtp_final.Name = "Dtp_final";
            this.Dtp_final.Size = new System.Drawing.Size(249, 25);
            this.Dtp_final.TabIndex = 45;
            this.Dtp_final.Tag = "5";
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicio.Location = new System.Drawing.Point(255, 199);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.Size = new System.Drawing.Size(249, 25);
            this.Dtp_inicio.TabIndex = 44;
            this.Dtp_inicio.Tag = "4";
            // 
            // Lbl_DateEnd
            // 
            this.Lbl_DateEnd.AutoSize = true;
            this.Lbl_DateEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_DateEnd.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_DateEnd.Location = new System.Drawing.Point(575, 198);
            this.Lbl_DateEnd.Name = "Lbl_DateEnd";
            this.Lbl_DateEnd.Size = new System.Drawing.Size(90, 21);
            this.Lbl_DateEnd.TabIndex = 43;
            this.Lbl_DateEnd.Text = "Fecha Final:";
            // 
            // Lbl_dateIncio
            // 
            this.Lbl_dateIncio.AutoSize = true;
            this.Lbl_dateIncio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_dateIncio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_dateIncio.Location = new System.Drawing.Point(141, 198);
            this.Lbl_dateIncio.Name = "Lbl_dateIncio";
            this.Lbl_dateIncio.Size = new System.Drawing.Size(94, 21);
            this.Lbl_dateIncio.TabIndex = 42;
            this.Lbl_dateIncio.Text = "Fecha Inicio:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.textBox1.Location = new System.Drawing.Point(239, 396);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 68);
            this.textBox1.TabIndex = 41;
            this.textBox1.Tag = "3";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_descripcion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_descripcion.Location = new System.Drawing.Point(85, 393);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(94, 21);
            this.Lbl_descripcion.TabIndex = 40;
            this.Lbl_descripcion.Text = "Descripción:";
            this.Lbl_descripcion.Click += new System.EventHandler(this.Lbl_descripcion_Click);
            // 
            // Txt_nameProyecto
            // 
            this.Txt_nameProyecto.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_nameProyecto.Location = new System.Drawing.Point(239, 307);
            this.Txt_nameProyecto.Name = "Txt_nameProyecto";
            this.Txt_nameProyecto.Size = new System.Drawing.Size(296, 27);
            this.Txt_nameProyecto.TabIndex = 39;
            this.Txt_nameProyecto.Tag = "2";
            this.Txt_nameProyecto.TextChanged += new System.EventHandler(this.Txt_nameProyecto_TextChanged);
            // 
            // Lbl_NameProyecto
            // 
            this.Lbl_NameProyecto.AutoSize = true;
            this.Lbl_NameProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NameProyecto.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NameProyecto.Location = new System.Drawing.Point(85, 304);
            this.Lbl_NameProyecto.Name = "Lbl_NameProyecto";
            this.Lbl_NameProyecto.Size = new System.Drawing.Size(136, 21);
            this.Lbl_NameProyecto.TabIndex = 38;
            this.Lbl_NameProyecto.Text = "Nombre Proyecto:";
            this.Lbl_NameProyecto.Click += new System.EventHandler(this.Lbl_NameProyecto_Click);
            // 
            // Dtg_datos
            // 
            this.Dtg_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dtg_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Dtg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_datos.EnableHeadersVisualStyles = false;
            this.Dtg_datos.Location = new System.Drawing.Point(558, 252);
            this.Dtg_datos.Name = "Dtg_datos";
            this.Dtg_datos.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtg_datos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Dtg_datos.Size = new System.Drawing.Size(534, 261);
            this.Dtg_datos.TabIndex = 37;
            // 
            // Txt_NoAsignación
            // 
            this.Txt_NoAsignación.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.Txt_NoAsignación.Location = new System.Drawing.Point(239, 272);
            this.Txt_NoAsignación.Name = "Txt_NoAsignación";
            this.Txt_NoAsignación.Size = new System.Drawing.Size(296, 27);
            this.Txt_NoAsignación.TabIndex = 36;
            this.Txt_NoAsignación.Tag = "1";
            this.Txt_NoAsignación.TextChanged += new System.EventHandler(this.Txt_NoAsignación_TextChanged);
            // 
            // Lbl_NoRecurso
            // 
            this.Lbl_NoRecurso.AutoSize = true;
            this.Lbl_NoRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_NoRecurso.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_NoRecurso.Location = new System.Drawing.Point(85, 269);
            this.Lbl_NoRecurso.Name = "Lbl_NoRecurso";
            this.Lbl_NoRecurso.Size = new System.Drawing.Size(99, 21);
            this.Lbl_NoRecurso.TabIndex = 35;
            this.Lbl_NoRecurso.Text = "No. Proyecto";
            this.Lbl_NoRecurso.Click += new System.EventHandler(this.Lbl_NoRecurso_Click);
            // 
            // Lbl_TipoProyect
            // 
            this.Lbl_TipoProyect.AutoSize = true;
            this.Lbl_TipoProyect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Lbl_TipoProyect.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Lbl_TipoProyect.Location = new System.Drawing.Point(85, 348);
            this.Lbl_TipoProyect.Name = "Lbl_TipoProyect";
            this.Lbl_TipoProyect.Size = new System.Drawing.Size(121, 21);
            this.Lbl_TipoProyect.TabIndex = 34;
            this.Lbl_TipoProyect.Text = "Tipo Normativa:";
            this.Lbl_TipoProyect.Click += new System.EventHandler(this.Lbl_TipoProyect_Click);
            // 
            // Cmb_Normativa
            // 
            this.Cmb_Normativa.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Normativa.FormattingEnabled = true;
            this.Cmb_Normativa.Location = new System.Drawing.Point(306, 351);
            this.Cmb_Normativa.Name = "Cmb_Normativa";
            this.Cmb_Normativa.Size = new System.Drawing.Size(229, 28);
            this.Cmb_Normativa.TabIndex = 33;
            this.Cmb_Normativa.SelectedIndexChanged += new System.EventHandler(this.Cmb_Normativa_SelectedIndexChanged);
            this.Cmb_Normativa.Click += new System.EventHandler(this.Cmb_Normativa_Click);
            // 
            // Txt_NoNormativa
            // 
            this.Txt_NoNormativa.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.Txt_NoNormativa.Location = new System.Drawing.Point(239, 351);
            this.Txt_NoNormativa.Name = "Txt_NoNormativa";
            this.Txt_NoNormativa.Size = new System.Drawing.Size(61, 29);
            this.Txt_NoNormativa.TabIndex = 46;
            this.Txt_NoNormativa.Tag = "6";
            this.Txt_NoNormativa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // disenoNavegador1
            // 
            this.disenoNavegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(175)))));
            this.disenoNavegador1.Location = new System.Drawing.Point(258, 87);
            this.disenoNavegador1.Name = "disenoNavegador1";
            this.disenoNavegador1.Size = new System.Drawing.Size(674, 43);
            this.disenoNavegador1.TabIndex = 47;
            // 
            // mantenimiento_Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.disenoNavegador1);
            this.Controls.Add(this.Txt_NoNormativa);
            this.Controls.Add(this.Dtp_final);
            this.Controls.Add(this.Dtp_inicio);
            this.Controls.Add(this.Lbl_DateEnd);
            this.Controls.Add(this.Lbl_dateIncio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_descripcion);
            this.Controls.Add(this.Txt_nameProyecto);
            this.Controls.Add(this.Lbl_NameProyecto);
            this.Controls.Add(this.Dtg_datos);
            this.Controls.Add(this.Txt_NoAsignación);
            this.Controls.Add(this.Lbl_NoRecurso);
            this.Controls.Add(this.Lbl_TipoProyect);
            this.Controls.Add(this.Cmb_Normativa);
            this.Controls.Add(this.ventana1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mantenimiento_Proyectos";
            this.Text = "mantenimiento_Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ventanaDiseno.ventana ventana1;
        private System.Windows.Forms.DateTimePicker Dtp_final;
        private System.Windows.Forms.DateTimePicker Dtp_inicio;
        private System.Windows.Forms.Label Lbl_DateEnd;
        private System.Windows.Forms.Label Lbl_dateIncio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.TextBox Txt_nameProyecto;
        private System.Windows.Forms.Label Lbl_NameProyecto;
        private System.Windows.Forms.DataGridView Dtg_datos;
        private System.Windows.Forms.TextBox Txt_NoAsignación;
        private System.Windows.Forms.Label Lbl_NoRecurso;
        private System.Windows.Forms.Label Lbl_TipoProyect;
        private System.Windows.Forms.ComboBox Cmb_Normativa;
        private System.Windows.Forms.TextBox Txt_NoNormativa;
        private Navegador_.DisenoNavegador disenoNavegador1;
    }
}