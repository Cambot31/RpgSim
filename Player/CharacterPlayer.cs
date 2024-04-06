using System.Security.Cryptography;
using RpgSim.Player.Models.Interfaces;

namespace RpgSim.Player;

class CharacterPlayer : PlayerBase
{
    public void Attack(PlayerBase target)
    {
        var baseDamage = RandomNumberGenerator.GetInt32(1, Strength+1);
        var chanceToHit = RandomNumberGenerator.GetInt32(0, 100);
        if (chanceToHit > 33)
        {
            var chanceToCriticalHit = RandomNumberGenerator.GetInt32(0, 6) + (int)Math.Round((double)Dexterity/10);
            if (chanceToCriticalHit > 5)
            {
                baseDamage = (int)Math.Round(baseDamage * 1.25);
                Console.WriteLine($"{Name} CRIT {target.Name} for {baseDamage}");
            }
            else
            {
                Console.WriteLine($"{Name} hit {target.Name} for {baseDamage}");
            }
            target.ChangeHp(-baseDamage);
        }
        else
        {
            Console.WriteLine($"{Name} misses on {target.Name}");
        }
    }
}