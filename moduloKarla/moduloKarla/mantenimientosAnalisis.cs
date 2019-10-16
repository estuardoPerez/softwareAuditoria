using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaDisenoNavegador;
using ventanaDiseno;

namespace moduloKarla
{
    public partial class mantenimientosAnalisis : Form
    {
        Navegador nvAnalisis = new Navegador();
        ventana vna = new ventana();
        public mantenimientosAnalisis()
        {
            InitializeComponent();
            vna.pubSetName("Mantenimientos Analistas");
            DataTable tabla = nvAnalisis.cargarDatos("tbl_encargado_analisis");
            dgAnalisis.DataSource = tabla;
            nvAnalisis.nombreForm(this);
            nvAnalisis.setDataGR(dgAnalisis);
        }

        private void dgAnalisis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mantenimientosAnalisis_Load(object sender, System.EventArgs e)
        {
            nvAnalisis.ingresarTabla("tbl_encargado_analisis");

            dgAnalisis.Columns[0].HeaderText = "Codigo/Carnet";
            dgAnalisis.Columns[1].HeaderText = "Nombre";
            dgAnalisis.Columns[2].HeaderText = "Area";
            dgAnalisis.Columns[3].HeaderText = "Correo";
            dgAnalisis.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAnalisis.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAnalisis.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAnalisis.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAnalisis.ColumnHeadersDefaultCellStyle.Font = new Font(dgAnalisis.Font, FontStyle.Bold);
        }

        private void dgAnalisis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvAnalisis.dgv_datos(dgAnalisis);
        }
    }
}
