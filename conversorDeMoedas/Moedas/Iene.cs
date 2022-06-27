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
        public static void menuIene(float valor)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine(
                "1. Dolar" + Environment.NewLine + "2. Real" + Environment.NewLine +
                "3. LibraEsterlina" + Environment.NewLine + "4. Euro");
            int opcao2 = int.Parse(Console.ReadLine());
            switch (opcao2)
            {

                //real (R$), dólar ($), euro (€), iene (¥) ou libra esterlina (£).
                case 1:
                    Console.WriteLine($"${IeneEmDolar(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 2:
                    Console.WriteLine($"R${IeneEmReal(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 3:
                    Console.WriteLine($"£{IeneEmLibraEsterlina(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 4:
                    Console.WriteLine($"€{IeneEmEuro(valor).ToString("F2")}" + Environment.NewLine);
                    break;
            }
        }


        static float IeneEmDolar(float valor)
        {
            float dolar = 0.0074F;

            return (valor / dolar);
        }

         static float IeneEmReal(float valor)
        {
            float real = 0.039F;

            return (valor / real);
        }


        static float IeneEmLibraEsterlina(float valor)
        {
            float libraEsterlina = 0.0060F;

            return (valor / libraEsterlina); ;
        }

        static float IeneEmEuro(float valor)
        {
            float euro = 0.0070F;

            return (valor / euro);
        }
    }
}
