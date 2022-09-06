namespace nfocus.dylanwesthead.dicegame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            game.PlayGame(game.dice1, game.dice2);
        }
    }
}