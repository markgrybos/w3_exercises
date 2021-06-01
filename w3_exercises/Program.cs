using System;

namespace w3_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# Syntax Exercise
            Console.WriteLine("Hello World");

            // C# Comments
            // Single Line Comment
            /* Muti
             * Line
             * Comment*/

            // C# Variables
            int myNum = 50;
            string myName = "John";
            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);
            int z = x + y;
            Console.WriteLine(z);
            int a = 5, b = 6, c = 50;
            Console.WriteLine(a + b + c);

            // C# Data Types
            int myNumDT = 9;
            double myDoubleNum = 8.99;
            char myLetter = 'A';
            bool myBool = false;
            string myText = "Hello World";
            Console.WriteLine($"myNumDT: {myNumDT}, myDoubleNum: {myDoubleNum}," +
                $"myLetter: {myLetter}, myBool: {myBool}, myText: {myText}");

            bool yay = true;
            bool nay = false;
            Console.WriteLine($"yay: {yay}, nay: {nay}");

            string greeting = "Hello";
            Console.WriteLine(greeting);

            int myInt = 10;
            Console.WriteLine(Convert.ToString(myInt));

            // C# User Input
            Console.WriteLine("Enter Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Think of a number:");
            int myNumUI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + myNumUI);

            // C# Operators
            Console.WriteLine(10 * 5);
            Console.WriteLine(10 / 5);
            int t = 10;
            t++;
            t += 5;

            // C# Math
            int newX = 5;
            int newY = 10;
            Console.WriteLine(Math.Max(newX, newY));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Round(2.6));

            // C# Strings
            string newGreeting = "Hello";

            string firstName = "John";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string nameTwo = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(nameTwo);

            Console.WriteLine(newGreeting[0]);
            Console.WriteLine(newGreeting.Length);
            Console.WriteLine(newGreeting.ToUpper());

            // C# Booleans
            bool isCodingfun = true;
            bool isFishTasty = false;
            Console.WriteLine($"isCodingFun: {isCodingfun}, isFishTasty: {isFishTasty}");

            int boolX = 10;
            int boolY = 9;
            Console.WriteLine(x > y);

            // C# If...Else
            int ifX = 50;
            int ifY = 10;
            if(x > y)
            {
                Console.WriteLine("Hello World");
            }

            int ifYTwo = 50;

            if(ifX == ifYTwo)
            {
                Console.WriteLine("Hello World");
            }

            if (ifX == ifYTwo)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            if (ifX == ifYTwo)
            {
                Console.WriteLine("1");
            }
            else if (ifX > ifYTwo)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }

            int time = 20;
            string result = (time < 20) ? "Good Day" : "Good Evening";
            Console.WriteLine(result);
        }
    }
}
