using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerG
{
    class DeckOfCards : Card
    {
        const int Num_of_Cards = 52; //no. of playing cards
        private Card[] deck; //array of all playing cards

        public DeckOfCards()
        {
            deck = new Card[Num_of_Cards];
        }

        public Card[] getDeck { get { return deck; } } //get current Deck

        // create deck of 52 cards: 13 values each,with 4 suits

        public void setUpDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            //shuffle the cards 1000 times
            for(int shuffleTimes =0; shuffleTimes <  1000; shuffleTimes++)
            {
                for(int i =0; i < Num_of_Cards; i++ )
                {
                    //swap the cards
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = deck[i];

                }
            }
             
        }
    }
}
