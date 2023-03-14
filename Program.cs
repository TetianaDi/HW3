using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to check two given integers and return true if one is negative and one is positive.
            //Sample Output:
            // Input first integer:
            // -5
            //Input second integer:
            // 25
            //Check if one is negative and one is positive:
            //True


            Console.WriteLine($"Input negative number");
            var firstInput = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input positive number");
            var secondInput = int.Parse(Console.ReadLine());

            if (firstInput < 0 && secondInput >= 0)
            {
                Console.WriteLine($"True");
            }
            else
            {
                Console.WriteLine($"Try again");
            }


            //__________________________
            //-Write a C# program to check the sum of the two given integers and return true
            //if one of the integer is 20 or if their sum is 20.


            Console.WriteLine($"Input first number");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input second number");
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber + secondNumber == 20 || firstNumber == 20 || secondNumber == 20)
            {
                Console.WriteLine($"Check passed");
            }
            else
            {
                Console.WriteLine($"Check not passed");
                //  }

                //_______________________________
                //- Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.


                for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


            //_________
            //-Write a C# program to compute the sum of the first 500 prime numbers.
            //Sample Output:
            // Sum of the first 500 prime numbers:
            // 824693


            int sum = 0;
            for (int a = 1; a <= 500; a++)
            {
                {
                    sum += a;
                    Console.WriteLine(sum);
                }
            }

            /// I don't know how to show only the sum (((


            //_____________
            //-Write a C# program and compute the sum of the digits of an integer.
            // Sample Output:
            // Input a number(integer): 12(string.Length)
            // Sum of the digits of the said integer: 3


            string num;
            Console.WriteLine("Input a number(integer):");

            num = Console.ReadLine();
            int count, sumDigits = 0;
            int n = num.Length;

            for (count = 0; count < n; count++)
                if ((num[count] >= '0') && (num[count] <='9'))
            {
                    sum += (num[count] - '0');
            }
            Console.WriteLine("Sum of the digits of the said integer:" +sumDigits);

            // Honestly,  I found this solution in Google :-)


        }

    }
    }

