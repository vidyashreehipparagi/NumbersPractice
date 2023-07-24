using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPractice
{
    internal class PrimeNUmber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<=num; i++)
            {
                if (num % i == 0)
                {
                    sum++;
                }
            }
            if(sum == 2) {
                Console.WriteLine("Prime number");
            }
            else
            {

            }
        }
    }
}
