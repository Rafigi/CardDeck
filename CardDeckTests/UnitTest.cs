using System.Collections.Generic;
using CardDeck.Models;
using CardDeck.Services;
using Xunit;

namespace CardDeckTests
{
    public class UnitTest
    {
        [Fact]
        public void BuildCardDeck()
        {
            ICardService cardService = new CardService();
            List<Card> cards = cardService.CardDeckCollectionBuilder();
            Assert.Equal(55, cards.Count);
        }


        [Fact]
        public void PickRandomCard()
        {
            ICardService cardService = new CardService();
            Card card = cardService.PickARandomCard();

            Assert.NotNull(card);
        }
    }
}
