using System.Collections.Generic;
using CardDeck.Models;

namespace CardDeck.Helpers
{
    public static class CardHelper
    {
        public static void AddJokers(this List<Card> cardCollection, int number)
        {
            for (int i = 0; i < number; i++)
            {
                var card = new Card()
                {
                    Type = "Joker",
                    Value = "Joker"
                };
                cardCollection.Add(card);
            }
        }
        public static string[] CardTypes() => new[] { "Club", "Diamond", "Heart", "Spade" };
    }
}
