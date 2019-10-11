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
            string again;
            int score = 0;
            int botscore = 0;
            Random random = new Random();
            int bot = random.Next(1, 3);
            Console.WriteLine("Hello, let's play rock, paper, scissors. I'll start. We show the sign when I say 'Shoot'.");
            Console.WriteLine("Are you ready?");
            Thread.Sleep(500);
        question:
            {
                Console.WriteLine("Yes/No");
                rdy = Console.ReadLine().ToUpper();
            }
            //a bit of code asking if the user is ready for a game
            if (rdy == "YES")
            {
                Console.WriteLine("Let's start now. Click enter to start.");
                Console.ReadLine();
            }
            else if (rdy == "NO")
            {
                Console.WriteLine("Hurry up then, my friend!");
                Thread.Sleep(500);
                Console.WriteLine("Ready now? I'll assume you are");

                Console.WriteLine("Click enter to play the game");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You're supposed to answer either 'yes' or 'no'");
                goto question;
            }
        Game:
            {
                Console.WriteLine("Rock...");
                Thread.Sleep(500);
                Console.WriteLine("Paper...");
                Thread.Sleep(500);
                Console.WriteLine("Scissors...");
                Thread.Sleep(500);
                Console.WriteLine("Put a number from 1 to 3 to choose your sign. 1. Rock 2. Paper or 3. Scissors");
                selection = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(500);
                Console.WriteLine("Shoot!");
                Thread.Sleep(500);
                Console.WriteLine("Click enter to see the result, and enter again to see the score and choose if you want to try again");
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
                    Console.WriteLine("Draw! You both chose {0}. Nobody wins.", sign);
                    Console.ReadLine();
                }
                else if (sign == "rock" && botselection == "paper")
                {
                    Console.WriteLine("You:{0} - Opponent: {1}. You lose!", sign, botselection);
                    Console.ReadLine();
                    botscore++;
                }
                else if (sign == "paper" && botselection == "scissors")
                {
                    Console.WriteLine("You:{0} Opponent: {1}. You lose!", sign, botselection);
                    Console.ReadLine();
                    botscore++;
                }
                else if (sign == "scissors" && botselection == "rock")
                {
                    Console.WriteLine("You:{0} Opponent: {1}. You lose!", sign, botselection);
                    Console.ReadLine();
                    botscore++;

                }
                else if (sign == "rock" && botselection == "scissors")
                {
                    Console.WriteLine("You:{0} Opponent: {1}. You win!", sign, botselection);
                    Console.ReadLine();
                    score++;
                }
                else if (sign == "paper" && botselection == "rock")
                {
                    Console.WriteLine("You:{0} Opponent: {1}. You win!", sign, botselection);
                    Console.ReadLine();
                    score++;
                }
                else if (sign == "scissors" && botselection == "paper")
                {
                    Console.WriteLine("You:{0} Opponent: {1}. You win!", sign, botselection);
                    Console.ReadLine();
                    score++;
                }
            
            }
        again:
            {
                Console.WriteLine("The score is '{0}':'{1}'. Would you like to try again?", score, botscore);
                rdy = Console.ReadLine().ToUpper();
                if (rdy == "YES")
                {
                    goto Game;
                }
                else if (rdy == "NO")
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Answer with either yes, or no");
                    goto again;
                }

            }

            
        }
    }
    
}
