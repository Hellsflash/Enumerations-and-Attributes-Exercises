using System;

public class Card : IComparable<Card>
{
    public Card(Suit suit, Rank rank)
    {
        this.Suit = suit;
        this.Rank = rank;
        this.Power = (int)this.Suit + (int)this.Rank;
    }

    public Rank Rank { get; private set; }
    public Suit Suit { get; private set; }
    public int Power { get; private set; }

    public int CompareTo(Card other)
    {
        return this.Power.CompareTo(other.Power);
    }

    public override int GetHashCode()
    {
        return (int)this.Rank + (int)this.Suit;
    }

    public override bool Equals(object obj)
    {
        Card other = obj as Card;

        if (this.Suit != other.Suit)
        {
            return false;
        }

        if (this.Rank != other.Rank)
        {
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        return string.Format($"{this.Rank} of {this.Suit}");
    }
}