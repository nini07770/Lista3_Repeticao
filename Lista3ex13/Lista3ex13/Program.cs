using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f;
            Console.WriteLine("QUAL NUMERO DESEJA FATORAR");
            f = Convert.ToDouble(Console.ReadLine());
            if (f < 0)
            {
                do
                {
                    Console.WriteLine("FORNEÇA UM NUMERO POSITIVO");
                    f = Convert.ToDouble(Console.ReadLine());
                } while (f < 0);
            }
            double cop = f;
            double fat;
            double mult = f - 1;
            double res = 0;
            do
            {
                fat = mult * f;
                if (fat > f)
                {
                    res = fat;
                    f = fat;
                }


                mult--;
            } while (mult > 1);

            Console.WriteLine("A FATORIAL DE {0} SERA {1}", cop, res);


            string perg;
            Console.WriteLine();
            Console.WriteLine("FAZER UMA NOVA EXECUÇÃO?");
            perg = Convert.ToString(Console.ReadLine());
            if (perg != "S" && perg != "N")
            {
                do
                {
                    Console.WriteLine("DIGITE S OU N");
                    perg = Convert.ToString(Console.ReadLine());
                } while (perg != "S" && perg != "N");
            }
        }
    }
}
