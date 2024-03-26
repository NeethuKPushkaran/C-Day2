using System;

class Program
{
    static void Main()
    {
        //Prime Number

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }

        //Diamond Pattern

        Console.Write("Enter the number of rows (odd number): ");
        int numRows = Convert.ToInt32(Console.ReadLine());

        if (numRows % 2 == 0)
        {
            Console.WriteLine("Please enter an odd number of rows.");
        }
        else
        {
            PrintDiamondPattern(numRows);
        }
    }

    static bool IsPrime(int num)
    {
        // 0 and 1 are not prime numbers
        if (num < 2)
        {
            return false;
        }

        // Check for factors up to the square root of the number
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                // If the number is divisible by any other number, it's not prime
                return false;
            }
        }

        // If no factors were found, the number is prime
        return true;
    }

    static void PrintDiamondPattern(int rows)
    {
        int spaces = rows / 2;

        for (int i = 1; i <= rows; i += 2)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            spaces--;
        }

        spaces = 1;

        for (int i = rows - 2; i >= 1; i -= 2)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            spaces++;
        }
    }
}
