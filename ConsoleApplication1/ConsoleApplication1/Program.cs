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
            string sign;
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
                Console.WriteLine("Hurry up then, my friend!");
                Console.ReadLine();
            }

            Console.WriteLine("Rock...");
            Thread.Sleep(300);
            Console.WriteLine("Paper...");
            Thread.Sleep(300);
            Console.WriteLine("Scissors...");
            Console.WriteLine("Put a number from 1 to 3 to choose your sign. 1. Rock 2. Paper or 3. Scissors");
            selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Shoot!");
            Console.ReadLine();
            switch (selection)
            {
                case 1:
                    sign = "rock";
                    break;
                case 2:
                    sign = "paper";
                    break;
                case 3:
                    sign = "scissors";
                    break;
                default:
                    sign = "";
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
            if (sign == botselection)
            {
                Console.WriteLine("Draw! Nobody wins");
                Console.ReadLine();
            }
            else if (sign == "rock" || botselection == "paper")
            {
                Console.WriteLine("You lose!");
                Console.ReadLine();
                botscore++;
            }
            else if (sign == "paper" || botselection == "scissors")
            {
                Console.WriteLine("You lose!");
                Console.ReadLine();
                botscore++;
            }
            else if (sign == "scissors" || botselection == "rock")
            {
                Console.WriteLine("You win!");
                    Console.ReadLine();
                botscore++;

            }
            else if (sign == "rock" || botselection == "scissors")
            {
                Console.WriteLine("You win!");
                    Console.ReadLine();
                score++;
            }
            else if (sign == "paper" || botselection == "rock")
            {
                Console.WriteLine("You win!");
                Console.ReadLine();
                score++;
            }
            else if (sign == "scissors" || botselection == "paper")
            {
                Console.WriteLine("You win!");
                Console.ReadLine();
                score++;
            }

        }
    }
}
