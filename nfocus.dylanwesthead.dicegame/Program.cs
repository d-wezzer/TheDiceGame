namespace nfocus.dylanwesthead.dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            game.PlayGame(game.dice1, game.dice2);

            // If player selects to play again, play the game again.
            while (game.PlayAgain(game.dice1, game.dice2) == true)
            {
                game.PlayGame(game.dice1, game.dice2);
            }
        }
    }
}