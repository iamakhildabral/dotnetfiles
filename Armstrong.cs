using System;

namespace Armstrong{
    class Armstrong{
        public static void isArmstrong(){
            Console.WriteLine("Enter the number to check for the Armstrong");
            int userInput = int.Parse(Console.ReadLine());
            int noToCheck = userInput;
            int sum = 0;
            while(noToCheck>0)
            {
                sum +=  (int)Math.Pow((noToCheck%10),3);
                noToCheck = noToCheck/10;
            }
            if(sum == userInput){
                Console.WriteLine("it is an armstrong :");
            }else{
                Console.WriteLine("Not an armstrong :");
            }

        }
    }
}