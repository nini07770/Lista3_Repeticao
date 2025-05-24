using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            do
            {
                Console.Write("Digite um valor inteiro positivo: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                }
            } while (valor <= 0);

            Console.WriteLine("Tabuada do {0}: ", valor);
            for (int  i = 1;  i <= 10;  i++)
            {
                Console.WriteLine("{0} x {1} = {2}", valor, i, valor * i);
            }
        }
    }
}
