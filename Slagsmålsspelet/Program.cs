using System;

int P1HP = 100;

int P2HP = 100;

Random generator = new Random();

while (P1HP > 0 || P2HP > 0)
{
int damage = generator.Next(10, 30);
int damage2 = generator.Next(10, 30);

Console.WriteLine("P1 HP: " + P1HP);
Console.WriteLine("P2 HP: " + P2HP);
Console.WriteLine("Press Enter To Atack");

Console.ReadLine(); 

P1HP = P1HP-damage;
P2HP= P2HP-damage2;

Console.WriteLine("P2 does " + damage + " on P1. P1 HP: " + P1HP);
Console.WriteLine("P1 does " + damage2 + " on P2. P2 HP: " + P2HP);
Console.WriteLine("Press Enter To Atack Again");

Console.ReadLine();
}