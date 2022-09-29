using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10CardLib
{
    public class Card
    {
        public Rank rank;
        public Suit suit;

        public Card()
        {
           
        }

        public Card(Suit newSuit, Rank newRank)
        {
           suit = newSuit;
            rank = newRank;
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}