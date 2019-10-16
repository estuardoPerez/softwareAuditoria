using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Usuario
    {

        public  int codigoUsuario { get; set; }

        public  string nickName { get; set; }

        public static List<Permiso> permisosUsuario = new List<Permiso>();

    }
}
