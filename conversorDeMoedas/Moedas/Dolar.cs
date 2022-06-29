using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace conversorDeMoedas
{
    internal class Dolar
    {


          public static void menuDolar(float valor)
        {
            Console.WriteLine("Para qual moeda você deseja converter?");
            Console.WriteLine(
                "1. Euro" + Environment.NewLine + "2. Iene" + Environment.NewLine +
                "3. Real" + Environment.NewLine + "4. Libra Esterlina");

            int opcao2 = int.Parse(Console.ReadLine());

            switch (opcao2)
            {

                //real (R$), dólar ($), euro (€), iene (¥) ou libra esterlina (£).
                case 1:
                    Console.WriteLine($"€{dolarEmEuro(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 2:
                    Console.WriteLine($"¥{dolarEmIene(valor).ToString("F3")}" + Environment.NewLine);
                    break;
                case 3:
                    Console.WriteLine($"R${dolarEmReal(valor).ToString("F2")}" + Environment.NewLine);
                    break;
                case 4:
                    Console.WriteLine($"£{dolarEmLibraEsterlina(valor).ToString("F2")}" + Environment.NewLine);
                    break;
            }
            
            static float dolarEmReal(float valor)
            {
                float real = 5,23;

                return (valor / real);
            }

            static float dolarEmIene(float valor)
            {
                float iene = 134,98;

                return (valor / iene);
            }

            static float dolarEmLibraEsterlina(float valor)
            {
                float libraEsterlina = 0,82;

                return (valor / libraEsterlina);
            }

            static float dolarEmEuro(float valor)
            {
                float euro = 0,95;

                return (valor / euro);
            }
          }
    }
   
}
