using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace conversorDeMoedas
{
    internal class Iene
    {
        public float IeneEmDolar(float valor)
        {
            float dolar = 0.0074F;

            return (valor * dolar);
        }

        public float IeneEmReal(float valor)
        {
            float real = 0.039F;

            return (valor * real);
        }


        public float IeneEmLibraEsterlina(float valor)
        {
            float libraEsterlina = 0.0060F;

            return (valor * libraEsterlina); ;
        }

        public float IeneEmEuro(float valor)
        {
            float euro = 0.0070F;

            return (valor * euro);
        }
    }
}
