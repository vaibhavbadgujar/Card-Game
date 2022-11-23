using CG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.BusinessLogic
{
    class Card
    {
        protected Suits suit;
        protected string cardvalue;
        internal int value;
        internal int Suite;

        public Card()
        {
        }
        public Card(Suits suit2, string cardvalue2)
        {
            suit = suit2;
            cardvalue = cardvalue2;
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}", cardvalue, suit);
        }
    }
}

