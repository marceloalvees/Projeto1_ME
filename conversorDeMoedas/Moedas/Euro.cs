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
        public static void menuEuro(float valor)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine(
                "1. Dolar" + Environment.NewLine + "2. Iene" + Environment.NewLine +
                "3. Real" + Environment.NewLine + "4. Libra Esterlina");

            int opcao2 = int.Parse(Console.ReadLine());

            switch (opcao2)
            {

                //real (R$), dólar ($), euro (€), iene (¥) ou libra esterlina (£).
                case 1:
                    Console.WriteLine($"${euroEmDolar(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 2:
                    Console.WriteLine($"¥{euroEmIene(valor).ToString("F3")}" + Environment.NewLine);
                    break;
                case 3:
                    Console.WriteLine($"R${euroEmReal(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 4:
                    Console.WriteLine($"£{euroEmLibraEsterlina(valor).ToString("F2")}" + Environment.NewLine);
                    break;
            }
        }


        static float euroEmDolar(float valor)
        {
            float dolar = 1.05F;

            return (valor / dolar);
        }

        static float euroEmIene(float valor)
        {
            float iene = 142.08F;

            return (valor / iene);
        }


        static float euroEmReal(float valor)
        {
            float real = 5.51F;

            return (valor / real); ;
        }

        static float euroEmLibraEsterlina(float valor)
        {
            float libraesterlina = 0.86F;

            return (valor / libraesterlina);
        }
    }
}
