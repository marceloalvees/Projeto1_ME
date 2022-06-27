using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace conversorDeMoedas
{
    internal class LibraEsterlina
    {
        public float libraEsterlinaEmDolar(float valor)
        {
            float dolar = 1.23F;

            return (valor * dolar);
        }

        public float libraEsterlinaEmIene(float valor)
        {
            float iene = 165.49F;

            return (valor * iene);
        }


        public float libraEsterlinaemreal(float valor)
        {
            float real = 6.41F;

            return (valor * real); ;
        }

        public float libraEsterlinaEmEuro(float valor)
        {
            float euro = 1.16F;

            return (valor * euro);
        }
    }
}
