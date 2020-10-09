
using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Assignment2Cs
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.Write("Enter a number between 0 and 255: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0 || num1 > 255)

                {
                    throw new OverflowException("The number you entered is either lower than 0 or superior to 255, please enter a number between 0 and 255");

                }

                Console.Write("Enter another number between 0 and 255: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < 0 || num2 > 255)
                {
                    throw new OverflowException("The number you entered is either lower than 0 or superior to 255, please enter a number between 0 and 255");
                }
                else
                {

                    double result = 0.0;
                    result = num1 / num2;

                    Console.WriteLine("The result is: " + result);
                }

            }

            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }


    }

}
