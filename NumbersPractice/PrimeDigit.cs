using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersPractice
{
    internal class PrimeDigit
    {

        static void Main(string[] args)
        {

            
         
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            
           
            while (num > 0)
            {
                int count = 0;
                int digit = num % 10;
                num = num / 10;
                for (int i = 2; i < digit; i++)
                {

                    if (digit % i == 0 && digit>1)
                    {
                        count = 1;
                        break;
                    }

                }
                //if (digit >1)
                //{
                 
                    if (count == 0)
                    {
                        Console.WriteLine(digit);
                    }
                //}
                

            }



        }
    }
}
