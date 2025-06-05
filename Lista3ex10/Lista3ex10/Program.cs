using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, soma = 0;
            double maior = double.MinValue;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                numero = Double.Parse(Console.ReadLine());
                soma = soma + numero;
                
                if (numero > maior) 
                {
                    maior = numero;
                }

            }
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Soma total: " + soma);
            Console.WriteLine("Média: " + (soma / 10));
            Console.ReadKey();
        }
    }
}
