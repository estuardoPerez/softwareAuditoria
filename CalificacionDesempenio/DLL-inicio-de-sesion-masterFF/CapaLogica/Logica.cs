
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogicaInicioSesion
{
    public class Logica
    {

        public bool login(string usuario, string contrasena)
        {
            Datos capaDatos = new Datos();
            Usuario usuarioObt = capaDatos.obtenerObjUsuario(usuario, contrasena);
            string startupPath = Environment.CurrentDirectory;
            string x = "";
            string[] lines = { x,x,x };
            System.IO.File.WriteAllLines(startupPath + "/user.dll", lines);


            if (usuarioObt != null)
            {

                string[]  linesFound = { usuarioObt.nickName, usuarioObt.codigoUsuario.ToString()};

                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.  You do NOT need to call Flush() or Close().
                System.IO.File.WriteAllLines(startupPath + "/user.dll", linesFound );
                
                return true;
            }
            else{
                
            }
            


            //if (inicioSesion)
            //{
            //    List<Permiso>  lista = capaDatos.obtenerPermisos(1);
            //    Usuario.permisosUsuario = lista;              
            //}

            return false;

        }

        public void guardarCodigoAplicacion(string codigo)
        {
            string startupPath = Environment.CurrentDirectory;
            string x = "";
            string[] lines = { x };
            System.IO.File.WriteAllLines(startupPath + "/codigo_aplicacion.dll", lines);


  

                string[] linesFound = { codigo };

                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.  You do NOT need to call Flush() or Close().
                System.IO.File.WriteAllLines(startupPath + "/codigo_aplicacion.dll", linesFound);

    
        }

        public string obtenerCodigoAplicacion()
        {
            string startupPath = Environment.CurrentDirectory;
            string[] lines = System.IO.File.ReadAllLines(startupPath + "/codigo_aplicacion.dll");
            return lines[0];
        }

        public string obtenerUsuario()
        {
            string startupPath = Environment.CurrentDirectory;
            string[] lines = System.IO.File.ReadAllLines(startupPath + "/user.dll");
            return lines[0];
        }

        public string obtenerCodigoUsuario()
        {
            string startupPath = Environment.CurrentDirectory;
            string[] lines = System.IO.File.ReadAllLines(startupPath + "/user.dll");

            return lines[1];
        }

        public Permiso obtenerPermisos(int usuarioCodigo, int app_codigo)
        {
            bool flag = false;
            Datos capaDatos = new Datos();
            List<Permiso> permisos = capaDatos.obtenerPermisos(usuarioCodigo);   

            foreach (Permiso permiso in permisos)
            {
                if (permiso.aplicacion == app_codigo)
                {
                    return permiso;
                }
            }
            if(flag == false)
            {
                return null;
            }
            return null;
        }

        public List<Permiso> obtenerPermisosList(int usuarioCodigo, int app_codigo)
        {
            Datos capaDatos = new Datos();
            return capaDatos.obtenerPermisos(usuarioCodigo);

        }

        public List<string> obtenerRutasList(int api_codigo)
        {
            Datos capaDatos = new Datos();
            return capaDatos.obtenerRutas(api_codigo);
        }

        public bool existUser(string usuario)
        {
            Datos capaDatos = new Datos();
            int cant = capaDatos.verUsuario(usuario);
            if(cant == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void newUsuario(string usuario, string contrasena)
        {
            Datos capaDatos = new Datos();
            capaDatos.nuevoUsuario(usuario, contrasena);
        }
    }
}
