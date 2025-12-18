using System;
namespace CGTraining.Day2.ExtraQuestions
{
    class PasswordStrengthChecker
    {
        public static void checkStrength()
        {
            Console.WriteLine("Enter PassWord");
            string password = Console.ReadLine();
            bool hasDigit = false;
            bool hasSpecialChar = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i])){ 
                    hasDigit = true; 
                }
                if (!char.IsLetterOrDigit(password[i])) {
                    hasSpecialChar = true; 
                }
            }
            if (password.Length >= 8 && hasDigit && hasSpecialChar) { 
                Console.WriteLine("Strong"); 
            }
            else if (password.Length >= 8 && (hasDigit || hasSpecialChar)){ 
                Console.WriteLine("Medium"); 
            }
            else { 
                Console.WriteLine("Weak"); 
            }
        }
    }
}
