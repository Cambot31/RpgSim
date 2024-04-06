using RpgSim.Player;
using RpgSim.Player.Models;
using System;

namespace RpgSim
{
    class PlayerBuilder
    {
        private readonly CharacterPlayer characterPlayer;

        public PlayerBuilder(CharacterPlayer characterPlayer)
        {
            this.characterPlayer = characterPlayer;
        }

        public void Build()
        {
            characterPlayer.Level = 1;
            Console.Write("Select Name: ");
            characterPlayer.Name = Console.ReadLine();
            Console.Write("Select Race: ");
            characterPlayer.Race = Enum.Parse<Race>(Console.ReadLine());
            Console.Write("Select Class: ");
            characterPlayer.Class = Enum.Parse<Class>(Console.ReadLine());
            Console.Write("Select Architype: ");
            characterPlayer.Architype = Enum.Parse<Architype>(Console.ReadLine());
            Console.Write("Select Strength: ");
            characterPlayer.Strength = int.Parse(Console.ReadLine());
            Console.Write("Select Dexterity: ");
            characterPlayer.Dexterity = int.Parse(Console.ReadLine());
            Console.Write("Select Constitution: ");
            characterPlayer.Constitution = int.Parse(Console.ReadLine());
            Console.Write("Select Intelligence: ");
            characterPlayer.Intelligence = int.Parse(Console.ReadLine());
            Console.Write("Select Wisdom: ");
            characterPlayer.Wisdom = int.Parse(Console.ReadLine());
            Console.Write("Select Wisdom: ");
            characterPlayer.Charisma = int.Parse(Console.ReadLine());
        }
    }
}