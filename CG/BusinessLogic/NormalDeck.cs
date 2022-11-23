using CG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.BusinessLogic
{
    class NormalDeck : Deck
    {
        private Card[] Card;

        public enum Suites
        {
            Hearts,
            Diamonds,
            Spades,
            Clover
        };

        // Same comment as above. 
        public enum Values
        { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

        public void NewNormalDeck()
        {
            // Clear the deck of cards
            if (this.Cards != null)
            {
                Array.Clear(this.Cards, 0, this.Cards.Length);
            }

            //Set Value to length of Normal deck of Cards without Jokers 
            Card = new Card[52];

            // to keep count of which card we are.  
            int curNumofCards = 0;

            // Cycle through all of the suites listed in "suites" then all the values of     that suite
            for (int x = 0; x < Enum.GetValues(typeof(Suites)).GetLength(0); x++)
            {
                for (int y = 0; y < Enum.GetValues(typeof(Values)).GetLength(0); y++)
                {
                    Card newCard = new Card();
                    newCard.Suite = x;
                    newCard.value = y;
                    this.Cards[curNumofCards] = newCard;
                    curNumofCards++;
                }
            }
        }
    }
}
