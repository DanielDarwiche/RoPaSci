using System;
using System.Threading;

namespace RoPaSci
{
    class Program
    {
        static void Main(string[] args)
        {
            Random foe = new Random();
            int enemy = foe.Next(1, 3);//Creates Random Foe which generates 1/2/3 
            //Lets say Rock is 1
            //Paper is 2
            //Scissor is 3
            int wins = 0, amo=0, lost=0,draw=0;
            bool itsFun = true;
            string display = "";
            string disEnemy = "";
            do
            {
                Console.WriteLine("---ROCK * PAPER * SCISSOR---:\n");
                Console.WriteLine("1.Rock\n2.Paper\n3.Scissor\n\nEnter a number to play!");
                int c = 7;
                try
                {
                    c = int.Parse(Console.ReadLine()); Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("\nWrong input. \nPlease enter choice 1,2 or 3");
                }
                if (c == 1)
                {
                    display = "Rock";
                }
                else if (c == 2)
                {
                    display = "Paper";
                }
                else if (c == 3)
                {
                    display = "Scissor";
                }if (enemy == 1)
                {
                    disEnemy = "Rock";
                }
                else if (enemy == 2)
                {
                    disEnemy = "Paper";
                }
                else if (enemy == 3)
                {
                    disEnemy = "Scissor";
                }
                if (c == 1 && enemy == 1 || c == 2 && enemy == 2 || c == 3 && enemy == 3)
                {//both enter the same choice
                    Console.WriteLine($"You entered {display} and I entered {disEnemy}");
                    Console.WriteLine("It´s a draw!");
                    amo++;draw++;
                }
                else if (c == 1 && enemy == 3 || c == 2 && enemy == 1 || c == 3 && enemy == 2)
                {//if player wins
                    Console.WriteLine($"You entered {display} and I entered {disEnemy}");
                    Console.WriteLine("You Won!");
                    wins++;
                    amo++;
                }
                else if (c == 1 && enemy == 2 || c == 2 && enemy == 3 || c == 3 && enemy == 1)
                {//if player loses
                    Console.WriteLine($"You entered {display} and I entered {disEnemy}");
                    Console.WriteLine("You lost!");
                    amo++;lost++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input. \nPlease enter choice 1,2 or 3"); 
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nWins: {wins}\nLost:{lost}\nDraws:{draw}\nPlayed games: {amo}");
                Console.WriteLine("\nPress any key to continue");Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
            } while (itsFun == true);
        }
    }
}
