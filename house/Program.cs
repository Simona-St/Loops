using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int CountOfStars = 1;
            int CountOfDashes = (n - CountOfStars);

            if (n % 2 == 0)
            { CountOfStars++; }


            for (int rows = 0; rows < (int)Math.Ceiling(n / 2f); rows++) //когато n е нечетно число, дължината на покрива е по-голяма с един ред от тази на основата
            {
                Console.Write(new string('-', CountOfDashes / 2) + new string('*', CountOfStars) + new string('-', CountOfDashes / 2));


                CountOfDashes -= 2;
                CountOfStars += 2;
                Console.WriteLine();

                //С всеки един ред по-надолу, звездите се увеличават с 2, а тиретата намаляват с 2.

            }


            for (int bottomrows = 0; bottomrows < n / 2; bottomrows++)
            {
                Console.Write('|' + new string('*', n - 2) + '|');
                Console.WriteLine();
            }



        }
    }
}
