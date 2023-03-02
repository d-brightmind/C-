using System;

namespace Basics1
{
    class welcomeUser
    {
        public string greetUser(string name)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Have a nice day");
            return name;
        }
    }
}