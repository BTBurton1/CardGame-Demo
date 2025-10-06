using System;
using System.Collections.Generic;
namespace Cards2;

public class Card_valu
{
    public int Value { get; set; }
}

public class Player
{
    private List<Card> hand = new List<Card>();

    public void AddCard(Card card)
    {
        hand.Add(card);
    }

    public Card RemoveCard(int index)
    {
        if (!CheckIndex(index))
            throw new ArgumentOutOfRangeException("Invalid index");

        Card removed = hand[index];
        hand.RemoveAt(index);
        return removed;
    }

    public int GetNumOfCards()
    {
        return hand.Count;
    }

    public bool HasCards()
    {
        return hand.Count > 0;
    }

    public bool CheckIndex(int index)
    {
        return index >= 0 && index < hand.Count;
    }

    public void DisplayCards()
    {
        Console.Write("Player's cards: ");
        foreach (var card in hand)
        {
            Console.Write($"{card.Rank} of {card.Suit}  ");
        }
        Console.WriteLine();
    }

    public void SortCards()
    {
        // Assuming Card implements IComparable or Compare by Rank/Suit
        hand.Sort((a, b) => a.Rank.CompareTo(b.Rank));
    }

    public List<Card> GetHand()
    {
        return hand;
    }
}
