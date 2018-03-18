using System;
//Да се въведе цяло число в диапазона [1 … 100]. Ако въведеното число е невалидно, да се въведе отново.
//В случая, за невалидно число ще считаме всяко такова, което не е в зададения диапазон.+



namespace numInRange1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            int Readnum = int.Parse(Console.ReadLine());

            while (Readnum < 1 || Readnum > 100)

            {
                Console.WriteLine("Invalid number!");
                Readnum = int.Parse(Console.ReadLine()); // присвояваме нова стойност за Readnum от входа на конзолата
            }
            Console.WriteLine("The number is: {0}", Readnum);

        }
    }
}
