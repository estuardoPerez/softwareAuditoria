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
using System.Data.Odbc;

namespace Abner_Portillo
{
    public partial class Frm_dominio : Form
    {
        DataSet mod;
        ventana ven = new ventana();
        Navegador nvAplicacion = new Navegador();
        ConectarServidor nuevo = new ConectarServidor();

        public Frm_dominio()
        {
            InitializeComponent();

            mod = nvAplicacion.cargarCombobox("tbl_normativa", "PK_Id_normativa", "Nombre", "estatus");
            DataTable dtA = mod.Tables[0];

            
            DataSet dsA = new DataSet();
            DataTable dtA2 = new DataTable();
            dsA.Tables.Add(dtA2);
            dtA2.Columns.Add("PK_Id_normativa", typeof(string));
            dtA2.Columns.Add("Nombre", typeof(string));
            foreach (DataRow row in dtA.Rows)
            {
                string estA = Convert.ToString(row["estatus"]);
                string codA = Convert.ToString(row["PK_Id_normativa"]);
                string nomA = Convert.ToString(row["Nombre"]);
                if (estA == "0")
                {
                    dtA2.Rows.Add(codA, nomA);
                }

                cbo_nomativa.DisplayMember = "Nombre";
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

        private void cbo_nomativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consulta para obtener codigo, rango y tipo examen en base al nombre
            string Snombre = cbo_nomativa.Text;
            string Ssql = "SELECT PK_Id_normativa FROM tbl_normativa WHERE Nombre = '" + Snombre + "'";
            OdbcCommand cmd = nuevo.conexion().CreateCommand();
            cmd.CommandText = Ssql;
            cmd.ExecuteNonQuery();
            OdbcDataReader almacena = cmd.ExecuteReader();
            if (almacena.Read())
            {
                Txt_IdNormativa.Text = almacena["PK_Id_normativa"].ToString();
                nuevo.cerrarConexion();
            }
            nuevo.cerrarConexion();
        }
    
    }
}
