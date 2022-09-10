using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nfocus.dylanwesthead.dicegame
{
    internal class Game
    {
        public Dice dice1, dice2;

        /*
         * This method starts and configures the game.
         * 
         */
        public void StartGame()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~ WELCOME TO THE DICE GAME! ~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nRoll 2 dices and the highest total score wins.");
            Console.WriteLine("Enter the number of sides you would like for each dice, the default is 6.");

            string input = Console.ReadLine();
            int numOfSides;

            // If input is a number.
            if (int.TryParse(input, out numOfSides))
            {
                Console.WriteLine($"The dice will have {numOfSides} sides.");
                dice1 = new Dice(numOfSides);
                dice2 = new Dice(numOfSides);
            }
            // If the input is not a number.
            else
            {
                Console.WriteLine("\"" + input + "\" is not a number. Proceeding with the default setting.");
                dice1 = new Dice();
                dice2 = new Dice();
            }

        }


        /*
         * The method used to play the actual game. 
         * Handles rolling the dice and calls the AnnounceWinner and PlayAgain methods.
         */
        public void PlayGame(Dice dice1, Dice dice2)
        {
            Console.WriteLine("\nIt is your turn:");
            dice1.throwDice();
            dice2.throwDice();
            int yourScore = dice1.diceNumber + dice2.diceNumber;
            Console.WriteLine($"You threw a {dice1.diceNumber} and a {dice2.diceNumber}.\nYou're total score is {yourScore}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\nIt is the computers turn:");
            dice1.throwDice();
            dice2.throwDice();
            int compScore = dice1.diceNumber + dice2.diceNumber;
            Console.WriteLine($"The computer threw a {dice1.diceNumber} and a {dice2.diceNumber}.\nTheir total score is {compScore}");

            AnnounceWinner(yourScore, compScore);
        }

        /*
         * The method to calculate and announce the winner.
         * 
         */
        public void AnnounceWinner(int yourScore, int compScore)
        {
            int difference = Math.Abs(yourScore - compScore);
            if (difference == 0) { Console.WriteLine($"\nIt was a tie, you both scored {yourScore}!"); }
            else
            {
                Console.WriteLine(yourScore > compScore ? $"\nCongratulations you won by {difference} points!" : "Oh no, you " +
                    $"lost by {difference} points!");
            }
        }

        /*
        * This method provides a Y/N prompt to allow the user to play again.
        * 
        */
        public Boolean PlayAgain(Dice dice1, Dice dice2)
        {
            string answer;
            do
            {
                Console.WriteLine("\nPlay Again? (Y/N)");
                answer = Console.ReadLine();
            } while (answer.ToUpper() != "Y" && answer.ToUpper() != "N");

            // If yes, return true.
            if (answer.ToUpper() == "Y") { return true; }
            // If no, say goodbye.
            else { Console.WriteLine("\nThankyou for playing, goodbye!"); return false; }
        }
    }
}
