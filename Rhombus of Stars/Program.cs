using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {


            int size = int.Parse(Console.ReadLine());
            int WhiteSpaces = size - 1; // броят на празните пространства
         

            // горна част 
            for (int row = 0; row < size; row++)
            {

                for (int cols = 0; cols < WhiteSpaces; cols++)
                {
                    Console.Write(' ');

                }
                

                Console.Write('*'); // една фиксирана звездичка

                for (int cols = 0; cols <= row - 1; cols++)
                {
                    Console.Write(" *");
                }
                WhiteSpaces--; // колкото повече увеличаваме редовете намаляме броя на тиренцата
                //  * се увеличават
                Console.WriteLine();
            }

            // долна част 

            int stars = size - 1; // имаме 1 ред по-малко
            WhiteSpaces = 1; // започва от 1 и нараства
            int botrows = stars; //броя на stars ще намалява, затова е нужно да въведем нова променлива

            for (int rows = 0; rows <botrows; rows++) // rows расте до size - 1
            {
                for (int col = 0; col < WhiteSpaces; col++)
                {
                    Console.Write(' ');
                }
                Console.Write('*'); // фиксирана звезда 

                for (int col = 0; col < stars - 1; col++)
                {
                    Console.Write(" *");
                }

                WhiteSpaces++;
                stars--;

                Console.WriteLine();


            }
        }

        }
    }
// решава се като ромбът се раздели на две части. 
//Всяка част се състои от цикъл за ред, в който има два вложени цикъла (за колони (за * и spaces))