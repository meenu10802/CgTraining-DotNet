using System;
namespace CGTraining.Day2.ExtraQuestions
{
    public class Restaurant
    {
        public static void Open()
        {
            int minOrderAmount = 200;
            bool isRestaurantOpen = true;
            bool isDeliveryPartnerAvailable = true;
            Console.WriteLine("Enter Order value:");
            int orderValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you a Prime customer(true/false):");
            bool isPrime = bool.Parse(Console.ReadLine());
            if (isRestaurantOpen && isDeliveryPartnerAvailable && (orderValue >= minOrderAmount || isPrime))
            {
                Console.WriteLine("Order Accepted");
            }
            else
            {
                Console.WriteLine("Order Rejected");
            }
            Console.WriteLine("Git task 3- making chnages but not committing");
        }
    }
}
