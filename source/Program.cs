using System;

namespace source
{
    class Program
    {    
        public static int oppPoints = 0;
        public static Random oppR = new Random();
        public static int GotQCorrect;
        public static string[] opponentNames =
        {
            "Andrew",
            "Fred",
            "James",
            "Sofia",
            "Amy",
            "Julia",
            "David",
            "Matthew",
            "Archie",
            "Emily",
            "Chloe",
            // TODO: add more names
        };
        public static string oppName;

        static void Main(string[] args)
        {   
            // init
            Console.Title = "Terminal Knowledge!";
            string versionNum = "0.3";
            string playerName;
            string playerAnswer;
            string correctAnswer;
            int totalRounds;
            int correctQuestions = 0;
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
                "How do you declare an integer with no value in C#?",
                "When did PHP 8 release?",
                "True or false: C++ is object oriented while C isn't.",
                // TODO: add more questions
            };
            string[] comparedAnswers =
            {
                "false",
                "1970s",
                "no",
                "false",
                "microsoft",
                "int integername;",
                "november 26 2020",
                "true",
            };
            string[] displayedAnswers = // we have 2 lists with answers so we don't display an answer in all lowercase.
            {
                "False",
                "1970s",
                "No",
                "False",
                "Microsoft",
                "'int', then the integer's name, then ';'",
                "November 26, 2020",
                "True",
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
            GenOpponentName();
            Console.WriteLine("That's enough setup.");
            Console.WriteLine("You'll be going up against " + oppName + ".");
            Console.WriteLine("Now, let's get started, eh?");
            Console.WriteLine("Press any key to begin, " + playerName + ".");

            // main game loop
            while(currentRound <= totalRounds) 
            {
                questionNum = r.Next(0, questions.Length); // random question
                Console.WriteLine("Question " + currentRound + ": " + questions[questionNum]); // prints question num and the question
                playerAnswer = Convert.ToString(Console.ReadLine());

                correctAnswer = comparedAnswers[questionNum];
                playerAnswer = playerAnswer.ToLower(); // lowercase so answers aren't marked wrong because of uppercase

                if (playerAnswer.Contains(correctAnswer))// this is so the user gets points even if they include more than what is required
                {
                    Console.WriteLine("That's the correct answer, " + playerName + "!");
                    correctQuestions++;
                }
                else
                {
                   Console.WriteLine("Sorry, " + playerName + ", that isn't the right answer.");
                   Console.WriteLine("The correct answer was " + displayedAnswers[questionNum] + ".");
                   correctQuestions--;
                }

                GradeOpponent();

                Console.WriteLine("Press any key to proceed.");
                Console.ReadKey();
                Console.Clear();
                currentRound++;

            };
            
            // ending game
            Console.Clear();
            Console.WriteLine("The game's over, " + playerName + ".");
            Console.WriteLine("Time to announce the winner!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            
            Console.WriteLine("And.....");
            if(oppPoints > correctQuestions)
            {
                Console.WriteLine(oppName + " wins! Sorry, " + playerName + ", better luck next time.");
            }
            else if(oppPoints < correctQuestions)
            {
                Console.WriteLine(playerName + " wins! Congratulations!");
            }
            else
            {
                Console.WriteLine("It's a tie! Unbelieveable! You don't see that everyday.");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            
            Console.WriteLine("We hope you had fun playing Terminal Knowledge! See you soon! (hopefully...)");
            Console.WriteLine("Press any key to end the game.");

            Console.ReadKey(); // instaclose prevention
        }

        static void GradeOpponent()
        {    
            GotQCorrect = oppR.Next(0, 1);
            
            if (GotQCorrect == 1)
            {
                oppPoints++;
            }
            else
            {
                oppPoints--;
            }

        }

        static void GenOpponentName()
        {
            Random genR = new Random();
            int temp;

            temp = genR.Next(1, opponentNames.Length);
            oppName = opponentNames[temp];
        }
    }
}
