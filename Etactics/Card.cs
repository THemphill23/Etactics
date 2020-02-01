using System;
using System.Collections.Generic;
using System.Text;

namespace Etactics
{
    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }


        public Card()
        {

        }

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public void CardInfo()
        {
            Console.WriteLine($"{Rank} of {Suit}");
        }
    }
}
