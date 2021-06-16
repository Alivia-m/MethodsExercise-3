using System;

namespace IterationStatements.Exc3
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterSystem();
            Pause();

            SkipCounting();
            Pause();

            int userInput = GetUserInput();
            int userInput2 = GetUserInput();
            bool areEqual = EqualIntegers(userInput, userInput2);
            Console.WriteLine($"{userInput} is equal to {userInput2}: {areEqual}");
            Pause();

            EvenOrOdd(userInput);
            Pause();

            PositiveOrNegative(userInput2);
            Pause();

            Console.WriteLine("Please enter your age to see if you can vote");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            AgeChecker(age);
            Pause();

            int rangeInput = GetRangeInput();

            RangeMethod(rangeInput);
            Pause();

            int multiplyTo = GetRangeInput();
            MultiplyMethod(userInput, multiplyTo);

        }

        private static void MultiplyMethod(int userInput, int multiplyTo)
        {
            int product = 0;
            for (int i = 1; i <= multiplyTo; i++)
            {
                 product = userInput * i;
                Console.WriteLine($"{userInput} * {i} = {product}");
            }
        }

        private static int GetRangeInput()
        {
            Console.WriteLine("Give me a number");
            int rangeInput = int.Parse(Console.ReadLine());
            return rangeInput;
        }

        private static void RangeMethod(int rangeInput)
        {
           if (rangeInput >= -10 && rangeInput <= 10)
            {
                Console.WriteLine($"{rangeInput} is in range");
            }
           else
            {
                Console.WriteLine("Not in range");
            }
        }

        private static void AgeChecker(int age)
        {
           if (age >= 18)
            {
                Console.WriteLine("Looks like you can vote!");
            }
           else
            {
                Console.WriteLine("Looks like you're too young, sorry!");
            }
        }

        private static void PositiveOrNegative(int k)
        {
           if (k % 4 == 0)
            {
                Console.WriteLine($"{k} is positive");
            }
           else if (k % 4 != 0)
            {
                Console.WriteLine($"{k} is negative");
            }
        }

        private static void EvenOrOdd(int g)
        {
           if (g % 2 == 0)
            {
                Console.WriteLine($"{g} is even");
            }
           else if (g % 2 != 0)
            {
                Console.WriteLine($"{g} is odd");
            }
        }

        private static int GetUserInput()
        {
            Console.Write("Type in a number:");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }

        private static bool EqualIntegers(int x, int y)
        {
            return x == y;   
        }

        private static void SkipCounting()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static void CounterSystem()
        {
            for(int a = 1000; a >= -1000; a--)
            {
                Console.WriteLine(a);
            }
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        


    }
}
