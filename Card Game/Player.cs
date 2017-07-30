using System.Collections.Generic;
using System.Linq;

public class Player
{
    private ICollection<Card> hand;

    public Player(string name)
    {
        this.Name = name;
        this.hand = new List<Card>(5);
    }

    public string Name { get; set; }

    public IEnumerable<Card> Hand
    {
        get
        {
            return this.hand;
        }
    }

    public int HandSize
    {
        get
        {
            return this.hand.Count;
        }
    }

    public Card HighestCard
    {
        get
        {
            return this.Hand.OrderBy(x => x.Power).LastOrDefault();
        }
    }

    public void AddCard(Card card)
    {
        this.hand.Add(card);
    }
}