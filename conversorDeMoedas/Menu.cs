using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace conversorDeMoedas
{ 
    internal class Menu
    {
        public void menu()
        {
            int opcao;
            do
            {
                Console.WriteLine("Qual a sua moeda?");
                Console.WriteLine("0. Sair" + Environment.NewLine + "1. Real" + Environment.NewLine +
                    "2. Dolar" + Environment.NewLine + "3. Iene" + Environment.NewLine +
                    "4. LibraEsterlina" + Environment.NewLine + "5. Euro");
                opcao = int.Parse(Console.ReadLine());
                if (opcao >= 6)
                {
                    Console.WriteLine("Opção invalida, tente novamente!");
                    menu();
                } else if(opcao == 0)
                {
                    Console.WriteLine("Você saiu do programa, see ya!!" + Environment.NewLine);
                    break;
                }
                Console.WriteLine("Qual o valor você deseja converter?");
                float valor = float.Parse(Console.ReadLine());

                switch (opcao)
                {
                    
                    case 1: 

                        Real.menuReal(valor);           
                        break;

                    case 2:
                        Dolar.menuDolar(valor));
                        break;

                    case 3:
                        Iene.menuIene(valor);
                        break;

                    case 4:
                        LibraEsterlina.menuLibraEsterlina(valor);
                        break;

                    case 5:
                        Euro.menuEuro(valor);
                        break;



                }

            }while (opcao != 0);
            
        }
        
    }
}
