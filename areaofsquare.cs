using System;

namespace Basics1
{
    class areaOfSquare
    {
        public void calOfSquare()
        {
            Console.WriteLine("Enter the area of square: ");
            int square = Convert.ToInt32(Console.ReadLine());
            int area = square * square;
            Console.WriteLine("Area of Square: " + square + " is " + area);
        }
    }
}