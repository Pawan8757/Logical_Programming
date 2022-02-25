using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programing
{
    public class PerfectNumber
    {
        public static void FindThePerfectNumber()
        {
            int n, i, sum;
            int min, max;

            Console.WriteLine("Find the Perfect number within a given range");
            Console.WriteLine("............");
            Console.WriteLine("Input the starting range of number");
          
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of number");

            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Perfect number within a given range");

            for (n =min; n<= max; n++ )
            {
                i = 1;
                sum = 0;

                while(i<n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
        }
    }
}
