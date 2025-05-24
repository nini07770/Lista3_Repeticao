using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 10; i += 1)
            {
                Console.WriteLine("5 x {0} = {1}", i, 5 * i);
            }
        }
    }
}
