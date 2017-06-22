using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftWiseCodeChallenge
{
  public class Deck
    {

        public List<Card> DeckList { get; set; }
      
        /// <summary>
        /// This method adds all 52 standard playing cards to the deck
        /// </summary>
        public void FillDeck()
        {
            DeckList = new List<Card>();

            //iterate through each suit
            foreach(int suitValue in Enum.GetValues(typeof(Card.Suit)))
            {
                //iterate through each face value for the current suit
                foreach(int faceValue in Enum.GetValues(typeof(Card.FaceValue)))
                    {
                    //add the new card to the deck
                    var newCard = new Card(suitValue, faceValue);
                  
                    DeckList.Add(newCard);
                }   
            }
        }
        /// <summary>
        /// Randomly sorts the DeckList
        /// </summary>
        public void ShuffleDeck()
        {
            Random rng = new Random();
            var count = DeckList.Count;
            //perform a shuffle on the cards by swapping list positions randomly, equal to the number of cards in the deck
            while(count > 1)
            {
                count = count - 1;
                var rand = rng.Next(0, count);
                //store the random index temporarily
                var tempCard = DeckList[rand];
                //swap the current index with the random index
                DeckList[rand] = DeckList[count];
                DeckList[count] = tempCard;

            }
        }
        /// <summary>
        /// Sorts the DeckList in ascending order
        /// </summary>
        public void SortDeckAscending()
        {
            //Check to see if we have cards in the deck - if not, add them
            if(DeckList.Count == 0)
            {
                FillDeck();
            }
            //sort by suit and then value for ascending order
            DeckList = DeckList.OrderBy(x => x.CardSuit).ThenBy(y => y.CardFaceValue).ToList();



        }


    }
}
