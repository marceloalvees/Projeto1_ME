using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace conversorDeMoedas
{
    internal class Euro
    {
       public float euroEmDolar(float valor)
        {
            float dolar = 1.05F;

            return (valor / dolar);
        }

        public float euroEmIene(float valor)
        {
            float iene = 142.08F;

            return (valor / iene);
        }


        public float euroEmReal(float valor)
        {
            float real = 5.51F;

            return (valor / real); ;
        }

        public float euroEmLibraEsterlina(float valor)
        {
            float libraesterlina = 0.86F;

            return (valor / libraesterlina);
        }
    }
}
