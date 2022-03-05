using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class PerfectNumber
    {
        public static void DisplayPerfectNumber()
        {
            int n, i, sum;
            int min, max;

           
            Console.WriteLine("Find perfect numbers within a given number of range");
            

            Console.WriteLine("Input the starting range or number : ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of number : ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Perfect numbers within the given range : ");
            for (n = min; n < max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
            
        }
    }
}
