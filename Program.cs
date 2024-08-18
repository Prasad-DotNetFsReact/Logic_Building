using System;
using System.ComponentModel;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Run Program 1");
            Console.WriteLine("2. Run Program 2");
            Console.WriteLine("3. Run Program 3");
            Console.WriteLine("4. Run Program 4");
            Console.WriteLine("5. Run Program 5");
            Console.WriteLine("6. Run Program 8");
            Console.WriteLine("7. Run Program 7");
            Console.WriteLine("8. Run Program 8");
            Console.WriteLine("9. Run Program 9");
            Console.WriteLine("10. Run Program 10");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunProgram1();
                    break;
                case "2":
                    RunProgram2();
                    break;
                case "3":
                    RunProgram3();
                    break;
                case "4":
                    RunProgram4();
                    break;
                case "5":
                    RunProgram5();
                    break;
                case "6":
                    RunProgram6();
                    break;
                case "7":
                    RunProgram7();
                    break;
                case "8":
                    RunProgram8();
                    break;
                case "9":
                    RunProgram9();
                    break;
                case "10":
                    RunProgram10();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        static void RunProgram1()
        {
            Console.WriteLine("Hello World!");
        }

        static void RunProgram2()
        {
            Console.WriteLine("Addition");

            Console.WriteLine("num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num2");
            int num2 = Convert.ToInt32(Console.ReadLine());


            int result = num1 + num2;

            Console.WriteLine($"the addition of {num1} & {num2} is {result}");
        }

        static void RunProgram3()
        {
            //Problem: Write a program to find the largest of three numbers entered by the user.
            Console.WriteLine("Enter 3 Number to find largest one");

            Console.WriteLine("num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int result = (num1>num2) ? ((num1>num3) ? num1:num3): ((num2 > num3) ? num2 : num3);

                Console.WriteLine(result);

        }

        static void RunProgram4()
        {
            //Write a program to check whether a number is even or odd
            Console.WriteLine("Identify Even or Odd");

            Console.WriteLine("Enter Num");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("This is even Number");
            }
            else {
                Console.WriteLine("This is Odd Number");
            }

        }

        static void RunProgram5()
        {
            Console.WriteLine("Enter num to find the factorial number");

            Console.WriteLine("Enter Num");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"factorial of {num} is {factorial}");

        }
        static void RunProgram6() {
            //Problem: Write a program to swap the values of two variables without using a third variable.

            Console.WriteLine("Enter first num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num2 =  num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping First num: " + num1);
            Console.WriteLine("After Swapping Second num: " + num2);
        }
        static void RunProgram7() {
            //Write a program to check whether a number is prime or not
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine(num + " is a prime number.");
            else
                Console.WriteLine(num + " is not a prime number.");
        }
        static void RunProgram8() {
            // Write a program to reverse the digits of a number
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            Console.WriteLine("Reversed number: " + reversed);
        }

        static void RunProgram9()
        {
            //Write a program to generate the Fibonacci series up to a given number of terms
            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.WriteLine("Fibonacci Series:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
        }
        static void RunProgram10() {
            // Write a program to calculate the sum of the digits of a number
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
        }

    }
}

