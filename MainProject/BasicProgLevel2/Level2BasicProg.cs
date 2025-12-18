using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.BasicProgLevel2
{
    public class Level2BasicProg
    {
        public static void QuotientRemainder()
        {
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int quotient = number1 / number2;
            int remainder = number1 % number2;
            Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
        }

        public static void IntOperations()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int r1 = a + b * c;
            int r2 = a * b + c;
            int r3 = c + a / b;
            int r4 = a % b + c;
            Console.WriteLine("The results of Int Operations are " + r1 + ", " + r2 + ", " + r3 + ", " + r4);
        }

        public static void DoubleOperations()
        {
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double r1 = a + b * c;
            double r2 = a * b + c;
            double r3 = c + a / b;
            double r4 = a % b + c;
            Console.WriteLine("The results of Double Operations are " + r1 + ", " + r2 + ", " + r3 + ", " + r4);
        }

        public static void CelsiusToFahrenheit()
        {
            Console.Write("Enter Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("The " + celsius + " Celsius is " + fahrenheit + " Fahrenheit");
        }

        public static void FahrenheitToCelsius()
        {
            Console.Write("Enter Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius");
        }

        public static void TotalIncome()
        {
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());
            double income = salary + bonus;
            Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + income);
        }

        public static void SwapNumbers()
        {
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
        }

        public static void TripDetails()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter from city: ");
            string fromCity = Console.ReadLine();
            Console.Write("Enter via city: ");
            string viaCity = Console.ReadLine();
            Console.Write("Enter to city: ");
            string toCity = Console.ReadLine();
            Console.Write("Enter distance from to via: ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter distance via to final: ");
            double viaToFinal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time taken: ");
            double time = Convert.ToDouble(Console.ReadLine());
            double totalDistance = fromToVia + viaToFinal;
            double speed = totalDistance / time;
            Console.WriteLine("The results of the trip are: " + name + ", " + totalDistance + ", " + speed);
        }

        public static void AthleteRounds()
        {
            Console.Write("Enter side1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            double perimeter = side1 + side2 + side3;
            double rounds = 5000 / perimeter;
            Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
        }

        public static void ChocolatesDistribution()
        {
            Console.Write("Enter number of chocolates: ");
            int chocolates = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of children: ");
            int children = Convert.ToInt32(Console.ReadLine());
            int each = chocolates / children;
            int remaining = chocolates % children;
            Console.WriteLine("The number of chocolates each child gets is " + each + " and the number of remaining chocolates is " + remaining);
        }

        public static void SimpleInterest()
        {
            Console.Write("Enter principal: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time: ");
            double time = Convert.ToDouble(Console.ReadLine());
            double si = (principal * rate * time) / 100;
            Console.WriteLine("The Simple Interest is " + si + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
        }

        public static void PoundsToKg()
        {
            Console.Write("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kg = pounds / 2.2;
            Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kg);
        }
    }
}
