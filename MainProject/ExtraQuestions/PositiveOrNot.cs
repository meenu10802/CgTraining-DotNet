using System;
namespace CGTraining.Day2.ExtraQuestions
{

    class PositiveOrNegative
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The number is " + (num >= 0 ? "Positive" : "Negative"));
        }
    }
}
