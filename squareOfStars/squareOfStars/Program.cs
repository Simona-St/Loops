using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)

            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
