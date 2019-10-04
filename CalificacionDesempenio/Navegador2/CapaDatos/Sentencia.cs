using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosNavegador;
using System.Data.Odbc;


namespace CapaDatosNavegador
{
    public class Sentencia
    {
        public static string sql;
        string[] campos;
        static string[] camposs;
        int posicion = 1;

        public void cancelarSentencia()
        {
            sql = "";
        }
        public void insertarSentencia(string query)
        {
            sql = query;
        }
        //Creacion de sentencia para Insertar
        public void insertar(string tabla, params string[] campos)
        {
            sql = "";
            sql = "INSERT INTO " + tabla + " (";
            for (int i = 0; i < campos.Length; i++)
            {
                sql = sql + campos[i] + ", ";
            }
            char[] quitar = { ',', ' ' };
            sql = sql.TrimEnd(quitar);
            sql = sql + ") VALUES (";
        }

        public void insertarCampos(string campo)
        {
            sql = sql + "'" + campo + "',";
        }
        public void terminarSentencia()
        {
            sql = sql + "'0');";
        }
        public void terminarSentenciaSinEstatus()
        {
            char[] quitar = { ','};
            sql = sql.TrimEnd(quitar);
            sql = sql + ");";
        }
        public string obtenerSentencia()
        {
            return sql;
        }

        //Creacion de sentencia para Modificar
        public void actualizar(string tabla, params string[] campos)
        {
            sql = "";
            camposs = campos;
            sql = "UPDATE " + tabla + " SET ";
        }
        public void modificarCampos(string campo)
        {
            if (posicion < camposs.Length)
            {
                    sql = sql + camposs[posicion] + " = '" + campo + "', ";
                    posicion++;            
            }
            else
            {
                Console.WriteLine("Error indice incorrecto");
            }
        }
        public void terminarSentenciaModificar(string llavePrimaria)
        {
            char[] quitar = { ',', ' ' };
            sql = sql.TrimEnd(quitar);
            sql = sql + " WHERE " + camposs[0] + " = '" + llavePrimaria + "';";
            posicion = 1;
        }

        public void limpiarsql()
        {
            sql = "";           
        }

        //Creacion de la sentencia para Seleccionar
        public void seleccionar(string tabla, params string[] campos)
        {
            sql = "";
            sql = "SELECT ";
            for (int i = 0; i < (campos.Length - 1); i++)
            {
                sql = sql + campos[i] + ", ";
            }
            char[] quitar = { ',', ' ' };
            sql = sql.TrimEnd(quitar);
            sql = sql + " FROM " + tabla + " WHERE estatus = '0'";
        }

        public void seleccionarSinEstatus(string tabla, params string[] campos)
        {
            sql = "";
            sql = "SELECT ";
            for (int i = 0; i < campos.Length; i++)
            {
                sql = sql + campos[i] + ", ";
            }
            char[] quitar = { ',', ' ' };
            sql = sql.TrimEnd(quitar);
            sql = sql + " FROM " + tabla + ";";
        }


        public void pubDelete(string tabla, string id, params string[] campos)
        {
            sql = "";
            this.campos = campos;
            sql = "UPDATE " + tabla + " SET estatus = '1' WHERE " + campos[0] + " = '" + id + "'";  
        }

        public void pubDeleteSinEstatus(string tabla, string id, params string[] campos)
        {
            sql = "";
            this.campos = campos;
            sql = "DELETE FROM " + tabla + " WHERE " + campos[0] + " = '" + id + "'";
        }

        public void pubCamposTabla(string tabla)
        {
            sql = "";
            sql = "SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabla + "';";
        }
        public void refrescarData(string tablaData, string id, string campoPrimaria)
        {
            sql = "";
            sql = "SELECT * FROM " + tablaData + " WHERE " + campoPrimaria + " = '" + id + "';";
        }
    }
}
