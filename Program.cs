using System.Text.Json;
using RpgSim;
using RpgSim.Actions;

var data = JsonSerializer.Deserialize<Data>(File.ReadAllText(@"..\..\..\data.json"));
var random = new Random();

while (true)
{
    Console.Clear();
    var player = new RandomPlayer(data, random);
    var player2 = new RandomPlayer(data, random);

    player.OutputInfo();
    Console.ReadLine();
    Console.Clear();
    while (true)
    {
        player.Attack(player2);
        Console.ReadLine();
    }
}

