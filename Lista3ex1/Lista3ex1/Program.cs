using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Digite um valor positivo: ");
            valor = double.Parse(Console.ReadLine());

            while (valor <= 0)
            {
                Console.Write("Valor inválido. Digite um valor positivo: ");
                valor = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("O valor digitado foi: {0} ", valor );
        }       
          
    }
}
