using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Permiso
    {

        public long aplicacion { get; set; }

        public bool ingresar { get; set; }

        public bool editar { get; set; }

        public bool guardar { get; set; }

        public bool borrar { get; set; }

        public bool buscar { get; set; }

        public bool consultar { get; set; }

        public bool imprimir { get; set; }

    }
}
