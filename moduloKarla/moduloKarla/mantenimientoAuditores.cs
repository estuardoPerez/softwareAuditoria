using CapaDisenoNavegador;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ventanaDiseno;

namespace moduloKarla
{
    public partial class mantenimientoAuditores : Form
    {
        Navegador nvaAuditores = new Navegador();
        ventana ven = new ventana();
        public mantenimientoAuditores()
        {
            InitializeComponent();
            ven.pubSetName("Mantenimientos Auditores");
            DataTable tabla = nvaAuditores.cargarDatos("tbl_auditores");
            dgAuditores.DataSource = tabla;
            nvaAuditores.nombreForm(this);
            nvaAuditores.setDataGR(dgAuditores);
        }

        private void ventana1_Load(object sender, EventArgs e)
        {


        }

        private void dgAuditores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvaAuditores.dgv_datos(dgAuditores);
        }

        private void ventana1_Load_1(object sender, EventArgs e)
        {

        }

        private void ventana1_Load_2(object sender, EventArgs e)
        {

        }

        private void mantenimientoAuditores_Load(object sender, EventArgs e)
        {
            nvaAuditores.ingresarTabla("tbl_auditores");

            dgAuditores.Columns[0].HeaderText = "Codigo/Carnet";
            dgAuditores.Columns[1].HeaderText = "Nombre";
            dgAuditores.Columns[2].HeaderText = "Correo";
            dgAuditores.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAuditores.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAuditores.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAuditores.ColumnHeadersDefaultCellStyle.Font = new Font(dgAuditores.Font, FontStyle.Bold);
        }
    }
}
