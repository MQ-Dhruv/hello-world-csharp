// See https://aka.ms/new-console-template for more information
Console.Write("Enter your name: ");
var name = Console.ReadLine() ?? "World";

IGreeter greeter = new ConsoleGreeter("Hello");
greeter.Greet(name);