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
    public partial class mantenimiento_Departamento : Form
    {
        ventana ventana = new ventana();
        string dsn = "dsnAuditoria";
        DisenoNavegador nav = new DisenoNavegador();

        public mantenimiento_Departamento()
        {
            ventana.pubSetName("Ingreso Proyectos");
            InitializeComponent();
            nav.LlenarTabla("tbl_departamentos", dsn, Dtg_datos);
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

 
        private void ventana1_Load(object sender, EventArgs e)
        {
            nav.NombreForm(this);

           




            modificaarDataGrid();
            Dtg_datos.Columns[0].HeaderText = "Código Departamento";
            Dtg_datos.Columns[1].HeaderText = "Nombre Departamento";
            Dtg_datos.Columns[2].HeaderText = "Descripción";
            
            
        }

        private void Cmb_Proyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Cmb_Proyecto_Click(object sender, EventArgs e)
        {
           
        }

        private void Txt_NoProyecto_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
