using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void Numbers()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Bythree()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void Compare()
        {
            Console.WriteLine("do these two numbers equal eachother");
            Console.WriteLine("pick 1st number");
            var num1 = Console.ReadLine();
            Console.WriteLine("pick 2nd number");
            var num2 = Console.ReadLine();

            if (num1 == num2)
            {
                Console.WriteLine("they do!");            
            }
            else
            {
                Console.WriteLine("nah they dont");
            }
        }
        public static void OddOrEven()
        {
            Console.WriteLine("I can tell if your number is even!");
            Console.WriteLine("pick a number, any number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(" your number is Even");
            }
            else
            {
                Console.WriteLine("your number is Odd");
            }

        }
        public static void Age()
        {
            Console.WriteLine("Should you be voting? whats your age?");
            int enterage = int.Parse(Console.ReadLine());
            int Legalage = 18;
            if (enterage > Legalage)
            {
                Console.WriteLine("Awesome you can vote!");
            }
            else
            {
                Console.WriteLine("Wait just a little longer!");
            }


        }


    }
}

