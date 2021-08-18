using System;

namespace TDD_PassWordVerifier
{
    public class Program
    {

        public static bool Verify(string input)
        {
            int numberOfChars = input.Length;
            if (input == "")
            {
                Console.WriteLine("The password cannot be empty.");
                return false;
            }
            else if (numberOfChars < 8)
            {
                Console.WriteLine("The password must have at least 8 characters.");
                return false;
            }
            int uppercount = 0; // referenced https://stackoverflow.com/questions/609704/fastest-way-to-count-number-of-uppercase-characters-in-c-sharp
            int lowercount = 0;
            int digitcount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i])) uppercount++;
                if (char.IsLower(input[i])) lowercount++;
                if (char.IsDigit(input[i])) digitcount++;
            }
            if (uppercount < 1)
            {
                Console.WriteLine("The password must contain at least one uppercase letter.");
                return false;
            }

            if (lowercount < 1)
            {
                Console.WriteLine("The password must contain at least one lowercase letter.");
                return false;
            }

            if (digitcount < 1)
            {
                Console.WriteLine("The password must contain at least one number.");
                return false;
            }
            else return true;
        }

        public static void Main(string[] args)
        {
            bool verifyPassword = false;
            while (verifyPassword == false)
            {
                Console.WriteLine("Please set your password:");
                string password = Console.ReadLine();
                verifyPassword = Verify(password);


            }
            Console.WriteLine("Your password has been set.");
        }
    }
}

