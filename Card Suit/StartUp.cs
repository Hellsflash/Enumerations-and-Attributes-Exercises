using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var deck = new Deck();
        foreach (var card in deck)
        {
            Console.WriteLine(card);
        }
    }
}