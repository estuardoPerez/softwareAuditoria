using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RetornoCadenaDeConexion;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Datos
    {



        public List<Permiso> obtenerPermisos(int usuarioCodigo)
        {

            //CadenaDeConexion cadenaConexion = new CadenaDeConexion();
            List<Permiso> respuesta = new List<Permiso>();
            //string query = "select d.FK_Api_codigo as aplicacion, d.ingresar, d.editar, d.guardar, d.borrar,  d.consultar FROM tbl_usuario a, tbl_relacion_usuario_perfil b, tbl_perfil_encabezado c, tbl_perfil_detalle d WHERE a.PK_Usu_Codigo = " + usuarioCodigo + " AND b.FK_Usu_Codigo = a.PK_Usu_Codigo AND c.PK_perf_cod_encabezado = b.FK_perf_codigo AND d.FK_perf_cod_encabezado = c.PK_perf_cod_encabezado; ";

            string query = "select d.FK_Api_codigo as aplicacion, d.ingresar, d.editar, d.guardar, d.borrar,  d.consultar FROM tbl_usuario a, tbl_relacion_usuario_perfil b, tbl_perfil_encabezado c, tbl_perfil_detalle d WHERE b.FK_Usu_Codigo = " + usuarioCodigo + " AND c.PK_perf_cod_encabezado = b.FK_perf_codigo AND d.FK_perf_cod_encabezado = c.PK_perf_cod_encabezado; ";

            try
            {

                using (var conn = new OdbcConnection("dsn=dsnAuditoria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        List<Permiso> listaPermisos = new List<Permiso>();

                        if (!reader.HasRows)
                        {
                            //MessageBox.Show("No results");
                            //MessageBox.Show(query);

                        }


                        while (reader.Read())
                        {

                            Permiso permiso = new Permiso();
                            permiso.aplicacion = Convert.ToInt32(reader["aplicacion"]);
                            permiso.ingresar = Convert.ToBoolean(reader["ingresar"]);
                            permiso.editar = Convert.ToBoolean(reader["editar"]);
                            permiso.guardar = Convert.ToBoolean(reader["guardar"]);
                            permiso.borrar = Convert.ToBoolean(reader["borrar"]);
                            permiso.consultar = Convert.ToBoolean(reader["consultar"]);

                            listaPermisos.Add(permiso);
                            //respuesta = new List<Permiso>();



                        }

                        conn.Close();
                        respuesta = listaPermisos;
                    }

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());

            }

            return respuesta;
        }


        /*Programado por Victor Jimenez*/
        public List<string> obtenerRutas(int codigoAplicacion)
        {

            //CadenaDeConexion cadenaConexion = new CadenaDeConexion();
            List<string> respuesta = new List<string>();

            try
            {

                using (var conn = new OdbcConnection(/*cadenaConexion.Conexion()*/"dsn=dsnAuditoria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Ruta FROM tbl_doc_asociado WHERE aplicacion_api_codigo = " + codigoAplicacion + ";";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        List<string> listaRutas = new List<string>();



                        while (reader.Read())
                        {

                            string rutas = "";
                            rutas = Convert.ToString(reader["Ruta"]);
                            //Console.WriteLine(rutas.Ruta);

                            listaRutas.Add(rutas);
                            //respuesta = new List<Permiso>();



                        }

                        conn.Close();
                        /*string s = "";
                        Usuario us = new Usuario();
                        foreach (var elemento in listaRutas)
                        {
                            s += Convert.ToString(elemento) + "\n";
                        }
                        Console.WriteLine(s);*/
                        respuesta = listaRutas;
                    }

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());
            }

            return respuesta;
        }
        /*Programado por Victor Jimenez*/




        public Usuario obtenerObjUsuario(string usuario, string contrasena)
        {

            //CadenaDeConexion cadenaConexion = new CadenaDeConexion();

            try
            {
                Usuario user = new Usuario();
                using (var conn = new OdbcConnection(/*cadenaConexion.Conexion()*/"dsn=dsnAuditoria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();


                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tbl_usuario where usu_nickname='" + usuario + "' and usu_password='" + contrasena + "';";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {

                            return null;
                        }
                        else
                        {

                            while (reader.Read())
                            {

                                user.nickName = (reader["usu_nickname"].ToString());
                                user.codigoUsuario = Convert.ToInt32(reader["PK_Usu_Codigo"].ToString());
                            }
                        }


                        conn.Close();

                    }

                }

                if (user.nickName == "" && user.codigoUsuario == 0)
                {
                    return null;
                }
                else
                {
                }

                return user;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());
            }

            return null;
        }

        public int verUsuario(string usuario)
        {
            int cantidad = 0;
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select count(*) from bdauditoria.tbl_usuario where usu_nickname='" + usuario + "';";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {

                            cantidad = 0;
                        }
                        else
                        {

                            while (reader.Read())
                            {

                                cantidad = Int32.Parse(reader["count(*)"].ToString());
                            }
                        }
                        conn.Close();
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());
            }
            return cantidad;
        }

        public void nuevoUsuario(string usuario, string contrasena)
        {
            try
            {
                using (var conn = new OdbcConnection("dsn=dsnAuditoria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();
                    int id = 0;
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT MAX(PK_Usu_Codigo)+1 FROM bdauditoria.tbl_usuario;";
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {

                            id = 1;
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                id = Int32.Parse(reader["MAX(PK_Usu_Codigo)+1"].ToString());
                            }
                        }
                    }
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO `bdauditoria`.`tbl_usuario` VALUES ("+id+",'"+usuario+"','"+contrasena+"','1');";
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());
            }
        }

    }
}