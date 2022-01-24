using System;


namespace ExploreBranchesAndLoops
{
    class BLDemo
    {
        // Make decisions using the if statement

        public static void IFDemo()
        {
            int a = 5;
            int b = 6;
            Console.WriteLine("\n||  Make decisions using the if statement  ||");
            if (a + b > 10)
                Console.WriteLine("\nThe answer is greater than 10.");
        }

        // Make if and else work together

        public static void IfElseDemo()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            Console.WriteLine("\n||    Make if and else work together  ||");
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("\nThe answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("\nThe answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("\nThe answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("\nThe answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        // Use loops to repeat operations

        public static void WhileAndDoLoopDemo()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello .NET!! Using While Loop The counter is {counter}");
                counter++;
            }
            Console.WriteLine("\n");
            counter = 0;
            do
            {
                Console.WriteLine($"Hello World!! Using DoWhile Loop The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        // Work with the for loop

        public static void ForLoosDemo()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World@! Using For Loop , The counter is {counter}");
            }
            Console.WriteLine("\n");
        }

        // Created nested loops

        public static void NestedLoopDemo()
        {
            Console.WriteLine("||     Nested loop implementation    ||\n");
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        public static void Conclusion()
        {
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}