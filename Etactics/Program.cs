using System;

namespace Etactics
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Deck deck = new Deck(); 

            Console.WriteLine("Welcome");

            bool deal = true;
            while (deal)
            {
            Console.WriteLine("Press D for amount of cards in deck");
            Console.WriteLine("Press S to shuffle the deck");
            Console.WriteLine("Press R to sort the deck by rank");
            Console.WriteLine("Press L to sort the deck by suit then rank");
            string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "d":
                        Console.Clear();
                        Console.WriteLine();
                        deck.TotalInDeck();
                        Console.WriteLine();
                        break;

                    case "s":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Shuffled Deck");
                        Console.WriteLine();
                        deck.ShuffleDeck();
                        Console.WriteLine();
                        break;

                    case "r":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Sorted by Rank");
                        Console.WriteLine();
                        deck.SortByRank();
                        Console.WriteLine();
                        break;

                    case "l":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Sorted by Suit and Rank");
                        Console.WriteLine();
                        deck.DeckSuitRank();
                        Console.WriteLine();
                        break;

                    default:
                        break;

                }

            }
        }
    }
}
