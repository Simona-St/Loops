using System;


namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            while (y != 0) //Докато не достигнем остатък 0
            {
                int OldY = y;  //присвояваме стойността на y

                y = x % y; //Делим по-голямото число на по-малкото.
                x = OldY;
            }
            Console.WriteLine(x); // Вземаме остатъка от делението.
        }
    }
}
