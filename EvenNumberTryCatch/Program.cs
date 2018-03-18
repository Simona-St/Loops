using System;

namespace EvenNumberTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Въвеждането на променливи и if-a влизат в try {}
            //catch  се пише след проверките и съобщенията за четно/ нечетно число
            while (true)

            {
                try
                {
                    Console.WriteLine("Enter even number: ");
                    int ReadNumber = int.Parse(Console.ReadLine());
                    if (ReadNumber % 2 == 0)

                    {
                        Console.WriteLine("Even number entered: {0}", ReadNumber); //Ако числото е четно, излизаме от цикъла чрез break.
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }


                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            // Итерациите продължават, докато не се въведе четно число.



        }
    }
}

