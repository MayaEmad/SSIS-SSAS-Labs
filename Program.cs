using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*String Input = "what is your favourite color?";

            Console.WriteLine(Input);
            string color = Console.ReadLine();
            Console.WriteLine("oh "+ color + " is a great color");*/

            // take from user 5 numbers and print max and min numbers
            int max = 0;
            int min = 0;
            string input = "Please write your 5 numbers";

          /*  Console.WriteLine(input);
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int number5 = int.Parse(Console.ReadLine());
            /*  if ((number1 > number2) && (number1 > number3) && (number1 > number4) && (number1 > number5))
              {
                  number1 = max;


              }
              else if ((number2 > number1) && (number2 > number3) && (number2 > number4) && (number2 > number5))
              {
                  number2 = max;
              }
              else if ((number3 > number2) && (number3 > number1) && (number3 > number4) && (number3 > number5))
              {
                  number3 = max;
              }
              else if ((number4 > number2) && (number4 > number3) && (number4 > number5) && (number4 > number1))
              {
                  number4 = max;
              }
              else
              {
                  number5 = max;
              }*/


          /*  if ((number5 < number1) && (number5 < number4) && (number5 < number3) && (number5 < number2))
            {
                number5 = min;
            }
            else if ((number4 < number1) && (number4 < number5) && (number4 < number3) && (number4 < number2))
            {
                number4 = min;
            }
            else if ((number3 < number1) && (number3 < number5) && (number3 < number4) && (number3 < number2))
            {
                number3 = min;
            }
            else if ((number2 < number1) && (number2 < number5) && (number2 < number3) && (number2 < number4))
            {
                number2 = min;
            }
            else if ((number1 < number4) && (number1 < number5) && (number1 < number3) && (number1 < number2))
            {
                number1 = min;
            }*/

            /* max = Math.Max(number1, Math.Max(number2, Math.Max(number3, Math.Max(number4, number5))));
             min = Math.Min(number1, Math.Min(number2, Math.Min(number3, Math.Min(number4, number5))));
            Console.WriteLine($"The max number is {max} and The min number is {min}");
            */



            //question 2
            string input2 = "Please write your 3 coeffecient in ax^2 +bx +c";
            Console.WriteLine(input2);
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (((b * b) - 4 * a * c) == 0)
            {
                Console.WriteLine("The discriminant is zero.");
            }
            else if (((b * b) - 4 * a * c) > 0)
            {
                Console.WriteLine("The discriminant is complex.");

            }
            else if (((b * b) - 4 * a * c) < 0)
            {
                Console.WriteLine("The discriminant is real number.");

            }
        }
    }
}
