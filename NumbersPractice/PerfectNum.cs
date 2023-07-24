using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPractice
{
    internal class PerfectNum
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <num; i++)
            {
                if (num % i == 0)
                {
                    sum=sum+ i;
                }

            }
            if (sum == num)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not perfect number");
            }
        }
    }
}
