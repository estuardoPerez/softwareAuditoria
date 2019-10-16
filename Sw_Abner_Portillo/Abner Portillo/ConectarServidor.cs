using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Abner_Portillo
{
    class ConectarServidor
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnauditoria;");
            try
            {
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conectar;
        }
        public OdbcConnection cerrarConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnauditoria;");
            try
            {
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conectar;
        }
    }
}
