using System;
namespace CGTraining.Day2.ExtraQuestions
{
    public class Temperature
    {
        public static void checkTemperature()
        {
            Console.WriteLine("Enter temperature:");
            int degree = int.Parse(Console.ReadLine());

            if (degree < 0)
            {
                Console.WriteLine("Freezing");
            }
            else if (degree >= 0 && degree <= 20) // include 0–20
            {
                Console.WriteLine("Cold");
            }
            else if (degree >= 21 && degree <= 35) // include 21–35
            {
                Console.WriteLine("Warm");
            }
            else // degree > 35
            {
                Console.WriteLine("Hot");
            }
        }
    }
}
