using System;

namespace Basics1
{
    class LargestNum
    {
        public void ChkLargestNum()
        {
            Console.WriteLine("Enter five(5) numbers:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int a4 = Convert.ToInt32(Console.ReadLine());
            int a5 = Convert.ToInt32(Console.ReadLine());
    
            int[] listOfNums = { a1, a2, a3, a4, a5 };
            Console.WriteLine(listOfNums.Max() + " is the largest number");
        }
    }
}