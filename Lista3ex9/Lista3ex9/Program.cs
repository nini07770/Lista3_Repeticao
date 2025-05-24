using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1, n2 = 1, n3;

            Console.WriteLine("Os primeiros 30 números da série de Fibonacci: ");

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(n1);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine("FIM");
        }
    }
}
