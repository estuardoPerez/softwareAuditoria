using CapaDisenoNavegador;
using System;
using System.Data;
using System.Windows.Forms;
using ventanaDiseno;
using System.Data.Odbc;


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

            cargarDatagrid();
            cargarCbo_cliente();
            cargarCbo_normativa();
        }

        public void cargarDatagrid()
        {
            try
            {
                //Cargar datos al datagrid
                DataTable DTdatos = nav.cargarDatos("TBL_CalificacionProcesosEncabezado");
                Dgv_datos.DataSource = DTdatos;
                nav.nombreForm(this);
                nav.setDataGR(Dgv_datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        public void cargarCbo_cliente()
        {
            try
            {
                

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

        public void cargarCbo_normativa()
        {
            try
            {
                //Cargar datos a los combobox
                mod = nav.cargarCombobox("tbl_normativa", "PK_Id_normativa", "Nombre", "estatus");
                DataTable DT_Cbonormativa = mod.Tables[0];

                DataSet DS_Cbonormativa = new DataSet();
                DataTable DT_Cbonormativa2 = new DataTable();
                DS_Cbonormativa.Tables.Add(DT_Cbonormativa2);
                DT_Cbonormativa2.Columns.Add("PK_Id_normativa", typeof(string));
                DT_Cbonormativa2.Columns.Add("Nombre", typeof(string));

                foreach (DataRow row in DT_Cbonormativa.Rows)
                {
                    string sEst = Convert.ToString(row["estatus"]);
                    string sCod = Convert.ToString(row["PK_Id_normativa"]);
                    string sContenido = Convert.ToString(row["Nombre"]);
                    if (sEst == "0")
                    {
                        DT_Cbonormativa2.Rows.Add(sCod, sContenido);
                    }
                }
                Cbo_norma.DisplayMember = "Nombre";
                Cbo_norma.ValueMember = "PK_Id_normativa";
                Cbo_norma.DataSource = DS_Cbonormativa.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }
        public void cargarCbo_objetivo()
        {
            try
            {
                //Cargar datos a los combobox
                conexion.abrirConexion();
                OdbcCommand comando = new OdbcCommand("Select obj.nombre from tbl_objetivo obj, tbl_normativa nor where obj.estatus = 0 and obj.tbl_Dominio_PK_Id_dominio = nor.PK_Id_normativa and nor.PK_Id_normativa ='"+ Cbo_norma.SelectedIndex +"'", conexion.abrirConexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                Cbo_objetivo.ValueMember = "PK_Id_Objetivo";
                Cbo_objetivo.DisplayMember = "Nombre";

                Cbo_objetivo.DataSource = tabla;

                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            new Frm_ResumenCalificación().Show();
        }

        private void Cbo_norma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCbo_objetivo();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_norma_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void ventana1_Load(object sender, EventArgs e)
        {

        }
    }
}
