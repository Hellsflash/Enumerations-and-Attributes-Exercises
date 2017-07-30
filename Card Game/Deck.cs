using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Deck : IEnumerable<Card>
{
    private ICollection<Card> cards;

    public Deck()
    {
        this.cards = new List<Card>();

        var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
        var ranks = Enum.GetValues(typeof(Rank)).Cast<Rank>();

        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                this.cards.Add(new Card(suit, rank));
            }
        }
    }

    public int Count => this.cards.Count;

    public IEnumerator<Card> GetEnumerator()
    {
        foreach (var card in cards)
        {
            yield return card;
        }
    }

    public void DrawCard(Card card)
    {
        this.cards.Remove(card);
    }

    public bool Contains(Card card)
    {
        return this.cards.Contains(card);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}