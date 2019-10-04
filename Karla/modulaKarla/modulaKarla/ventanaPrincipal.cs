using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDisenoNavegador;

namespace modulaKarla
{
    public partial class ventanaPrincipal : Form
    {
        Navegador navModulo = new Navegador();
        DataSet mod;
        public ventanaPrincipal()
        {
            InitializeComponent();
            txtAuditor.Visible = false;
            txtEncargado.Visible = false;
            txtObjetivo.Visible = false;
            DataTable tabla = navModulo.cargarDatos("tbl_encargado_auditores");
            dgModulo.DataSource = tabla;
            navModulo.nombreForm(this);
            navModulo.setDataGR(dgModulo);

            mod = navModulo.cargarCombobox("tbl_encargado_auditores", "pk_id_encargado", "nombre", "estatus");
            DataTable dtA = mod.Tables[0];

            DataSet dsA = new DataSet();
            DataTable dtA2 = new DataTable();
            dsA.Tables.Add(dtA2);
            dtA2.Columns.Add("pk_id_encargado", typeof(string));
            dtA2.Columns.Add("nombre", typeof(string));
            foreach (DataRow row in dtA.Rows)
            {
                string estA = Convert.ToString(row["estatus"]);
                string codA = Convert.ToString(row["pk_id_encargado"]);
                string marcA = Convert.ToString(row["nombre"]);
                if (estA == "0")
                { 
                    dtA2.Rows.Add(codA, marcA);
                }
            }
            cboEncargado.DisplayMember = "nombre";
            cboEncargado.ValueMember = "pk_id_encargado";
            cboEncargado.DataSource = dsA.Tables[0];


        }

        private void Ventana1_Load(object sender, EventArgs e)
        {

        }
    }
}
