using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.ControlFlow.Level2
{
    public class Level2
    {
        public static void LeapYearMultipleIf()
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 1582)
            {
                Console.WriteLine("Invalid Year");
            }
            else
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine("Not a Leap Year");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else
                {
                    Console.WriteLine("Not a Leap Year");
                }
            }
        }

        public static void LeapYearSingleIf()
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeap = year >= 1582 && (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);
            if (isLeap)
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a Leap Year");
        }

        public static void GradeCalculation()
        {
            Console.WriteLine("Enter Physics marks:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths marks:");
            int m = Convert.ToInt32(Console.ReadLine());
            double avg = (p + c + m) / 3.0;
            Console.WriteLine("Average:" + avg);
            if (avg >= 80)
                Console.WriteLine("Grade A");
            else if (avg >= 70 && 79 <= avg)
                Console.WriteLine("Grade:B Remarks:Very Good");
            else if (avg >= 60 && 69 <= avg)
                Console.WriteLine("Grade C");
            else if (avg >= 50 && 59 <= avg)
                Console.WriteLine("Grade D");
            else if (avg >= 40 && 49 <= avg)
                Console.WriteLine("Grade E ");
            else
                Console.WriteLine("Grade R");
        }

        public static void PrimeNumber()
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1)
                isPrime = false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");
        }

        public static void FizzBuzzFor()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (i % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(i);
                }
            }
        }

        public static void FizzBuzzWhile()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
                i++;
            }
        }

        public static void BMI()
        {
            Console.WriteLine("Enter weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height in cm:");
            double height = Convert.ToDouble(Console.ReadLine());
            double h = height / 100;
            double bmi = weight / (h * h);
            Console.WriteLine("BMI:" + bmi);
            if (bmi <= 18.5)
                Console.WriteLine("Underweight");
            else if (bmi < 25)
                Console.WriteLine("Normal");
            else if (bmi < 30)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");
        }

        public static void YoungestAndTallest()
        {
            Console.WriteLine("Enter Amar age:");
            int aAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Akbar age:");
            int akAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Anthony age:");
            int anAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amar height:");
            double aH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Akbar height:");
            double akH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Anthony height:");
            double anH = Convert.ToDouble(Console.ReadLine());

            int minAge = aAge;
            string youngest = "Amar";
            if (akAge < minAge) { minAge = akAge; youngest = "Akbar"; }
            if (anAge < minAge) { minAge = anAge; youngest = "Anthony"; }
            Console.WriteLine("Youngest:" + youngest);

            double maxH = aH;
            string tallest = "Amar";
            if (akH > maxH) { maxH = akH; tallest = "Akbar"; }
            if (anH > maxH) { maxH = anH; tallest = "Anthony"; }
            Console.WriteLine("Tallest:" + tallest);
        }

        public static void GreatestFactor()
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int greatestFactor = 1;
            for (int i = num - 1; i >= 1; i--)
            {
                if (num % i == 0)
                {
                    greatestFactor = i;
                    break;
                }
            }
            Console.WriteLine(greatestFactor);
        }

        public static void Power()
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter power:");
            int pow = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= pow; i++)
                result = result * num;
            Console.WriteLine(result);
        }

        public static void Factors()
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
            }
        }

        public static void MultiplesBelow100()
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 100; i >= 1; i--)
            {
                if (i % num == 0)
                    Console.WriteLine(i);
            }

        }
    }
}
