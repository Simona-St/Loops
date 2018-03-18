using System; 

//Да се провери дали едно число n е просто
//едно цяло число е просто, ако се дели без остатък единствено на себе си и на 1.
//Можем да приемем, че цяло число n е просто, ако n > 1 и n не се дели на число между 2 и n-1.
//Първите няколко прости числа са: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, …+


namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
       
        { 
            //Можем и да проверим дали n се дели на числата между 2 и √n.

            var readnumber = int.Parse(Console.ReadLine());
            if (readnumber <= 1)
            {
                Console.WriteLine("Not Prime");
                return;
            }

            bool prime = true;
            for (int i = 2; i <= readnumber -1; i++)
            {
                if (readnumber % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            string result = prime ? "Prime" : "Not Prime";
            Console.WriteLine(result);
        }
    }
}
