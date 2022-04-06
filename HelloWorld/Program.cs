// See https://aka.ms/new-console-template for more information

string aStart = "Spartens!";
Console.WriteLine($"hello {aStart}");

#pragma warning disable CS0219 // Variable is assigned but its value is never used
string firstFreiand = "Kjetil";
#pragma warning restore CS0219 // Variable is assigned but its value is never used
string secondFreiand = "Scott";
Console.WriteLine($" my friends are {firstFreiand} and {secondFreiand}");
Console.WriteLine($"The name {firstFreiand} has {firstFreiand.Length}");
Console.WriteLine($"The name {secondFreiand} has {secondFreiand.Length}");



string greeting = "    helloworld!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = "  helloworld!  ";

trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting =greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");



string sayHello = "Hola Spartens!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hola", "Greetings");
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Spartens", "Masters");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

greeting = greeting.Replace("world","værden");
Console.WriteLine(greeting);
Console.WriteLine(sayHello + greeting);
Console.WriteLine(sayHello + greeting.ToUpper());
Console.WriteLine(sayHello + $"{firstFreiand} has {firstFreiand.Length.CompareTo(secondFreiand.Length)} more than {secondFreiand}");
Console.WriteLine(value: greeting + $"{secondFreiand} has {secondFreiand.Length.CompareTo(firstFreiand.Length)} less than {firstFreiand}");
