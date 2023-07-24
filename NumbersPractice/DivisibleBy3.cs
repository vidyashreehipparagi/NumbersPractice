using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPractice
{
    internal class DivisibleBy3
    {
        static void Main(string[] args)
        {
            //divisible by 3
            Console.WriteLine("Enter number");
          int num=Convert.ToInt32(Console.ReadLine());
            int num1;
            while (num > 0)
            {
                num1 = num % 10;
                if (num1%3==0)
                {
                    Console.WriteLine(num1);
                }
                num = num / 10;
               
            }
            
        }
    }
}
