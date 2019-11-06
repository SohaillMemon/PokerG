using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerG
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawCards.DrawCardOutline(0, 0);

            Card card = new Card();
            card.MySuit = Card.SUIT.HEARTS;
            card.MyValue = Card.VALUE.ACE;
            DrawCards.DrawCardSuitValue(card, 0, 0);

            Console.ReadKey();
        }
    }
}
