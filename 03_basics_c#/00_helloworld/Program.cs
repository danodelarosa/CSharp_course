// See https://aka.ms/new-console-template for more information
string hello = "Hello";
string world = "World";
Console.WriteLine($"{hello} {world}!!!");
Console.Write(hello + " " + world + "!!!\n");

// Triming
string name = "         Daniel          ";
Console.WriteLine($"Start{name}End");
Console.WriteLine($"Start{name.Trim()}End");
Console.WriteLine($"Start{name.TrimStart()}End");
Console.WriteLine($"Start{name.TrimEnd()}End");

// Replace
Console.WriteLine(name.Replace("Daniel", "Dano").Replace(" ", ""));

// Contains
Console.WriteLine(name.Contains("Dan"));

// To Uppers
Console.WriteLine(name.ToUpper());

// Length
Console.WriteLine(name.Trim().Length);

// Starts with is case sensitive
Console.WriteLine(name.Trim().StartsWith("dan"));