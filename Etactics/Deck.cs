using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etactics
{
    public class Deck
    {
        public List<Card> CardsInDeck = new List<Card>()
        {
            new Card("Ace","Hearts"),
            new Card("Two","Hearts"),
            new Card("Three","Hearts"),
            new Card("Four","Hearts"),
            new Card("Five","Hearts"),
            new Card("Six","Hearts"),
            new Card("Seven","Hearts"),
            new Card("Eight","Hearts"),
            new Card("Nine","Hearts"),
            new Card("Ten","Hearts"),
            new Card("Jack","Hearts"),
            new Card("Queen","Hearts"),
            new Card("King","Herts"),
            new Card("Ace","Clubs"),
            new Card("Two","Clubs"),
            new Card("Three","Clubs"),
            new Card("Four","Clubs"),
            new Card("Five","Clubs"),
            new Card("Six","Clubs"),
            new Card("Seven","Clubs"),
            new Card("Eight","Clubs"),
            new Card("Nine","Clubs"),
            new Card("Ten","Clubs"),
            new Card("Jack","Clubs"),
            new Card("Queen","Clubs"),
            new Card("King","Clubs"),
            new Card("Ace","Diamonds"),
            new Card("Two","Diamonds"),
            new Card("Three","Diamonds"),
            new Card("Four","Diamonds"),
            new Card("Five","Diamonds"),
            new Card("Six","Diamonds"),
            new Card("Seven","Diamonds"),
            new Card("Eight","Diamonds"),
            new Card("Nine","Diamonds"),
            new Card("Ten","Diamonds"),
            new Card("Jack","Diamonds"),
            new Card("Queen","Diamonds"),
            new Card("King","Diamonds"),
            new Card("Ace","Spades"),
            new Card("Two","Spades"),
            new Card("Three","Spades"),
            new Card("Four","Spades"),
            new Card("Five","Spades"),
            new Card("Six","Spades"),
            new Card("Seven","Spades"),
            new Card("Eight","Spades"),
            new Card("Nine","Spades"),
            new Card("Ten","Spades"),
            new Card("Jack","Spades"),
            new Card("Queen","Spades"),
            new Card("King","Spades"),
        };

        public void ShuffleDeck()
        {
            List<Card> RandomList = CardsInDeck.OrderBy(x => Guid.NewGuid()).ToList();
            foreach (Card card in RandomList)
                card.CardInfo();
        }

        public void DeckSuitRank()
        {
            foreach (Card card in CardsInDeck)
                card.CardInfo();
        }

        public void SortByRank()
        {
            List<Card> RankedList = CardsInDeck.OrderBy(c => c.Rank).ToList();
            foreach (Card card in RankedList)
                card.CardInfo();
        }

        public void TotalInDeck()
        {
            var number = 0;
            foreach (Card card in CardsInDeck)
                number = number + 1;
            Console.WriteLine(number + " cards in the deck");

        }
    }
}
