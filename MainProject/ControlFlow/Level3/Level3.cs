using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.ControlFlow.Level3
{
    public class Level3
    {
        public static void CheckArmstrong()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;

            while (originalNumber != 0)
            {
                int remainder = originalNumber % 10;
                int cube = remainder * remainder * remainder;
                sum = sum + cube;
                originalNumber = originalNumber / 10;
            }

            if (sum == number)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not an Armstrong Number");
        }

        public static void CountDigits()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (number != 0)
            {
                number = number / 10;
                count = count + 1;
            }

            Console.WriteLine("Number of digits: " + count);
        }

        public static void CheckHarshad()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int sum = 0;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum = sum + digit;
                temp = temp / 10;
            }

            if (number % sum == 0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not a Harshad Number");
        }

        public static void CheckAbundant()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum = sum + i;
            }

            if (sum > number)
                Console.WriteLine("Abundant Number");
            else
                Console.WriteLine("Not an Abundant Number");
        }

        public static void DayOfWeek(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            Console.WriteLine("Day of week: " + d0);
        }

        public static void Calculator()
        {
            Console.Write("Enter first number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (first + second));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (first - second));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (first * second));
                    break;
                case "/":
                    Console.WriteLine("Result: " + (first / second));
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

        }
    }
}
