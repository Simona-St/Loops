using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int something = 1;

            for (int rows = 1; rows <= inputNumber; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write(something + " ");
                    something++;
                    if (something > inputNumber)
                    {
                        break;
                    }
                }
               Console.WriteLine();

                if (something > inputNumber)
                {
                    break;
                }


            }

        }
    }
}
