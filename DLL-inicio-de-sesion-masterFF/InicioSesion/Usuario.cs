using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogicaInicioSesion;
using CapaDatos;
using System.Windows.Forms;

namespace InicioSesion
{
    public class Usuario
    {

        public void guardarCodigoApp(string codigo)
        {
            Logica capaLogica = new Logica();
            capaLogica.guardarCodigoAplicacion(codigo);
        }


        public string obtenerUsuario()
        {
            Logica capaLogica = new Logica();
            return capaLogica.obtenerUsuario();
        }

        public int obtenerCodigoUsuario()
        {
            Logica capaLogica = new Logica();
            return Convert.ToInt32(capaLogica.obtenerCodigoUsuario());
        }

        public int obtenerCodigoAplicacion()
        {
            Logica capaLogica = new Logica();
            return Convert.ToInt32(capaLogica.obtenerCodigoAplicacion());
        }

        public Permiso obtenerPermisos(int usuarioCodigo, int codigo_aplicacion)
        {
            Logica capaLogica = new Logica();
            return capaLogica.obtenerPermisos(usuarioCodigo, codigo_aplicacion);
        }

        public List<Permiso> obtenerPermisosList(int usuarioCodigo, int codigo_aplicacion)
        {
            Logica capaLogica = new Logica();
            return capaLogica.obtenerPermisosList(usuarioCodigo, codigo_aplicacion);
        }

        public List<string> obtenerRutasList(int api_codigo)
        {
            Logica cl = new Logica();
            return cl.obtenerRutasList(api_codigo);
        }

    }
}
