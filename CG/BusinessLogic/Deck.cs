using CG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.BusinessLogic
{
    class Deck
    {
        Card[] cards = new Card[52];
        string[] numbers = new string[] {"A", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
        public Deck()
        {
            int i = 0;
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Clubs, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Spades, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Hearts, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Diamonds, s);
                i++;

            }
        }

        public Card[] Cards
        {
            get
            {
                return cards;


            }
        }
    }
}


