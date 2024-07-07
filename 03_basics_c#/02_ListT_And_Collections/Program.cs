// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cup<T>");
// Its is the same but its shorter
// List<string> namess = new List<string> {}
var names = new List<string> {"Cortana", "Daniel", "Marlene"};
names.Add("Sofía");

foreach(var name in names[0..4]){ // El 4 no es inclusivo
    Console.WriteLine($"Hello {name}!!!");
}

names.Remove("Marlene");
Console.WriteLine("Marlene was deleted");

Console.WriteLine($"The last element in the List is: {names[names.Count-1]}");
Console.WriteLine($"The second last element is:{names[^2]}"); // in mac is key option + [