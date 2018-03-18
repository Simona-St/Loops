using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cycle
{
    class Program
    {
        static void Main(string[] args)

        {
            var StartTime = DateTime.Now;

            for (int i = 1; i <= 100000; i++)
            { }

                var EndTime = DateTime.Now;

                Console.WriteLine(EndTime - StartTime);

           
                    }
    }
}
