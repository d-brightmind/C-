using System;

namespace Basics1
{
    class areaOfCircle
    {
        public void calOfCircle()
        {
            Console.WriteLine("Enter the area of circle:");
            int radius = Convert.ToInt32(Console.ReadLine());
            int area = (int)(Math.PI * radius * radius);
            Console.WriteLine("Area of circle is: " + area);
        }
    }
}