using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int F0 = 1;
             int F1 = 1;

            for (int i = 0; i < n-1 ; i++)
            { 
               int sum = F0 + F1;
             
                F0 = F1;
                F1 = sum;
               
                Console.WriteLine(F1);

                if (i >= n)
                {   
                    break;
                }
                
            }
           
        }
    }
}
