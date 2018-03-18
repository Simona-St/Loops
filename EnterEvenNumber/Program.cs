using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           

            while (true)

            {
                Console.WriteLine("Enter even number: ");
                int ReadNumber = int.Parse(Console.ReadLine());
                

                if (ReadNumber % 2 == 0) 
                   
                    {
                    Console.WriteLine("Even number entered: {0}", ReadNumber); //Ако числото е четно, излизаме от цикъла чрез break.
                    break;
                }
                Console.WriteLine("The number is not even.");
                // Итерациите продължават, докато не се въведе четно число.
            }

           
        }
    }
}
