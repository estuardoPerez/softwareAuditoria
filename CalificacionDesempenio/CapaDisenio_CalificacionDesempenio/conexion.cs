using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaDisenio_CalificacionDesempenio
{
    class conexion
    {
        public static OdbcConnection abrirConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnAuditoria");
            try{conectar.Open();}
            catch (Exception ex)
            {MessageBox.Show(ex.Message);}
            return conectar;
        }

        public static OdbcConnection cerrarConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnAuditoria");
            try { conectar.Close(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return conectar;
        }
    }
}
