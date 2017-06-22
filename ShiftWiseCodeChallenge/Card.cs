using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftWiseCodeChallenge
{
  public class Card
    {

        public Card(int _suit, int _faceValue)
        {

            CardSuit = (Suit)_suit;
            CardFaceValue = (FaceValue)_faceValue;
           
        }

        public enum Suit
        {
            Clubs = 0,
            Diamonds = 1,
            Hearts = 2,
            Spades = 3
        }


        public enum FaceValue
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }

        public Suit CardSuit { get; set; }

        public FaceValue CardFaceValue { get; set; }



    }
}
