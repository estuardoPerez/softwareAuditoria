using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosNavegador;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaLogicaNavegador
{
    public class LogicaNavegador
    {
        Conexion con = new Conexion();
        Sentencia sen = new Sentencia();

        Commandos comando = new Commandos();
        //string sSentencia = "INSERT INTO prueba VALUES('Julios', 'Lutin', '43')";

        public void pubInsertarDatos()
        {
            Console.WriteLine("iiii: " + sen.obtenerSentencia());
            comando.pubInsertData(sen.obtenerSentencia());
        }

        public void insertar(string sTabla, string[] sCampos)
        {
            sen.insertar(sTabla, sCampos);
        }
        //Boton Ingresar--------------------------------------
        public void insertarCampos(string sCampos)
        {
            sen.insertarCampos(sCampos);
        }
        public void terminarSentencia()
        {
            sen.terminarSentencia();
        }

        public void terminarSentenciaSinEstatus()
        {
            sen.terminarSentenciaSinEstatus();
        }

        //Boton Editar-----------------------------------------

        public void actualizar(string sTa, string[] sCampos)
        {
            sen.actualizar(sTa, sCampos);
        }
        public void modificarCampos(string sCampos)
        {
            sen.modificarCampos(sCampos);
        }
        public void terminarSentenciaModificar(string sKey)
        {
            sen.terminarSentenciaModificar(sKey);
        }
        public void limpiarsql()
        {
            sen.limpiarsql();
        }

        public void pubEliminar(string tabla,string id, params string[] campos)
        {
            sen.pubDelete(tabla, id, campos);
            comando.pubInsertData(sen.obtenerSentencia());
        }

        public void pubEliminarSinEstatus(string tabla, string id, params string[] campos)
        {
            sen.pubDeleteSinEstatus(tabla, id, campos);
            comando.pubInsertData(sen.obtenerSentencia());
        }

        public DataTable refrescar(string sTabla, string[] sCampos)
        {
            sen.seleccionar(sTabla, sCampos);
            DataTable table =  comando.pubSeleccionarData(sen.obtenerSentencia());
            return table;
        }

        public DataTable refrescarSinEstatus(string sTabla, string[] sCampos)
        {
            sen.seleccionarSinEstatus(sTabla, sCampos);
            DataTable table = comando.pubSeleccionarData(sen.obtenerSentencia());
            return table;
        }

        public DataTable pubObtenerCampos(string sTabla)
        {
            sen.pubCamposTabla(sTabla);
            DataTable table = comando.pubSeleccionarCampos(sen.obtenerSentencia());
            return table;
        }

        public void insertarSentencia(string query)
        {
            string sql = query;
            sen.insertarSentencia(sql);
        }

        public void ejecutarQuery(string query)
        {
            try
            {
                comando.pubInsertData(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Query incorrecto");
            }
        }
        public DataSet cargarCombobox(string sTabla, string[] sCampos)
        {
            sen.seleccionarSinEstatus(sTabla, sCampos);
            DataSet table = comando.pubObtenerDatos(sen.obtenerSentencia(), sCampos[0]);
            return table;
        }

        public void guardarDatagrid(string tablaData, string[] camposTabla3, DataGridView dgrData, int[] columnas)
        {
            comando.insertarDatagrid(tablaData, camposTabla3, dgrData, columnas);
        }

        public DataTable cargarData(string tablaData, string id, string[] camposTabla3)
        {
            sen.refrescarData(tablaData, id, camposTabla3[0]);
            DataTable table = comando.pubSeleccionarData(sen.obtenerSentencia());
            Console.WriteLine(sen.obtenerSentencia());
            return table;
        }
    }
}
