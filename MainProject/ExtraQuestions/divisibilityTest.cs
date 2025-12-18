using System;
namespace CGTraining.Day2.ExtraQuestions
{

    class divisibilityTest
    {
        public static void isDivisbleOrNot()
        {
            Console.WriteLine("Enter a number: ");
            int num=int.Parse(Console.ReadLine());
            if((num%3==0 && num%5!=0) || (num%3!=0 && num % 5 == 0)){
                Console.WriteLine("Yes Divsible");
            }
            else
            {
                Console.WriteLine("No Divsible by either both or none");
            }
        }
    }
}