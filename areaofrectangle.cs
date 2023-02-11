using System;

namespace Basics1
{
    class areaOfRectangle
    {
        public void calOfRectangle()
        {
            Console.WriteLine("Enter the length(l): ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth(b): ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int area = length * breadth;
            Console.WriteLine("Area of rectangle is: " + area);
        }
    }
}