using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Santase.Logic.Cards;

namespace Deck.nUnitTests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void InitialiasingDeckAndHasAllCardsInIt()
        {
            Santase.Logic.Cards.Deck deck = new Santase.Logic.Cards.Deck();
            Assert.AreEqual(24,deck.CardsLeft, "There are not 24 cards!");
        }

        [Test]
        public void TrumpCardCanBeChanged()
        {
            Santase.Logic.Cards.Deck deck = new Santase.Logic.Cards.Deck();
            var changeCard = new Card(CardSuit.Club, CardType.Ace);
            deck.ChangeTrumpCard(changeCard);
            var expectedCard = new Card(CardSuit.Club, CardType.Ace);
            Assert.AreEqual(expectedCard, changeCard, "The trump card is not as expected!");
        }
    }
}
