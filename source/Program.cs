using System;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {   
            // init
            Console.Title = "Terminal Knowledge!";
            double versionNum = 0.1;
            string playerName;
            int totalRounds;
            int currentRound;
            int questionNum;

            // title screen
            Console.WriteLine("Terminal Knowledge!");
            Console.WriteLine("Version " + versionNum);
            Console.WriteLine("Press any key to continue.");
            Console.WriteLine("----------------------------");
            Console.ReadKey();

            // opening
            Console.Clear();
            Console.WriteLine("Hello, and welcome to Terminal Knowledge!");
            Console.WriteLine("To get started, please input your name.");
            playerName = Convert.ToString(Console.ReadLine()); // sets player name to player input

            Console.Clear();
            Console.WriteLine("Nice to meet you, " + playerName + ".");
            Console.WriteLine("How many rounds would you like to play?");
            totalRounds = Convert.ToInt16(Console.ReadLine()); // sets total rounds to player input

            Console.Clear();
            Console.WriteLine("That's enough setup.");
            Console.WriteLine("Now, let's get started, eh?");
            Console.WriteLine("Press any key to begin, " + playerName + ".");

            // main game loop
            while(currentRound <= totalRounds) 
            {
                
            }

            Console.ReadKey(); // instaclose prevention
        }
    }
}

