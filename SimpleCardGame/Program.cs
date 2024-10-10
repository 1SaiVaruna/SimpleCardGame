namespace SimpleCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            for(int i = 0; i < 2; i++)
            {
                player1.AddCard(deck.DrawCard());
                player2.AddCard(deck.DrawCard());
            }

            player1.ShowHand();
            player1.Score();

            player2.ShowHand();
            player2.Score();

            Console.ReadKey();
        }
    }
}
