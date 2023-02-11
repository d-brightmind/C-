using System;

namespace Basics1
{
    class oddOrEven
    {
        public void chkOddOrEven()
        {
            Console.WriteLine("Enter number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int check = userNum / 2;

            if (check == 0)
                Console.WriteLine(userNum + " is an odd number");   
            else
                Console.WriteLine(userNum + " is an even number");
        }
    }
}