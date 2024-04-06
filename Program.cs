using System.Security.Cryptography;
using System.Text.Json;
using RpgSim;
using RpgSim.Player;
using RpgSim.Player.Models;

var data = JsonSerializer.Deserialize<Data>(File.ReadAllText("data.json"));
var random = new Random();

while (true)
{
    Console.Clear();
    var pc = new CharacterPlayer();
    
    var pb = new PlayerBuilder(pc);

    pb.Build();

    var player2 = new RandomPlayer(data, 1, random);

    pc.OutputInfo();
    Console.ReadLine();
    Console.Clear();
    while (true)
    {
        pc.Attack(player2);
        Console.ReadLine();
    }
}

