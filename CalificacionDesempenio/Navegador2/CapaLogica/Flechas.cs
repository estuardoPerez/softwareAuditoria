using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaLogicaNavegador
{
   public class Flechas
    {
        int contador = 1;
        static List<string> variables = new List<string>();
    public void movimiento(int flecha,DataGridView dataGr)
        {
            int columnas = dataGr.ColumnCount;
            int celdas = dataGr.Rows.Count;
            int contador2 = celdas - 2;

            if (flecha == 0) { contador = 0; }

            if (flecha == 1 && contador < contador2) { contador++; }

            if (flecha == 2 && contador >= 1) { contador--; }

            if (flecha == 3) { contador = contador2; }

            dataGr.Rows[contador].Selected = true;
            dataGr.CurrentCell = dataGr.Rows[contador].Cells[0];
            //string dato = dataGr.CurrentRow.Cells[0].Value.ToString();

            for (int j = 0; j < columnas; j++)
            {
                variables.Add(dataGr.CurrentRow.Cells[j].Value.ToString());
            }
        }
        public List<string> retornar()
        {

            return variables;
        }
    }
}
