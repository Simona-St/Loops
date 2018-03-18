using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write('$');

                for (int col = 1; col < row; col++) //изпринтирай ред - 1
                {

                    Console.Write(" $");

                }
                Console.WriteLine();
            }
        }
    }
}
