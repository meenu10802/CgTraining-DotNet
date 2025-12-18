using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.BasicProgLevel1
{
    public class Level1Basics
    {
            public static void AgeOfHarry()
            {
                int birthYear = 2000;
                int currentYear = 2024;
                int age = currentYear - birthYear;
                Console.WriteLine("Harry's age in 2024 is " + age);
            }

            public static void AveragePCM()
            {
                int maths = 94;
                int physics = 95;
                int chemistry = 96;
                double average = (maths + physics + chemistry) / 3.0;
                Console.WriteLine("Sam’s average mark in PCM is " + average);
            }

            public static void KmToMilesFixed()
            {
                double km = 10.8;
                double miles = km / 1.6;
                Console.WriteLine("The distance " + km + " km in miles is " + miles);
            }

            public static void ProfitAndLoss()
            {
                int costPrice = 129;
                int sellingPrice = 191;
                int profit = sellingPrice - costPrice;
                double profitPercent = profit / (double)costPrice * 100;
                Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice +
                                  "\nThe Profit is INR " + profit + " and the Profit Percentage is " + profitPercent);
            }

            public static void PensDistribution()
            {
                int pens = 14;
                int students = 3;
                int perStudent = pens / students;
                int remaining = pens % students;
                Console.WriteLine("The Pen Per Student is " + perStudent + " and the remaining pen not distributed is " + remaining);
            }

            public static void FeeDiscountFixed()
            {
                double fee = 125000;
                double discountPercent = 10;
                double discount = fee * discountPercent / 100;
                double finalFee = fee - discount;
                Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
            }

            public static void VolumeOfEarth()
            {
                double radiusKm = 6378;
                double volumeKm = 4.0 / 3.0 * Math.PI * Math.Pow(radiusKm, 3);
                double volumeMiles = volumeKm / Math.Pow(1.6, 3);
                Console.WriteLine("The volume of earth in cubic kilometers is " + volumeKm + " and cubic miles is " + volumeMiles);
            }

            public static void KmToMilesInput()
            {
                Console.Write("Enter km: ");
                double km = Convert.ToDouble(Console.ReadLine());
                double miles = km / 1.6;
                Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
            }

            public static void FeeDiscountInput()
            {
                Console.Write("Enter fee: ");
                double fee = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter discount percent: ");
                double discountPercent = Convert.ToDouble(Console.ReadLine());
                double discount = fee * discountPercent / 100;
                double finalFee = fee - discount;
                Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
            }

            public static void HeightConversion()
            {
                Console.Write("Enter height in cm: ");
                double cm = Convert.ToDouble(Console.ReadLine());
                double inches = cm / 2.54;
                double feet = inches / 12;
                Console.WriteLine("Your Height in cm is " + cm + " while in feet is " + feet + " and inches is " + inches);
            }

            public static void BasicCalculator()
            {
                Console.Write("Enter first number: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + n1 + " and " + n2 +
                                  " is " + (n1 + n2) + ", " + (n1 - n2) + ", " + n1 * n2 + ", " + n1 / n2);
            }

            public static void TriangleArea()
            {
                Console.Write("Enter base: ");
                double baseValue = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine());
                double area = 0.5 * baseValue * height;
                Console.WriteLine("The area of triangle is " + area);
            }

            public static void SquareSide()
            {
                Console.Write("Enter perimeter: ");
                double perimeter = Convert.ToDouble(Console.ReadLine());
                double side = perimeter / 4;
                Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
            }

            public static void FeetToYardsMiles()
            {
                Console.Write("Enter distance in feet: ");
                double feet = Convert.ToDouble(Console.ReadLine());
                double yards = feet / 3;
                double miles = yards / 1760;
                Console.WriteLine("Distance in yards is " + yards + " and miles is " + miles);
            }

            public static void TotalPurchasePrice()
            {
                Console.Write("Enter unit price: ");
                double unitPrice = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                double total = unitPrice * quantity;
                Console.WriteLine("The total purchase price is INR " + total + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
            }

            public static void Handshakes()
            {
                Console.Write("Enter number of students: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int handshakes = n * (n - 1) / 2;
                Console.WriteLine("The maximum number of handshakes is " + handshakes);
            }
        }
    }
