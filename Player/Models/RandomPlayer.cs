using RpgSim.Player.Models.Interfaces;

namespace RpgSim.Player.Models;

class RandomPlayer : PlayerBase
{
    public RandomPlayer(Data data, Random random)
    {
        Name = $"{data.MaleFirstNames[random.Next(data.MaleFirstNames.Count)]} {data.Surnames[random.Next(data.Surnames.Count)]}";
        Level = random.Next(1, 21);
        Race = EnumExtensions.GetRandom<Race>();
        Architype = EnumExtensions.GetRandom<Architype>();
        Class = EnumExtensions.GetRandom<Class>();
        var statPointDistribution = RandomArrayGenerator.GenerateRandomArray(random, 6, MaxPotentialAttributes, 20);
        Strength = statPointDistribution[0];
        Constitution = statPointDistribution[1];
        Dexterity = statPointDistribution[2];
        Charisma = statPointDistribution[3];
        Wisdom = statPointDistribution[4];
        Intelligence = statPointDistribution[5];
    }
    public RandomPlayer(Data data, int level, Random random)
    {
        Name = $"{data.MaleFirstNames[random.Next(data.MaleFirstNames.Count)]} {data.Surnames[random.Next(data.Surnames.Count)]}";
        Level = level;
        Race = EnumExtensions.GetRandom<Race>();
        Architype = EnumExtensions.GetRandom<Architype>();
        Class = EnumExtensions.GetRandom<Class>();
        var statPointDistribution = RandomArrayGenerator.GenerateRandomArray(random, 6, MaxPotentialAttributes, 20);
        Strength = statPointDistribution[0];
        Constitution = statPointDistribution[1];
        Dexterity = statPointDistribution[2];
        Charisma = statPointDistribution[3];
        Wisdom = statPointDistribution[4];
        Intelligence = statPointDistribution[5];
    }
    public override void OutputInfo()
    {
        base.OutputInfo();
        Console.WriteLine("\r\nThis was a randomly generated player.");
    }
}