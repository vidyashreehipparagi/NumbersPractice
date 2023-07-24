using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPractice
{
    internal class firstandLastSum
    {
        static void Main(string[] args)
        {
            //num=6732 
            //6+2=8
            ////
            int num, sum = 0, firstDigit, lastDigit;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            lastDigit = num % 10;
            firstDigit = num;
            while (num > 10)
            {
                num = num / 10;
            }
            firstDigit = num;

            sum = firstDigit + lastDigit;
            Console.WriteLine("Sum= " + sum);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter number2");
            int n = Convert.ToInt32(Console.ReadLine());
            int last = n % 10;
            int sum1 = 0;
            int first = 0;
            while (n > 0)
            {
                first = n% 10;
                n=n/10;

            }
            sum1=first + last;
            Console.WriteLine("sum= "+sum1);

        }
    }
}
