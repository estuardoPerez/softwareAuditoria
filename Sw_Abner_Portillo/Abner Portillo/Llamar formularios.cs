using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abner_Portillo
{
    public class Llamar_formularios
    {
        public void MOSTRARNORMATIVA()
        {
            Frm_normativa frm_Normativa = new Frm_normativa();
            frm_Normativa.Show();
        }

        public void MOSTRARDOMINIO()
        {
            Frm_dominio frm_Dominio = new Frm_dominio();
            frm_Dominio.Show();
        }

        public void MOSTRAROBJETIVO()
        {
            Frm_objetivo frm_Objetivo = new Frm_objetivo();
            frm_Objetivo.Show();
        }

    }
}
