using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOFStars2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {


                for (int row = 0; row < 4; row++)
                {


                    for (int col = 0; col < 4; col++)
                    {
                        Console.Write("$ "); // а не WriteLine!!!
                    }
                    // принтираме доларче и празно пространство

                    Console.WriteLine(); // за да смени реда
                }
            }
        }
    }
}

