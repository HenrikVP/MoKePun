namespace MoKePun
{
    internal class Game
    {
        internal void Start()
        {
            //Vi opretter to tomme lister af typen Card
            List<Card> P1Deck = new List<Card>();
            List<Card> P2Deck = new List<Card>();
            //Vi kalder vores AddCards metode, og returnerer en liste 
            //som består af vores 4 characters.
            P1Deck = AddCards(P1Deck);
            P2Deck = AddCards(P2Deck);

            //Vi opretter 2 nye objekter udenfor vores do scope, fordi
            //at do scopet er for lokalt til at vi kan checke på variablen
            //i vores while check
            Card activeCardP1, activeCardP2;
            do { activeCardP1 = ChooseCard(P1Deck); } while (activeCardP1 == null);
            do { activeCardP2 = ChooseCard(P2Deck); } while (activeCardP2 == null);

            Console.WriteLine($"Player 1 have selected: {activeCardP1.Name}");
            Console.WriteLine($"Player 2 have selected: {activeCardP2.Name}");
            Console.ReadKey();
        }

        //ChooseCard modtager en liste af kort og returnerer et enkelt kort
        private Card ChooseCard(List<Card> CardDeck)
        {
            //Vi udskriver på skærmen, med nummer, navn, type og HP
            foreach (Card card in CardDeck)
            {
                Console.WriteLine(
                    $"Nr:{CardDeck.IndexOf(card)}\nNavn:{card.Name}\nType:{card.Type}\nHP:{card.HitPoints}\n");
            }

            Console.WriteLine("Choose your card wisely (Numpad 0-3): ");

            //Modtager et tasteturtryk og laver en switch/case
            ConsoleKey ck = Console.ReadKey(true).Key;

            //switchen checker på casen, og hvis de er identiske køres koden efter
            //kolonnet og indtil en evt. break eller return
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
            //Her ville den ende hvis vi brugte break istedet for return
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
