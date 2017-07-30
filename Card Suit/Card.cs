using System;

public class Card : IComparable<Card>
{
    private Suit suit;
    private Rank rank;

    public Card(Suit suit, Rank rank)
    {
        this.suit = suit;
        this.rank = rank;
    }

    private int CalcPower()
    {
        int suitPower = 0;
        switch (this.suit)
        {
            case Suit.Clubs:
                suitPower = (int)Suit.Clubs;
                break;

            case Suit.Hearts:
                suitPower = (int)Suit.Hearts;
                break;

            case Suit.Diamonds:
                suitPower = (int)Suit.Diamonds;
                break;

            case Suit.Spades:
                suitPower = (int)Suit.Spades;
                break;
        }
        int totalPower = (int)this.rank + suitPower;
        return totalPower;
    }

    public override string ToString()
    {
        return $"{this.rank} of {this.suit}";
    }

    public int CompareTo(Card other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var suitComparison = suit.CompareTo(other.suit);
        if (suitComparison != 0) return suitComparison;
        return rank.CompareTo(other.rank);
    }
}