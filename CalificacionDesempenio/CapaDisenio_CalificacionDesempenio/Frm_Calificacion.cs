using CapaDisenoNavegador;
using System;
using System.Data;
using System.Windows.Forms;
using ventanaDiseno;


// Jazzmin Zavala --------------------------------
namespace CapaDisenio_CalificacionDesempenio
{
    public partial class Frm_Calificacion : Form
    {
        //Crear constructores
        Navegador nav = new Navegador(); 
        ventana ven = new ventana();

        //Variables globales
        DataSet mod;

        public Frm_Calificacion()
        {
            ven.pubSetName("Calificación Desempeño Procesos");
            InitializeComponent();

            cargarCbo_cliente();
        }

        public void cargarCbo_cliente()
        {
            //Cargar datos al datagrid
            try
            {
                DataTable DTdatos = nav.cargarDatos("TBL_CalificacionProcesosEncabezado");
                Dgv_datos.DataSource = DTdatos;
                nav.nombreForm(this);
                nav.setDataGR(Dgv_datos);

                //Cargar datos a los combobox
                mod = nav.cargarCombobox("TBL_ClienteAuditado", "PK_Codcliente", "Nombre_cliente", "estatus");
                DataTable DT_Cbocliente = mod.Tables[0];

                DataSet DS_Cbocliente = new DataSet();
                DataTable DT_Cbocliente2 = new DataTable();
                DS_Cbocliente.Tables.Add(DT_Cbocliente2);
                DT_Cbocliente2.Columns.Add("PK_Codcliente", typeof(string));
                DT_Cbocliente2.Columns.Add("Nombre_cliente", typeof(string));

                foreach (DataRow row in DT_Cbocliente.Rows)
                {
                    string sEst = Convert.ToString(row["estatus"]);
                    string sCod = Convert.ToString(row["PK_Codcliente"]);
                    string sContenido = Convert.ToString(row["Nombre_cliente"]);
                    if (sEst == "0")
                    {
                        DT_Cbocliente2.Rows.Add(sCod, sContenido);
                    }
                }
                Cbo_cliente.DisplayMember = "Nombre_cliente";
                Cbo_cliente.ValueMember = "PK_Codcliente";
                Cbo_cliente.DataSource = DS_Cbocliente.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n"+ex);
            }
            
        }

        private void Frm_Calificacion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Dgv_datos.Columns.Count; i++)
            {
                Dgv_datos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Dgv_datos.Columns[i].ReadOnly = true;
            }

            //Procedimiento para almacenar la info en la BD.
            nav.ingresarTabla("TBL_CalificacionProcesosEncabezado"); 

            Dgv_datos.Columns[0].HeaderText = "Codigo";
            Dgv_datos.Columns[1].HeaderText = "Cliente / Auditado";
        }


        private void Dgv_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nav.dgv_datos(Dgv_datos);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Frm_ResumenCalificación().Show();
        }
    }
}
