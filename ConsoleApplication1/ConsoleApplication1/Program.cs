using System;
using System.Threading;
/*MORE DETAIL*/

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rdy;
            int selection;
            string rock;
            string paper;
            string scissors;
            int score = 0;
            Boolean outcome;
            Random random = new Random();
            int RandomNumber = random.Next(1, 3);
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
                    break;
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
