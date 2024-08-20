class Program
{
    public static void Main(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("1.To Run the Program");
            Console.WriteLine("2.To Run the Program");
            Console.WriteLine("3.To Run the Program");
            Console.WriteLine("4.To Run the Program");
            Console.WriteLine("5.To Run the Program");

            string ch = Console.ReadLine().ToLower();



            switch (ch)
            {
                case "1":
                    Program1();
                    break;
                case "2":
                    Program2();
                    break;
                case "3":
                    Program3();
                    break;
                case "4":
                    Program4();
                    break;
                case "5":
                    Program5();
                    break;
                default:
                    Console.WriteLine("Invalid choise");
                    break;

            }


            if (continueRunning)
            {
                Console.WriteLine("\n Would you like to try again? (y/n)");
                string tryAgain = Console.ReadLine();
                if (tryAgain != "y")
                {
                    continueRunning = false;
                }
            }
        }
        Console.WriteLine("Exiting the program. Goodbye!");

    }


    static void Program1()
    {
        //Write a program that checks if a given number is prime

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


    static void Program2()
    {
        //Write a program that reverses a given string.
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            Console.WriteLine($"Reversed string: {reversedStr}");
        }

    }


    static void Program3()
    {
        //Write a program that calculates the factorial of a given number.
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {num} is {factorial}");
        }

    }
    static void Program4()
    {
        //Write a program that checks if a given string is a palindrome.
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string reversedStr = new string(str.Reverse().ToArray());

        if (str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine($"{str} is a palindrome.");
        else
            Console.WriteLine($"{str} is not a palindrome.");

    }
    static void Program5()
    {
        //Write a program that prints the Fibonacci sequence up to a specified number of terms.
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());
        int num1 = 0, num2 = 1, nextNum;

        Console.WriteLine("Fibonacci sequence:");
        for (int i = 1; i <= terms; ++i)
        {
            Console.Write($"{num1} ");
            nextNum = num1 + num2;
            num1 = num2;
            num2 = nextNum;
        }
    }
}
        
    
