using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShiftWiseCodeChallenge;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ShiftWiseCodeChallengeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFillDeck()
        {
            int count = 52;
            Deck testDeck = new Deck();
            testDeck.FillDeck();
            //check that we have 52 cards in the deck
            Assert.AreEqual(count, testDeck.DeckList.Count, 0, "Deck does not have the required number of cards.");
            //check that we have 52 distinct cards
            var distinctCards = testDeck.DeckList.Distinct().ToList().Count;
            Assert.AreEqual(count, distinctCards, 0, "Deck has duplicate cards");
            

        }

       [TestMethod]
       public void TestShuffle()
        {

            Deck controlDeck = new Deck();
            controlDeck.FillDeck();  
            Deck shuffledDeck = new Deck();
            shuffledDeck.FillDeck();
            //shuffle the deck and compare to the unshuffled deck
            shuffledDeck.ShuffleDeck();
            int sameLocationCount = 0;
            //set the maximum number of cards to be left in the same position for this test to pass
            int sufficientRandomizationDelta = 10;
            //check our shuffled deck vs the control to determine if the order has been changed
            foreach(var card in shuffledDeck.DeckList)
            {            
                var controlCard = controlDeck.DeckList.Where(x => x.CardSuit == card.CardSuit && x.CardFaceValue == card.CardFaceValue).FirstOrDefault();
                if (shuffledDeck.DeckList.IndexOf(card) == controlDeck.DeckList.IndexOf(controlCard))
                {
                    sameLocationCount++;
                }
            }
            Assert.AreEqual(0, sameLocationCount, sufficientRandomizationDelta, "Shuffle is not randomizing sufficiently");


        }
        [TestMethod]
      public void TestOrderAscending()
        {
            //assuming the deck is instantiated in order
            Deck controlDeck = new Deck();
            controlDeck.FillDeck();
            //fill our deck to be tested, then shuffle it
            Deck orderedDeck = new Deck();
            orderedDeck.FillDeck();
            orderedDeck.ShuffleDeck();
            orderedDeck.SortDeckAscending();
            int sameLocationCount = 52;
            foreach (var card in orderedDeck.DeckList)
            {
                var controlCard = controlDeck.DeckList.Where(x => x.CardSuit == card.CardSuit && x.CardFaceValue == card.CardFaceValue).FirstOrDefault();
                if (orderedDeck.DeckList.IndexOf(card) != controlDeck.DeckList.IndexOf(controlCard))
                {
                    sameLocationCount--;
                }
            }
            Assert.AreEqual(52, sameLocationCount, 0, "Deck is not ordering correctly.");




        }
    }
}
