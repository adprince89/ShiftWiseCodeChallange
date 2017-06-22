using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftWiseCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.FillDeck();
            Console.Out.WriteLine("I have " + deck.DeckList.Count + " cards.");
            deck.ShuffleDeck();
            Console.Out.WriteLine("I have shuffled the cards.");
            deck.SortDeckAscending();
            Console.Out.WriteLine("I have sorted the cards.");
      
        }
    }
}
