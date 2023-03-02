using System;

namespace Basics1
{
    class addTwoNumbers
    {
        static void Main(string[] args)
        {
            //area of circle
            areaOfCircle cir = new areaOfCircle();
            cir.calOfCircle();

            //area of square
            areaOfSquare squ = new areaOfSquare();
            squ.calOfSquare();

            //area of rectangle
            areaOfRectangle rec = new areaOfRectangle();
            rec.calOfRectangle();

            //convert days to years, weeks and months
            convertDays conDay = new convertDays();
            conDay.convertDaysxx();

            //check odd or even number
            oddOrEven oddEven = new oddOrEven();
            oddEven.chkOddOrEven();

            //check largest number among five number
            LargestNum lrg = new LargestNum();
            lrg.ChkLargestNum();

            //Welcome User
            welcomeUser wel = new welcomeUser();
            wel.greetUser("name");
        }
    }
}