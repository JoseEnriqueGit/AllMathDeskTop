using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GraficasPastel
    {
        public int Angulo(int Frecuencia, int SumaFrecuencia)
        {
            return 360 * Frecuencia / SumaFrecuencia;
        }
    }
}
