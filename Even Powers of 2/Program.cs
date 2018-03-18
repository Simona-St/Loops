using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int exponent = int.Parse(Console.ReadLine());
            int CurrentNumber = 1;

            for (int i = 0; i <= exponent; i+=2)
            {
                Console.WriteLine(CurrentNumber);
                CurrentNumber = CurrentNumber * 2*2; // 2*2 за да прескочим "нечетните" степени като 8, 32 и тн
            }
        }
            
        }
    }

