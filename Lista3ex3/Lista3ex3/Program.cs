using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;

            do
            {
                Console.WriteLine("Digite o sexo (M ou F): ");
                sexo = Console.ReadLine().ToUpper();

                if (sexo != "M" && sexo != "F")
                {
                    Console.WriteLine("Sexo inválido. Por favor, digite M ou F.");
                }
            } while (sexo != "M" && sexo != "F");

            Console.WriteLine("Sexo aceito:{0} ", sexo);
        }
    }
}
