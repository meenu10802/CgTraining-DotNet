using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.ControlFlow.Level1
{
    public class Level1
    {
        //TO DO add empty line after each questions for better readibility
        public static void CheckDivisibleByFive() 
        {
            Console.Write("Finding if the number is divisble by 3 or 5"); // TO DO make more readble by specifying what the user should do
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isDivisibleByFive = num % 5 == 0;
            Console.WriteLine("Is the number " + num + " divisible by 5? " + isDivisibleByFive);
        }

        public static void CheckSmallest()
        {
            Console.Write("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            bool isSmallest = num1 < num2 && num1 < num3;
            Console.WriteLine("Is the first number " + num1 + " the smallest? " + isSmallest);
        }

        public static void CheckLargest()
        {
            Console.Write("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            bool isLargestNum1 = num1 > num2 && num1 > num3;
            bool isLargestNum2 = num2 > num1 && num2 > num3;
            bool isLargestNum3 = num3 > num1 && num3 > num2;

            Console.WriteLine("Is the first number " + num1 + " the largest? " + isLargestNum1);
            Console.WriteLine("Is the second number " + num2 + " the largest? " + isLargestNum2);
            Console.WriteLine("Is the third number " + num3 + " the largest? " + isLargestNum3);
        }

        public static void SumOfNaturalNumbers()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int sum = n * (n + 1) / 2;
                Console.WriteLine("The sum of first " + n + " natural numbers is " + sum);
            }
            else
            {
                Console.WriteLine("The number " + n + " is not a natural number");
            }
        }

        public static void CheckVotingEligibility()
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("The person's age is " + age + " and can vote.");
            }
            else
            {
                Console.WriteLine("The person's age is " + age + " and cannot vote.");
            }
        }

        public static void CheckNumberSign()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        public static void CheckSpringSeason()
        {
            Console.Write("Enter month (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day (1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());

            bool isSpringSeason = month == 3 && day >= 20 || month >= 4 && month <= 5 || month == 6 && day <= 20;
            if (isSpringSeason)
            {
                Console.WriteLine("It's a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }

        public static void CountdownUsingWhileLoop()
        {
            Console.Write("Enter a number for countdown: ");
            int counter = Convert.ToInt32(Console.ReadLine());
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }
        }

        public static void CountdownUsingForLoop()
        {
            Console.Write("Enter a number for countdown: ");
            int counter = Convert.ToInt32(Console.ReadLine());
            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void SumUntilZero()
        {
            double total = 0.0;
            double num;
            do
            {
                Console.Write("Enter a number (0 to stop): ");
                num = Convert.ToDouble(Console.ReadLine());
                total += num;
            } while (num != 0);
            Console.WriteLine("The total sum is " + total);
        }

        public static void SumUntilZeroOrNegative()
        {
            double total = 0.0;
            while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                double num = Convert.ToDouble(Console.ReadLine());
                if (num <= 0)
                    break;
                total += num;
            }
            Console.WriteLine("The total sum is " + total);
        }

        public static void SumOfNaturalNumbersWhile()
        {
            Console.Write("Enter a natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int sumUsingFormula = n * (n + 1) / 2;
                int sumUsingWhile = 0;
                int i = 1;
                while (i <= n)
                {
                    sumUsingWhile += i;
                    i++;
                }
                Console.WriteLine("Sum using formula: " + sumUsingFormula);
                Console.WriteLine("Sum using while loop: " + sumUsingWhile);
            }
            else
            {
                Console.WriteLine("Not a natural number.");
            }
        }

        public static void SumOfNaturalNumbersFor()
        {
            Console.Write("Enter a natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int sumUsingFormula = n * (n + 1) / 2;
                int sumUsingFor = 0;
                for (int i = 1; i <= n; i++)
                {
                    sumUsingFor += i;
                }
                Console.WriteLine("Sum using formula: " + sumUsingFormula);
                Console.WriteLine("Sum using for loop: " + sumUsingFor);
            }
            else
            {
                Console.WriteLine("Not a natural number.");
            }
        }

        public static void FindFactorial()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + num + " is " + factorial);
        }

        public static void FindFactorialWhile()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            int factorial = 1;
            int i = 1;
            while (i <= num)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine("Factorial of " + num + " is " + factorial);
        }

        public static void PrintOddEven()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Not a natural number.");
                return;
            }
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i + " is Even");
                else
                    Console.WriteLine(i + " is Odd");
            }
        }

        public static void CalculateBonus()
        {
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter years of service: ");
            int years = Convert.ToInt32(Console.ReadLine());
            if (years > 5)
            {
                double bonus = salary * 0.05;
                Console.WriteLine("The bonus is " + bonus);
            }
            else
            {
                Console.WriteLine("No bonus for service under 5 years.");
            }
        }

        public static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + number * i);
            }

        }
    }
}
