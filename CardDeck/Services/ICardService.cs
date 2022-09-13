using System.Collections.Generic;
using System.Threading.Tasks;
using CardDeck.Models;

namespace CardDeck.Services
{
    public interface ICardService
    {
        public Card PickARandomCard();
        public List<Card> CardDeckCollectionBuilder();
    }
}
