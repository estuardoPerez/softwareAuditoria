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
    public partial class Frm_normativa : Form
    {
        ventana ven = new ventana();
        Navegador nvAplicacion = new Navegador();

        public Frm_normativa()
        {
            InitializeComponent();

            ven.pubSetName("Normativa De Trabajo");
            DataTable tabla = nvAplicacion.cargarDatos("tbl_normativa");
            dgv_Normativa.DataSource = tabla;
            nvAplicacion.nombreForm(this);
            nvAplicacion.setDataGR(dgv_Normativa);
        }

        private void ventana1_Load(object sender, EventArgs e)
        {
            nvAplicacion.ingresarTabla("tbl_normativa");

            dgv_Normativa.Columns[0].HeaderText = "Codigo";
            dgv_Normativa.Columns[1].HeaderText = "Normativa";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Normativa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nvAplicacion.dgv_datos(dgv_Normativa);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
