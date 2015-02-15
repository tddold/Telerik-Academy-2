using System;

//Problem 4. Print a Deck of 52 Cards
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

class PrintaDeckof52Cards
{
    static void Main()
    {
        char[] cards = { '\u2663', '\u2666', '\u2665', '\u2660' };
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                switch (i)
                {
                    case 2:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 3:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 4:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 5:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 6:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 7:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 8:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 9:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 10:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 11:
                        Console.Write("J{1}", i, cards[j]);
                        break;
                    case 12:
                        Console.Write("Q{1}", i, cards[j]);
                        break;
                    case 13:
                        Console.Write("K{1}", i, cards[j]);
                        break;
                    case 14:
                        Console.Write("A{0}", cards[j]);
                        break;
                    default:
                        Console.Write("Default case");
                        break;                        
                }
                if (j == 3)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}
