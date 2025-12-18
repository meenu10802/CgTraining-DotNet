using System;
namespace CGTraining.Day2.ExtraQuestions
{

    class ATM
    {
       public static void check()
        {
            Console.WriteLine("Enter Balance: ");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdrawal amount: ");
            int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
            int minimumBalance = 1000;
            int dailyLimit = 20000;
            if (withdrawalAmount <= balance && (balance - withdrawalAmount) >= minimumBalance)
            {
                if (withdrawalAmount <= dailyLimit)
                {
                    Console.WriteLine("Allow");
                }
                else
                {
                    Console.WriteLine("Withdrawal amount exceeds daily limit");
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

    }
}
