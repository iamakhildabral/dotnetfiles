using System;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Palindrome.PalindromeUtils.IsPalindrome();
            //Armstrong.Armstrong.isArmstrong();
            string str  = "";
            str = Console.ReadLine();
            System.Console.WriteLine("Enter the substring");
            if(str.Contains(Console.ReadLine())){
                System.Console.WriteLine("substring exist");
            }else{
                System.Console.WriteLine("Not Exist");
            }

            

        }
    }
}
