using System;
using System.Collections.Generic;
namespace Cards2;

public class Deck
{
    private List<Card> cards = new List<Card>();

    // Property to expose deck (read-only)
    public IReadOnlyList<Card> Cards => cards.AsReadOnly();

    // Deck constructor: builds 52 cards
    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(rank, suit));
            }
        }
    }

    // TakeTopCard: remove and return first card, or null if empty
    public Card TakeTopCard()
    {
        if (cards.Count == 0)
        {
            throw new InvalidOperationException("No cards left in the deck.");
        }
        Card topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }

    public List<Card> GetCards()
    {
        return cards;
    }

    // Shuffle
    public void Shuffle()
    {
        Random rng = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }

    // Cut: split deck at index and move bottom half to top
    public void Cut(int index)
    {
        if (index < 0 || index > cards.Count) throw new ArgumentOutOfRangeException();

        List<Card> top = cards.GetRange(0, index);
        List<Card> bottom = cards.GetRange(index, cards.Count - index);

        cards.Clear();
        cards.AddRange(bottom);
        cards.AddRange(top);
    }
    //Optional function for printing the cards available
    public void Print()
    {
        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
}
