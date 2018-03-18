using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10x10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            

            for (int row = 0; row < rows; row++)
            {
                

                for (int col = 0; col < rows; col++)
                {
                    Console.Write('*');
                }

                Console.WriteLine(); //извън цикъл 2, но в цикъл 1
            }
        }
    }
}
