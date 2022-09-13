using CardDeck.Models;
using CardDeck.Services;
using Microsoft.AspNetCore.Mvc;

namespace CardDeck.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        public Card Get()
        {
            return _cardService.PickARandomCard();
        }
    }
}
