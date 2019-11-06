using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerG
{
    class DrawCards
    {
        //draw outlines
        public static void DrawCardOutline(int xcoor, int ycoor)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int x = xcoor * 12;
            int y = ycoor;

            Console.SetCursorPosition(x, y);
            Console.Write(" __________\n"); //top edge of the card

            for(int i=0; i<10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 9)
                    Console.Write("|          |"); //left and right edges of card
                else
                    Console.Write("|__________|"); //bottom edge of the card
            }

        }
        public static void DrawCardSuitValue(Card card, int xcoor, int ycoor )
        {
            char cardSuit = ' ';
            int x = xcoor * 12;
            int y = ycoor;

            //encode each byte array from codepage437 into a character
            // hearts and diamonds are red, spades and clubs are black
            switch(card.MySuit)
            {
                case Card.SUIT.HEARTS:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Card.SUIT.DIAMONDS:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Card.SUIT.CLUBS:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case Card.SUIT.SPADES:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

            }

            //display the char nd value of the card
            Console.SetCursorPosition(x+5, y+5);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(card.MyValue);
        }
    }
}
