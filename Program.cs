using Cards2;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my card game! Press any key to continue...");
        Console.ReadKey();

        Deck testDeck = new Deck();
        Console.WriteLine("Created a new deck.\n");

        testDeck.Shuffle();
        Console.WriteLine("Shuffled the deck.\n");

        testDeck.Cut(2);
        Console.WriteLine("Cut the deck.");

        Card topCard = testDeck.TakeTopCard();
        Console.WriteLine($"Top card: {topCard}\n");

        Console.WriteLine("Remaining cards in the deck:\n");
        foreach (Card card in testDeck.GetCards())
        {
            Console.WriteLine(card);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
