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
        public static void menuReal(float valor)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine(
                "1. Dolar" + Environment.NewLine + "2. Iene" + Environment.NewLine +
                "3. LibraEsterlina" + Environment.NewLine + "4. Euro");
            int opcao2 = int.Parse(Console.ReadLine());
            switch (opcao2)
            {

                //real (R$), dólar ($), euro (€), iene (¥) ou libra esterlina (£).
                case 1:
                    Console.WriteLine($"${realEmDolar(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 2:
                    Console.WriteLine($"¥{realEmIene(valor).ToString("F3")}" + Environment.NewLine);
                    break ;
                case 3:
                    Console.WriteLine($"£{realEmLibraEsterlina(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 4:
                    Console.WriteLine($"€{ realEmEuro(valor).ToString("F2")}" + Environment.NewLine);
                    break;
            }


        }
        public static float realEmDolar(float valor)
        {
            float dolar = 4.50F;

            return (valor / dolar);
        }

        public static float realEmIene(float valor)
        {
            float iene = 0.052F;

            return (valor / iene);
        }


        public static float realEmLibraEsterlina(float valor)
        {
            float libraEsterlina = 6.95F;

            return (valor / libraEsterlina); ;
        }

        public static float realEmEuro(float valor)
        {
            float euro = 6.20F;

            return (valor / euro);
        }

    }
}
