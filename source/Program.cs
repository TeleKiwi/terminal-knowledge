using System;

namespace source
{
    class Program
    {   
        static void Main(string[] args)
        {   
            // init
            Console.Title = "Terminal Knowledge!";
            string versionNum = "0.2.1";
            string playerName;
            string playerAnswer;
            string correctAnswer;
            int totalRounds;
            int currentRound = 1;
            int questionNum;
            Random r = new Random();
            string[] questions = 
            {
                "True or false: HTML is a programming language.",
                "When was C invented?",
                "Does Python contain switch statements?",
                "True or false: printf('Hello World!') works in C#.",
                "Who developed Visual Studio Code?",
            };
            string[] answers =
            {
                "false",
                "1970s",
                "no",
                "false",
                "microsoft",
            };

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
                questionNum = r.Next(0, questions.Length); // random question
                Console.WriteLine("Question " + currentRound + ": " + questions[questionNum]); // prints question num and the question
                playerAnswer = Convert.ToString(Console.ReadLine());

                correctAnswer = answers[questionNum];
                playerAnswer = playerAnswer.ToLower(); // lowercase so answers aren't marked wrong because of uppercase

                if (playerAnswer.Contains(correctAnswer))// this is so the user gets a question right if their answer contains the right one
                {
                    Console.WriteLine("That's the correct answer, " + playerName + "!");
                }
                else
                {
                   Console.WriteLine("Sorry, " + playerName + ", that isn't the right answer.");
                   Console.WriteLine("The correct answer was " + correctAnswer + ".");
                }

                Console.WriteLine("Press any key to proceed.");
                Console.ReadKey();
                Console.Clear();
                currentRound++;

            };

            Console.ReadKey(); // instaclose prevention
        }
    }      
}

