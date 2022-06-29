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
                    "1. Real" + Environment.NewLine +
                    "2. Dolar" + Environment.NewLine + "3. Iene" + Environment.NewLine +
                    "4. LibraEsterlina" + Environment.NewLine + "5. Euro");
            int opcao2 = int.Parse(Console.ReadLine());
            switch (opcao2)
            {

                //real (R$), dólar ($), euro (€), iene (¥) ou libra esterlina (£).
                case 1:
                    Console.WriteLine($" ${retornoReal(valor).ToString("F2", CultureInfo.InvariantCulture)}" + Environment.NewLine);
                    break;
                case 2:
                    Console.WriteLine($" ${realEmDolar(valor).ToString("F2", CultureInfo.InvariantCulture)}" + Environment.NewLine);
                    break;
                case 3:
                    Console.WriteLine($" ¥{realEmIene(valor).ToString("F3", CultureInfo.InvariantCulture)}" + Environment.NewLine);
                    break;
                case 4:
                    Console.WriteLine($" £{realEmLibraEsterlina(valor).ToString("F2", CultureInfo.InvariantCulture)}" + Environment.NewLine);
                    break;
                case 5:
                    Console.WriteLine($" €{realEmEuro(valor).ToString("F2", CultureInfo.InvariantCulture)}" + Environment.NewLine);
                    break;
            }


        }
       
        public static float retornoReal(float valor)
        {
            return valor;
        }
        public static float realEmDolar(float valor)
        {
            float dolar = 0.19F;

            return (valor * dolar);
        }

        public static float realEmIene(float valor)
        {
            float iene = 26.35F;

            return (valor * iene);
        }


        public static float realEmLibraEsterlina(float valor)
        {
            float libraEsterlina = 0.16F;

            return (valor * libraEsterlina); ;
        }

        public static float realEmEuro(float valor)
        {
            float euro = 0.18F;

            return (valor * euro);
        }

    }
}
