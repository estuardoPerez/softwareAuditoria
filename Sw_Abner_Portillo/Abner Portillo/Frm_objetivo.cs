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
    public partial class Frm_objetivo : Form
    {
        DataSet mod;
        ventana ven = new ventana();
        Navegador nvAplicacion = new Navegador();
        ConectarServidor nuevo = new ConectarServidor();

        public Frm_objetivo()
        {
            ven.pubSetName("Objetivos de Dominio");

            mod = nvAplicacion.cargarCombobox("tbl_objetivo", "PK_Id_Objetivo", "Nombre", "estatus");
            DataTable dtA = mod.Tables[0];

            DataSet dsA = new DataSet();
            DataTable dtA2 = new DataTable();
            dsA.Tables.Add(dtA2);
            dtA2.Columns.Add("PK_Id_Objetivo", typeof(string));
            dtA2.Columns.Add("Nombre", typeof(string));
            foreach (DataRow row in dtA.Rows)
            {
                string estA = Convert.ToString(row["estatus"]);
                string codA = Convert.ToString(row["PK_Id_Objetivo"]);
                string nomA = Convert.ToString(row["Nombre"]);
                if (estA == "0")
                {
                    dtA2.Rows.Add(codA, nomA);
                }

                cbo_dominio.DisplayMember = "Nombre";
                cbo_dominio.ValueMember = "PK_Id_Objetivo";
                cbo_dominio.DataSource = dsA.Tables[0];

            }

            DataTable tabla = nvAplicacion.cargarDatos("tbl_objetivo");
            dgv_Objetivo.DataSource = tabla;
            nvAplicacion.nombreForm(this);
            nvAplicacion.setDataGR(dgv_Objetivo);

            InitializeComponent();
        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nvAplicacion.ingresarTabla("tbl_objetivo");

            dgv_Objetivo.Columns[0].HeaderText = "Codigo";
            dgv_Objetivo.Columns[1].HeaderText = "Dominio";
            dgv_Objetivo.Columns[2].HeaderText = "Descripcion";
        }

        private void dgv_Objetivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvAplicacion.dgv_datos(dgv_Objetivo);
        }

        private void cbo_dominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //consulta para obtener codigo, rango y tipo examen en base al nombre
            string Snombre = cbo_dominio.Text;
            string Ssql = "SELECT PK_Id_Objetivo FROM tbl_objetivo; WHERE Nombre = '" + Snombre + "'";
            OdbcCommand cmd = nuevo.conexion().CreateCommand();
            cmd.CommandText = Ssql;
            cmd.ExecuteNonQuery();
            OdbcDataReader almacena = cmd.ExecuteReader();
            if (almacena.Read())
            {
                Txt_IdDomino.Text = almacena["PK_Id_Objetivo"].ToString();
                nuevo.cerrarConexion();
            }
            nuevo.cerrarConexion();
        }
    }
}
