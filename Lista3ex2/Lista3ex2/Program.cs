using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2;

            Console.Write("Digite o primeiro valor: ");
            valor1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor (maior que o primeiro): ");
            valor2 = Double.Parse(Console.ReadLine());

            while (valor2 <= valor1)
            {
                Console.WriteLine("O segundo valor deve ser maior que o primeiro. ");
                Console.Write("Digite o segundo valor (maior que o primeiro): ");
                valor2 = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os valores digitados foram:{0} e {1}", valor1, valor2);
        }
    }
}
