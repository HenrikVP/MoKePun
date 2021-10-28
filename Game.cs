using System;
using System.Collections.Generic;

namespace MoKePun
{
    internal class Game
    {
        public void Start()
        {
            List<Card> P1Deck = new List<Card>();
            P1Deck = AddCards(P1Deck);
            List<Card> P2Deck = new List<Card>();
            P2Deck = AddCards(P2Deck);

            Card c1, c2;
            do { c1 = ChooseCard(P1Deck); } while (c1 == null);
            do { c2 = ChooseCard(P2Deck); } while (c2 == null);

            Console.WriteLine($"Player 1 have selected: {c1.Name}");
            Console.WriteLine($"Player 2 have selected: {c2.Name}");
            Console.ReadKey();
        }

        private Card ChooseCard(List<Card> CardDeck)
        {
            foreach (Card card in CardDeck)
            {
                Console.WriteLine(
                    $"Nr:{CardDeck.IndexOf(card)}\nNavn:{card.Name}\nType:{card.Type}\nHP:{card.HitPoints}\n");
            }

            ConsoleKey ck = Console.ReadKey(true).Key;

            switch (ck)
            {
                case ConsoleKey.NumPad0:
                    ShowInput(ck);
                    return CardDeck[0];
                case ConsoleKey.NumPad1:
                    ShowInput(ck);
                    return CardDeck[1];
                case ConsoleKey.NumPad2:
                    ShowInput(ck);
                    return CardDeck[2];
                case ConsoleKey.NumPad3:
                    ShowInput(ck);
                    return CardDeck[3];
                default:
                    return null;
            }
        }

        void ShowInput(ConsoleKey ck)
        {
            Console.WriteLine("You have selected: " + ck);
        }

        void CombatEngine(Card Player1, Card Player2)
        {
        }
        public List<Card> AddCards(List<Card> cards)
        {
            Card card1 = new Card()
            {
                Name = "Imoen",
                HitPoints = 100,
                Type = CharacterType.Thief
            };
            Card card2 = new Card()
            {
                Name = "Jon Snow",
                HitPoints = 100,
                Type = CharacterType.Fighter
            };
            Card card3 = new Card()
            {
                Name = "Gandalf",
                HitPoints = 100,
                Type = CharacterType.Wizard
            };
            Card card4 = new Card()
            {
                Name = "Captain Birdseye",
                HitPoints = 100,
                Type = CharacterType.Priest
            };

            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);

            return cards;
        }
    }




}
