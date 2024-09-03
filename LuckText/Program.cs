
using System;

string name = "";
string videoGame = "";
string animal = ""; 

Console.WriteLine("skriv ditt favorit spel");
videoGame = Console.ReadLine();

Console.WriteLine("\nskriv en djur");
animal = Console.ReadLine();

Console.WriteLine("\nvad heter du\n");
name = Console.ReadLine();

Console.WriteLine($"Så du heter " + name + " och gillar " + videoGame + " då är du en " + animal );

Console.ReadLine();