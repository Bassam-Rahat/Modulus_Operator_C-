using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value: ");
            int number = int.Parse(Console.ReadLine());

            checkPrimeCase(number);
            Console.ReadLine();
        }

        public static void checkPrimeCase(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if(number % 5 == 0 )
            {
                Console.WriteLine("buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else
            {
                Console.WriteLine("None of the condititon satisfies");
            }
        }
    }
}
