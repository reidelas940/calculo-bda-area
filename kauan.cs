using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paulinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção, valor1, valor2, resultado;

            do
            {
                Console.WriteLine("Menu de Calculos");
                Console.WriteLine("Selecione uma das opções para calcular");
                Console.WriteLine("1-Calculolo dq média");
                Console.WriteLine("2-Calculolo da área");
                opção = Convert.ToInt32(Console.ReadLine());

                if (opção == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Insira os valores para calcular a média");
                        Console.WriteLine("insira o primeiro valor");
                        valor1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("insira o segundo valor ");
                        valor2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        resultado = valor1 + valor2 / 2;

                        
                        Console.ReadLine();
                        Console.WriteLine("resultado: " + resultado);
                        Console.ReadKey();

                    } while (opção != 0);
                }

              if (opção == 2)
                {
                    Console.WriteLine("Menu de Calculos");
                    Console.WriteLine("1-Triangulo");
                    Console.WriteLine("2-Quadrilátero");
                    Console.WriteLine("3-=Trapésio");
                }
            } while (opção != 2);
        }
    }
}
