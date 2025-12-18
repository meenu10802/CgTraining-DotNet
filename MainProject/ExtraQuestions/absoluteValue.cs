using System;
namespace CGTraining.Day2.ExtraQuestions
{

    class absoluteValue
    {
        public static void flipped()
        {
            Console.WriteLine("Enter any number: ");
            int num = int.Parse(Console.ReadLine());
            int absValue = (num < 0) ? -num : num;
            Console.WriteLine("Absolute value: "+absValue);
        }
    }
}