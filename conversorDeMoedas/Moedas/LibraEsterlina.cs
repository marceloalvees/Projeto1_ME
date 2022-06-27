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
        public static void menuLibraEsterlina(float valor)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine(
                "1. Dolar" + Environment.NewLine + "2. Iene" + Environment.NewLine +
                "3. Real" + Environment.NewLine + "4. Euro");
            int opcao2 = int.Parse(Console.ReadLine());
            switch (opcao2)
            {

                //real (R$), dólar ($), euro (€), iene (¥) ou libra esterlina (£).
                case 1:
                    Console.WriteLine($"${libraEsterlinaEmDolar(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 2:
                    Console.WriteLine($"¥{libraEsterlinaEmIene(valor).ToString("F3")}" + Environment.NewLine);
                    break;
                case 3:
                    Console.WriteLine($"R${libraEsterlinaEmReal(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 4:
                    Console.WriteLine($"£{libraEsterlinaEmEuro(valor).ToString("F2")}" + Environment.NewLine);
                    break;
            }
        }

        static float libraEsterlinaEmDolar(float valor)
        {
            float dolar = 1.23F;

            return (valor / dolar);
        }

        static float libraEsterlinaEmIene(float valor)
        {
            float iene = 165.49F;

            return (valor / iene);
        }


        static float libraEsterlinaEmReal(float valor)
        {
            float real = 6.41F;

            return (valor / real); ;
        }

        static float libraEsterlinaEmEuro(float valor)
        {
            float euro = 1.16F;

            return (valor / euro);
        }
    }
}
