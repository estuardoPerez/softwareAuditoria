using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaDisenoNavegador;
using ventanaDiseno;

namespace moduloKarla
{
    public partial class asignacionAuditoresAnalisis : Form
    {
        Navegador nvAsignacion = new Navegador();
        ventana vnas = new ventana();
        DataSet auditor;
        DataSet analista;
        DataSet objetivo;
        public asignacionAuditoresAnalisis()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            vnas.pubSetName("Asignacion Auditores");
            DataTable tabla = nvAsignacion.cargarDatos("tbl_asignacionauditoranalisis");
            dgAsignacion.DataSource = tabla;
            nvAsignacion.nombreForm(this);
            nvAsignacion.setDataGR(dgAsignacion);

            auditor = nvAsignacion.cargarCombobox("tbl_auditores", "pk_carnet", "nombre", "estatus");
            DataTable dtE = auditor.Tables[0];

            DataSet dsE = new DataSet();
            DataTable dtE2 = new DataTable();
            dsE.Tables.Add(dtE2);
            dtE2.Columns.Add("pk_carnet", typeof(string));
            dtE2.Columns.Add("nombre", typeof(string));
            foreach (DataRow row in dtE.Rows)
            {
                string estE = Convert.ToString(row["estatus"]);
                string codE = Convert.ToString(row["pk_carnet"]);
                string TipE = Convert.ToString(row["nombre"]);
                if (estE == "0")
                {
                    dtE2.Rows.Add(codE, TipE);
                }
            }
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "pk_carnet";
            comboBox1.DataSource = dsE.Tables[0];

            analista = nvAsignacion.cargarCombobox("tbl_encargado_analisis", "pk_id_encargado", "nombre", "estatus");
            DataTable dtA = analista.Tables[0];

            DataSet dsA = new DataSet();
            DataTable dtA2 = new DataTable();
            dsA.Tables.Add(dtA2);
            dtA2.Columns.Add("pk_id_encargado", typeof(string));
            dtA2.Columns.Add("nombre", typeof(string));
            foreach (DataRow row in dtA.Rows)
            {
                string estE = Convert.ToString(row["estatus"]);
                string codE = Convert.ToString(row["pk_id_encargado"]);
                string TipE = Convert.ToString(row["nombre"]);
                if (estE == "0")
                {
                    dtA2.Rows.Add(codE, TipE);
                }
            }
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "pk_id_encargado";
            comboBox2.DataSource = dsA.Tables[0];

            objetivo = nvAsignacion.cargarCombobox("tbl_objetivos", "Pk_Id_objetivo", "nombre", "estatus");
            DataTable dtO = objetivo.Tables[0];

            DataSet dsO = new DataSet();
            DataTable dtO2 = new DataTable();
            dsO.Tables.Add(dtO2);
            dtO2.Columns.Add("Pk_Id_objetivo", typeof(string));
            dtO2.Columns.Add("nombre", typeof(string));
            foreach (DataRow row in dtO.Rows)
            {
                string estE = Convert.ToString(row["estatus"]);
                string codE = Convert.ToString(row["Pk_Id_objetivo"]);
                string TipE = Convert.ToString(row["nombre"]);
                if (estE == "0")
                {
                    dtO2.Rows.Add(codE, TipE);
                }
            }
            comboBox3.DisplayMember = "nombre";
            comboBox3.ValueMember = "Pk_Id_objetivo";
            comboBox3.DataSource = dsO.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void asignacionAuditoresAnalisis_Load(object sender, EventArgs e)
        {
            nvAsignacion.ingresarTabla("tbl_auditores");

            dgAsignacion.Columns[0].HeaderText = "Codigo Auditor";
            dgAsignacion.Columns[1].HeaderText = "Codigo Analista";
            dgAsignacion.Columns[2].HeaderText = "Codigo Objetivo";
            dgAsignacion.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAsignacion.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAsignacion.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgAsignacion.ColumnHeadersDefaultCellStyle.Font = new Font(dgAsignacion.Font, FontStyle.Bold);
        }

        private void dgAsignacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvAsignacion.dgv_datos(dgAsignacion);
        }

        private void ventana1_Load(object sender, EventArgs e)
        {

        }
    }
}
