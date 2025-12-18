using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.ControlFlow.Level1
{
    public class Level1CallMethods
    {
        
        public static void callMethods()
        {
            Level1.CheckDivisibleByFive();
            Level1.CheckSmallest();
            Level1.CheckLargest();
            Level1.SumOfNaturalNumbers();
            Level1.CheckVotingEligibility();
            Level1.CheckNumberSign();
            Level1.CheckSpringSeason();
            Level1.CountdownUsingWhileLoop();
            Level1.CountdownUsingForLoop();
            Level1.SumUntilZero();
            Level1.SumUntilZeroOrNegative();
            Level1.SumOfNaturalNumbersWhile();
            Level1.SumOfNaturalNumbersFor();
            Level1.FindFactorial();
            Level1.FindFactorialWhile();
            Level1.PrintOddEven();
            Level1.CalculateBonus();
            Level1.MultiplicationTable();

            Console.WriteLine("Program finished.");
            Console.ReadLine();
        }
    }

}
