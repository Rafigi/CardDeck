using System;
using System.Collections.Generic;
using System.Linq;
using CardDeck.Helpers;
using CardDeck.Models;

namespace CardDeck.Services
{
    public class CardService : ICardService
    {
        public Card PickARandomCard()
        {
            var cardCollection = CardDeckCollectionBuilder();
            var randomNumber = GetRandomNumber(cardCollection.Count);
            Card cardFound = cardCollection.ElementAtOrDefault(randomNumber);

            if (cardFound == null)
                throw new NullReferenceException($"None card was found on the index: {randomNumber}");


            return cardFound;
        }

        public List<Card> CardDeckCollectionBuilder()
        {
            List<Card> cardCollection = new List<Card>();
            cardCollection.AddJokers(3);

            for (int i = 0; i < CardHelper.CardTypes().Length; i++)
            {
                for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
                {
                    string cardType = CardHelper.CardTypes()[i];
                    Card card;
                    switch (cardNumber)
                    {
                        case 1:
                            card = new Card()
                            {
                                Type = cardType,
                                Value = "Ace"
                            };
                            break;
                        case 11:
                            card = new Card()
                            {
                                Type = cardType,
                                Value = "Jack"
                            };
                            break;
                        case 12:
                            card = new Card()
                            {
                                Type = cardType,
                                Value = "Queen"
                            };
                            break;
                        case 13:
                            card = new Card()
                            {
                                Type = cardType,
                                Value = "King"
                            };
                            break;
                        default:
                            card = new Card()
                            {
                                Type = cardType,
                                Value = cardNumber.ToString()
                            };
                            break;

                    }
                    cardCollection.Add(card);
                }
            }
            return cardCollection;
        }

        private int GetRandomNumber(int maxValue)
        {
            return new Random().Next(0, maxValue);
        }
    }
}
