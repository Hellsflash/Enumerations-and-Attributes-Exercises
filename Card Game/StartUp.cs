using System;

public class StartUp
{
    public static void Main()
    {
        var firstPlayer = Console.ReadLine();
        var secondPlayer = Console.ReadLine();

        var playerOne = new Player(firstPlayer);
        var playerTwo = new Player(secondPlayer);
        var deck = new Deck();

        var cardInput = Console.ReadLine();

        while (playerOne.HandSize < 5)
        {
            var cardInfo = cardInput.Split();
            try
            {
                var rank = (Rank)Enum.Parse(typeof(Rank), cardInfo[0]);
                var suit = (Suit)Enum.Parse(typeof(Suit), cardInfo[2]);

                var card = new Card(suit, rank);

                if (deck.Contains(card))
                {
                    deck.DrawCard(card);
                    playerOne.AddCard(card);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No such card exists.");
            }

            cardInput = Console.ReadLine();
        }

        while (playerTwo.HandSize < 5)
        {
            var cardInfo = cardInput.Split();
            try
            {
                var rank = (Rank)Enum.Parse(typeof(Rank), cardInfo[0]);
                var suit = (Suit)Enum.Parse(typeof(Suit), cardInfo[2]);

                Card card = new Card(suit, rank);

                if (deck.Contains(card))
                {
                    deck.DrawCard(card);
                    playerTwo.AddCard(card);
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No such card exists.");
            }

            cardInput = Console.ReadLine();
        }

        if (playerOne.HighestCard.CompareTo(playerTwo.HighestCard) > 0)
        {
            Console.WriteLine($"{playerOne.Name} wins with { playerOne.HighestCard}.");
        }
        else
        {
            Console.WriteLine($"{playerTwo.Name} wins with {playerTwo.HighestCard}.");
        }
    }
}