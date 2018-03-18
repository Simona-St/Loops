using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

// top 



            Console.Write('+');
            for (int cols = 0; cols < n-2; cols++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

         //body

            for (int rows = 0; rows < n-2; rows++)    // цикъл за брой на редовете n - 2
            {
                Console.Write("|");
                for (int dashes = 0; dashes < n-2; dashes++) //  цикъл за брой на тиретата n -2 
                {
Console.Write(" -");
                } 
                                
                Console.Write(" |");
                Console.WriteLine();
            }



            //bottom

            Console.Write('+');
            for (int cols = 0; cols < n-2; cols++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
