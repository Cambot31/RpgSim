using System.Security.Cryptography;
using RpgSim.Player.Models.Interfaces;

namespace RpgSim.Actions
{
    public static class Actions
    {
        public static void Attack(this PlayerBase actingPlayer, PlayerBase target)
        {
            var baseDamage = RandomNumberGenerator.GetInt32(1, actingPlayer.Strength+1);
            var chanceToHit = RandomNumberGenerator.GetInt32(0, 100);
            if (chanceToHit > 33)
            {
                var chanceToCriticalHit = RandomNumberGenerator.GetInt32(0, 6) + (int)Math.Round((double)actingPlayer.Dexterity/10);
                if (chanceToCriticalHit > 5)
                {
                    baseDamage = (int)Math.Round(baseDamage * 1.25);
                    Console.WriteLine($"{actingPlayer.Name} CRIT {target.Name} for {baseDamage}");
                }
                else
                {
                    Console.WriteLine($"{actingPlayer.Name} hit {target.Name} for {baseDamage}");
                }
                target.ChangeHp(-baseDamage);
            }
            else
            {
                Console.WriteLine($"{actingPlayer.Name} misses on {target.Name}");
            }
        }
    }
}
