﻿using System;

int P1HP = 100;

int P2HP = 100;

Random generator = new Random();

int damage = generator.Next(10, 30);
int damage2 = generator.Next(10, 30);

Console.WriteLine("P1 chose your name");
string name;
name = Console.ReadLine();

Console.WriteLine("P2 now chose your name");
string name2;
name2 = Console.ReadLine();


Console.WriteLine(name + " HP: " + P1HP);
Console.WriteLine(name2 + " HP: " + P2HP);
Console.WriteLine("Press Enter To Atack");

Console.ReadLine(); 

do
{
    P1HP = P1HP-damage2;
    P2HP= P2HP-damage;

    Console.WriteLine(name + " HP: " + P1HP + ". Does " + damage + " points of damage on " + name2);
    Console.WriteLine(name2 + " HP: " + P2HP + ". Does " + damage2 + " points of damage on " + name);
    Console.WriteLine("Press Enter To Atack Again");

    Console.ReadLine();
}

while (P1HP > 0 || P2HP > 0);

if (P1HP < 0)
{
    Console.WriteLine(name2 + " has beaten " + name + " to a pulp");
}
else if (P2HP <0)
{
    Console.WriteLine(name + " has beaten P2 " + name2 + " to a pulp");
}

Console.ReadLine();