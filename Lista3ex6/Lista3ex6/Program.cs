using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;

            do
            {
                Console.Write("Digite o valor de x (positivo): ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    Console.WriteLine("Valor inválido. Digite um número inteiro positivo: ");
                }

            } while (x <= 0);

            Console.Write("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());

            while (a < 0)
            {
                Console.Write("Valor inválido. Digite um número inteiro positivo: ");
                a = int.Parse(Console.ReadLine());
            }
            do {    Console.Write("Digite o valor de b: ");
                b = int.Parse(Console.ReadLine());
                if (b <= a)
                {
                    Console.WriteLine("Valor inválido. Digite um número inteiro positivo: ");
                }
            } while (b <= a);

            Console.WriteLine("Tabuada do {0} do intervalo de {1} até {2}: ", x, b, a);
            for (int i = b; i >= a; i--)
            {
                Console.WriteLine("{0} x {1} = {2}", x, i, x * i);
            }
        }
    }
}

