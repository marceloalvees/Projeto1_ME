using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace conversorDeMoedas
{
    internal class Real 
    {
        public float realEmDolar(float valor)
        {
            float dolar = 4.50F;

            return (valor / dolar);
        }

        public float realEmIene(float valor)
        {
            float iene = 0.052F;

            return (valor / iene);
        }


        public float realEmLibraEsterlina(float valor)
        {
            float libraEsterlina = 6.95F;

            return (valor / libraEsterlina); ;
        }

        public float realEmEuro(float valor)
        {
            float euro = 6.20F;

            return (valor / euro);
        }

    }
}
