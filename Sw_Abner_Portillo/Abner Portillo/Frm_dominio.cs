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
using CapaDisenoNavegador;

namespace Abner_Portillo
{
    public partial class Frm_dominio : Form
    {
        DataSet mod;
        ventana ven = new ventana();
        Navegador nvAplicacion = new Navegador();

        public Frm_dominio()
        {
            InitializeComponent();

            mod = nvAplicacion.cargarCombobox("tbl_normativa", "PK_Id_normativa", "nombreNormativa", "estatus");
            DataTable dtA = mod.Tables[0];

            DataSet dsA = new DataSet();
            DataTable dtA2 = new DataTable();
            dsA.Tables.Add(dtA2);
            dtA2.Columns.Add("PK_Id_normativa", typeof(string));
            dtA2.Columns.Add("nombreNormativa", typeof(string));
            foreach (DataRow row in dtA.Rows)
            {
                string estA = Convert.ToString(row["estatus"]);
                string codA = Convert.ToString(row["PK_Id_normativa"]);
                string nomA = Convert.ToString(row["nombreNormativa"]);
                if (estA == "0")
                {
                    dtA2.Rows.Add(codA, nomA);
                }

                cbo_nomativa.DisplayMember = "nombreNormativa";
                cbo_nomativa.ValueMember = "PK_Id_normativa";
                cbo_nomativa.DataSource = dsA.Tables[0];

            }

            ven.pubSetName("Dominio De Trabajo");
            DataTable tabla = nvAplicacion.cargarDatos("tbl_dominio");
            dgv_Dominio.DataSource = tabla;
            nvAplicacion.nombreForm(this);
            nvAplicacion.setDataGR(dgv_Dominio);
        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nvAplicacion.ingresarTabla("tbl_dominio");

            dgv_Dominio.Columns[0].HeaderText = "Codigo";
            dgv_Dominio.Columns[1].HeaderText = "Dominio";
            dgv_Dominio.Columns[2].HeaderText = "Descripcion";
        }

        private void dgv_Dominio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvAplicacion.dgv_datos(dgv_Dominio);
        }
    }
}
