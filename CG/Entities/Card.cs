using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.Entities
{

    //public class Card
    //{
    //    public Suit Suit { get; set; }
    //    public CardValue CardValue { get; set; }
    //}

    //public enum CardValue
    //{
    //    Ace = 1,
    //    Two = 2,
    //    Three = 3,
    //    Four = 4,
    //    Five = 5,
    //    Six = 6,
    //    Seven = 7,
    //    Eight = 8,
    //    Nine = 9,
    //    Ten = 10,
    //    Jack = 11,
    //    Queen = 12,
    //    King = 13
    //}

    //public enum Suit
    //{
    //    Clubs,
    //    Hearts,
    //    Spades,
    //    Dimonds
    //}

    class Card
    {
        public int value { get; set; }

        public int suite { get; set; }
    }


    abstract class Deck
    {
        public Card[] cards
        { get; set; }

        public void ShuffleCards(int timesToShuffle)
        {
            Card temp;
            Random random = new Random();
            // int timesToShuffle = random.Next(300, 600); //Had it setup for random shuffle
            int cardToShuffle1, cardToShuffle2;

            for (int x = 0; x < timesToShuffle; x++)
            {
                cardToShuffle1 = random.Next(this.cards.Length);
                cardToShuffle2 = random.Next(this.cards.Length);
                temp = this.cards[cardToShuffle1];

                this.cards[cardToShuffle1] = this.cards[cardToShuffle2];
                this.cards[cardToShuffle2] = temp;
            }
        }
    }
}

