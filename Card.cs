namespace MoKePun
{
    //enum er en let måde at identificere ved hjælp af en navn i stedet for et nummer.
    internal enum CharacterType { Thief, Wizard, Fighter, Priest}

    //vores class Card er en object model bestående af 3 properties. 
    //En string, int og enum af typen CharacterType.
    internal class Card
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public CharacterType Type { get; set; }
    }
}
