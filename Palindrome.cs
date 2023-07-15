using System;
using System.Text;

namespace Palindrome{
    public static class PalindromeUtils{
        public static void IsPalindrome(){
            Console.WriteLine("Enter the string to check for palindrome");
            string? userInput =  Console.ReadLine();

            do{

                // Create a StringBuilder to store the reverse string.
                StringBuilder reverse = new StringBuilder();

                // Iterate through the original string, adding each character to the reverse string in reverse order.
                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    reverse.Append(userInput[i]);
                }

                // Check if the reverse string is equal to the original string.
                if (reverse.ToString() == userInput)
                {
                    Console.WriteLine("the string is palindrome");
                }
                else
                {
                    Console.WriteLine("Not a Palindrome");
                }
                Console.WriteLine("Enter the string to check for palindrome \nType q or Q for closing this ");
                userInput =  Console.ReadLine();
            }while(userInput != "Q" && userInput != "q");

        }
    }
}