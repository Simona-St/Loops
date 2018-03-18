using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriel
{
    class Program
    {
        static void Main(string[] args)
        { // с for цикъл

            //int readNumber = int.Parse(Console.ReadLine());

            //int factorial = 1;

            //for (int CurrentMultiplier = 2; CurrentMultiplier <= readNumber; CurrentMultiplier++)
            //{
            //    factorial = factorial * CurrentMultiplier;
            //}
            //Console.WriteLine(factorial);

            // с do-while цикъл

            int  readNum= int.Parse(Console.ReadLine());
            int factorial = 1;  // променлива за изчисление и съхранение на факториела.

            do

            {factorial = factorial * readNum; //умножение на текущата стойност на fact с текущата стойност на n.
                readNum--;
                // всеки път, когато извършим изчисленията в тялото на цикъла,  намаляваме стойността на n с 1.
            } while (readNum > 1);

            Console.WriteLine(factorial);

        }
    }
}
