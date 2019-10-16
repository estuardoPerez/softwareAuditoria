using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventanaDiseno;


namespace CapaDisenio_CalificacionDesempenio
{
    public partial class Frm_ResumenCalificación : Form
    {
        ventana ven = new ventana();
        public Frm_ResumenCalificación()
        {
            ven.pubSetName("Resumen Calificación de Procesos");
            InitializeComponent();
        }

        private void Frm_ResumenCalificación_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Dgv_datos.Columns.Count; i++)
                {
                    Dgv_datos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    Dgv_datos.Columns[i].ReadOnly = true;
                }

                //Procedimiento para almacenar la info en la BD.
                //nav.ingresarTabla("TBL_CalificacionProcesosEncabezado");

                Dgv_datos.Columns[0].HeaderText = "ID";
                Dgv_datos.Columns[1].HeaderText = "Nombre";
                Dgv_datos.Columns[2].HeaderText = "Descripción";
                Dgv_datos.Columns[3].HeaderText = "Calificación";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }

        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
