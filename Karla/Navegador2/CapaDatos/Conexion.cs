using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatosNavegador
{
    public class Conexion
    {
        public Tuple<OdbcConnection, OdbcTransaction>ObtenerConexion()
        {
            OdbcConnection conectar = new OdbcConnection("Dsn=dsnAuditoria");
            conectar.Open();
            OdbcTransaction transaction = conectar.BeginTransaction();
            return Tuple.Create(conectar, transaction);
        }
    }
}
