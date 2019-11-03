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
using Navegador_;

namespace Mantenimientos_EP
{
    public partial class mantenimiento_Proyectos : Form
    {
        ventana ventana = new ventana();
        string dsn = "dsnAuditoria";
        DisenoNavegador nav = new DisenoNavegador();
        public mantenimiento_Proyectos()
        {
            ventana.pubSetName("Ingreso Proyectos");
            InitializeComponent();
            nav.LlenarTabla("tbl_proyecto", dsn, Dtg_datos);
        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nav.NombreForm(this);

            nav.DatosCMB("tbl_normativa", Cmb_Normativa, "Nombre", "Pk_Id_normativa");
            



            modificaarDataGrid();
            Dtg_datos.Columns[0].HeaderText = "Código Proyecto";
            Dtg_datos.Columns[1].HeaderText = "Nombre Proyecto";
            Dtg_datos.Columns[2].HeaderText = "Tipo Proyecto";
            Dtg_datos.Columns[3].HeaderText = "Descripción";
            Dtg_datos.Columns[4].HeaderText = "Fecha Inicio";
            Dtg_datos.Columns[5].HeaderText = "Fecha Final";
        }

        private static mantenimiento_Proyectos mFormDefInstance = null;
        public static mantenimiento_Proyectos DefInstance
        {
            get
            {
                if (mFormDefInstance == null || mFormDefInstance.IsDisposed)
                    mFormDefInstance = new mantenimiento_Proyectos();
                return mFormDefInstance;
            }
            set
            {
                mFormDefInstance = value;
            }
        }

        private void modificaarDataGrid()
        {
            for (int i = 0; i < Dtg_datos.Columns.Count; i++)
            {
                Dtg_datos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dtg_datos.Columns[i].ReadOnly = true;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Txt_NoNormativa.Enabled == true)
            {
                Txt_NoNormativa.Enabled = false;
            }
            else
            {
                Txt_NoNormativa.Enabled = false;
            }
        }

        private void Cmb_Normativa_Click(object sender, EventArgs e)
        {
            nav.LlenarCampos("select Pk_Id_normativa from tbl_normativa where Pk_Id_normativa=", Cmb_Normativa, Txt_NoNormativa);
        }

        private void Txt_NoAsignación_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_TipoProyect_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Normativa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_NoRecurso_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nameProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_NameProyecto_Click(object sender, EventArgs e)
        {

        }
    }
}
