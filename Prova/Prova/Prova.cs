using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    public class Prova
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("Número {0} é Divisivel por 2", i.ToString());
                }
                if ((i % 3) == 0)
                {

                    Console.WriteLine("Número {0} é Divisivel por 3", i.ToString());
                }

                if ((i % 2) != 0 && (i % 3) != 0)
                {

                    Console.WriteLine(i);
                }
                if ((i % 2) == 0 && (i % 3) == 0)
                {
                    Console.WriteLine("Número {0} é Divisivel por 2 e Divisivel por 3", i.ToString());
                }

            }


            Console.Read();
        }
    }
}
