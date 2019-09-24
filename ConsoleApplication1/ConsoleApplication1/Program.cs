using System;
using System.Threading;
//First, the program asks if you're ready. THen, it let's you choose either rock, paper or scissors.
//Computer chooses one too. After each match, the points are added to the winner's score.

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rdy;
            int selection;
            string botselection;
            string rock;
            string paper;
            string scissors;
            string result;
            int score = 0;
            int botscore = 0;
            Random random = new Random();
            int bot = random.Next(1, 3);
            Console.WriteLine("Hello, let's play rock, paper, scissors. I'll start. We show the sign when I say 'Shoot'. Ready?");
            Thread.Sleep(1000);
            Console.WriteLine("Yes/No");
            rdy = Console.ReadLine().ToUpper();
            //a bit of code asking if the user is ready for a game
            if (rdy == "YES")
            {
                Console.WriteLine("Put a number from 1 to 3 to choose your sign. 1. Rock\n 2. Paper\n or 3. Scissors\n");
            }
            else if (rdy == "NO")
            {
                Console.WriteLine("Alright, I'm gonna give you 5 seconds, but you have to be ready after that.");
                Console.ReadLine();
                Thread.Sleep(5000);
                Console.WriteLine("Put a number from 1 to 3 to choose your sign. 1. Rock 2. Paper or 3. Scissors");
            }

            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    result = "rock";
                    break;
                case 2:
                    result = "paper";
                    break;
                case 3:
                    result = "scissors";
                    break;
                default:
                    result = "";
                    break;
            }
            switch (bot)
            {
                case 1:
                    botselection = "rock";
                    break;
                case 2:
                    botselection = "paper";
                    break;
                case 3:
                    botselection = "scissors";
                    break;
                default:
                    botselection = "";
                    break;
            }
            if (result == botselection)
            {
                Console.WriteLine("Draw! Nobody wins");
                Console.ReadLine();
            }
            else if (result == "rock" || botselection == "paper")
            {
                Console.WriteLine("You lose!");
                Console.ReadLine();
                botscore++;
            }
            else if (result == "paper" || botselection == "scissors")
            {
                Console.WriteLine("You lose!");
                Console.ReadLine();
                botscore++;
            }
            else if (result == "scissors" || botselection == "rock")
            {
                Console.WriteLine("You win!");
                    Console.ReadLine();
                score++;

            }
            else if (result == "rock" || botselection == "scissors")
            {
                Console.WriteLine("You win!");
                    Console.ReadLine();
                score++;
            }
            else if (result == "paper" || botselection == "rock")
            {
                Console.WriteLine("You win!");
                Console.ReadLine();
                score++;
            }
            else if (result == "scissors" || botselection == "paper")
            {
                Console.WriteLine("You win!");
                Console.ReadLine();
                score++;
            }
        
                Console.WriteLine("Rock...");
            Thread.Sleep(300);
            Console.WriteLine("Paper...");
            Thread.Sleep(300);
            Console.WriteLine("Scissors...");
            Console.WriteLine("Put a number from 1 to 3 to choose your sign. 1. Rock 2. Paper or 3. Scissors");
            Console.ReadLine();
            Console.WriteLine("Shoot!");
            Console.ReadLine();
        }
    }
}
