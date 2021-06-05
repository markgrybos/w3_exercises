using System;
using System.Threading;
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

            /* C# User Input
            Console.WriteLine("Enter Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Think of a number:");
            int myNumUI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + myNumUI);
            */

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
            if (x > y)
            {
                Console.WriteLine("Hello World");
            }

            int ifYTwo = 50;

            if (ifX == ifYTwo)
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

            // C# Switch
            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
            }

            int dayNext = 3;
            switch (dayNext)
            {
                case 1:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 2:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the weekend");
                    break;
            }

            // C# Loops
            int i = 1;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 6);

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Yes");
            }

            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    break;
                }
                Console.WriteLine(j);
            }

            for (int j = 0; j < 10; j++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(j);
            }

            // C# Arrays
            string[] beatles = { "John", "Paul", "George", "Ringo" };
            Console.WriteLine(beatles[1]);
            beatles[0] = "Yoko";
            Console.WriteLine(beatles[0]);

            foreach (string beatle in beatles)
            {
                Console.WriteLine(beatle);
            }

            Array.Sort(beatles);
            foreach (string beatle in beatles)
            {
                Console.WriteLine(beatle);
            }

            // C# Methods
            MyMethod();

            string[] refsneses = { "Liam", "Jenny", "Anja" };
            foreach (string refsnes in refsneses)
            {
                MyMethodTwo(refsnes);
            }

            MyMethodNum(3);

            // C# Classes & Try-Catch
            Console.WriteLine("What is your name combatant?");
            string pName = Console.ReadLine();
            Console.WriteLine("Howdy, do you fight with 'metal' or 'magic'?");
            string attackStyle = Console.ReadLine();
            Player player = new Player(pName, attackStyle);
            Console.WriteLine($"Welcome {player.Name}! Prepare your {player.AttackStyle.ToUpper()} you have {player.Health} health and an attack of {player.Attack}");
            for (int m = 0; m < 10; m++)
            {
                Monster minion = new Monster();
                Console.WriteLine($"This is a level {minion.Level} {minion.Type}.");
                Console.WriteLine($"It has {minion.Attack} attack and {minion.Defense} defense with a total of {minion.Health} health");
                while (minion.Health > 0)
                {
                    try
                    {
                        if (player.Attack > minion.Defense)
                        {
                            minion.Health = player.attackTarget(minion.Health, minion.Defense);
                        }
                        else
                        {
                            throw new ArgumentException("You were too weak to deal any damage. You died");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                }
                if (minion.Health == 0)
                {
                    Console.WriteLine("Monster has been slain!");
                }
                Thread.Sleep(500);
                i++;
                Console.WriteLine($"Press Enter to Continue or type 'q' to quit. You have {10 - (m + 1)} monsters remaining.");
                string end = Console.ReadLine();
                if (end.ToLower() == "q")
                {
                    break;
                }
            }







            Console.ReadKey();
        }
        static void MyMethod()
        {
            Console.WriteLine("I Just got Executed!");
        }

        static void MyMethodTwo(string fname)
        {
            Console.WriteLine($"{fname} Refsnes");
        }

        static int MyMethodNum(int x)
        {
            return 5 + x;
        }
    }

    public class Monster
    {
        Random random = new Random();
        public string Type { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public Monster()
        {
            Type = monsterTypeRandomizer();
            Level = random.Next(1, 5);
            switch (Type)
            {
                case "Goblin":
                    Goblin goblin = new Goblin();
                    Attack = goblin.Attack;
                    Defense = goblin.Defense;
                    break;
                case "Zombie":
                    Zombie zombie = new Zombie();
                    Attack = zombie.Attack;
                    Defense = zombie.Defense;
                    break;
                case "Dragon":
                    Dragon dragon = new Dragon();
                    Attack = dragon.Attack;
                    Defense = dragon.Defense;
                    break;
                case "Orc":
                    Orc orc = new Orc();
                    Attack = orc.Attack;
                    Defense = orc.Defense;
                    break;
                case "Werewolf":
                    Werewolf werewolf = new Werewolf();
                    Attack = werewolf.Attack;
                    Defense = werewolf.Defense;
                    break;
                case "Troll":
                    Troll troll = new Troll();
                    Attack = troll.Attack;
                    Defense = troll.Defense;
                    break;
                case "Vampire":
                    Vampire vampire = new Vampire();
                    Attack = vampire.Attack;
                    Defense = vampire.Defense;
                    break;
                case "Witch":
                    Witch witch = new Witch();
                    Attack = witch.Attack;
                    Defense = witch.Defense;
                    break;
            }
            Attack = Attack * Level;
            Defense = Defense * Level ;
            Health = 5 * Level;
        }

        private string monsterTypeRandomizer()
        {
            string[] monsterTypes = new string[] { "Goblin", "Zombie", "Dragon", "Orc", "Werewolf", "Troll", "Vampire", "Witch" };
            string returnType = monsterTypes[random.Next(monsterTypes.Length)];
            return returnType;
        }

        private class Goblin
        {
            public int Attack = 3;
            public int Defense = 3;
        }

        private class Zombie
        {
            public int Attack = 3;
            public int Defense = 1;
        }

        private class Dragon
        {
            public int Attack = 15;
            public int Defense = 7;
        }
        private class Orc
        {
            public int Attack = 7;
            public int Defense = 5;
        }
        private class Werewolf
        {
            public int Attack = 10;
            public int Defense = 4;
        }
        private class Troll
        {
            public int Attack = 3;
            public int Defense = 6;
        }
        private class Vampire
        {
            public int Attack = 6;
            public int Defense = 2;
        }
        private class Witch
        {
            public int Attack = 3;
            public int Defense = 1;
        }
    }

    class Player
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public string Name { get; set; }
        public string AttackStyle { get; set; }

        public Player(string playerName, string playerAttackStyle)
        {
            Name = playerName;
            if (playerAttackStyle.ToLower() == "metal")
            {
                AttackStyle = "metal";
                Attack = 6;
                Health = 10;
            }
            else if (playerAttackStyle.ToLower() == "magic")
            {
                AttackStyle = "magic";
                Attack = 10;
                Health = 5;
            }
            else
            {
                AttackStyle = "bare fist";
                Attack = 3;
                Health = 5;
            }
        }
        public int attackTarget(int monsterHealth, int monsterDefense)
        {
            int playerAttack = Attack - monsterDefense;
            Console.WriteLine($"{Name} is attacking for {playerAttack} damage!");
            return monsterHealth = monsterHealth - playerAttack;

        }
    }
}
