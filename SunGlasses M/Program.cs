using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses_M
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            // рамка - горна част

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();

            // стъкла

            for (int rows = 0; rows < n - 2; rows++)

            {
                Console.Write('*' + new string('/', 2 * n - 2) + '*');
                if (rows == (n - 1) / 2 - 1) //да проверим дали редът е (n-1) / 2 - 1

                {
                    Console.Write(new string('|', n));
                }

                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write('*' + new string('/', 2 * n - 2) + '*');

                Console.WriteLine();
            }
            

            //Console.Write('*' + new string('/', 2 * n - 2) + '*');


            // рамка - долна част

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();

        }
    }
}


