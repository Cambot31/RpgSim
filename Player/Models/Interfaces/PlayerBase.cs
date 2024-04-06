namespace RpgSim.Player.Models.Interfaces
{
    public abstract class PlayerBase
    {
        private const int _potentialStatCoefficient = 4;
        public int Level { get; set; }
        public int MaxPotentialAttributes => Level * _potentialStatCoefficient;
        public string Name { get; set; }
        public int MaxPotentialHp => Level * (_potentialStatCoefficient + (int) Math.Round((double) Constitution / 5));
        public int Hp { get; set; }

        public void ChangeHp(int value)
        {
            Hp += value;
        }
        public Race Race { get; set; }
        public Architype Architype { get; set; }
        public Class Class { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public virtual void OutputInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Race: {Race}");
            Console.WriteLine($"Architype: {Architype}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Hp: {Hp}");
            Console.WriteLine($"Max Potential Attributes: {MaxPotentialAttributes}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine($"Constitution: {Constitution}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Wisdom: {Wisdom}");
            Console.WriteLine($"Charisma: {Charisma}");
        }
    }
}
