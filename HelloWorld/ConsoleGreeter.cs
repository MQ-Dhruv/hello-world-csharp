public class ConsoleGreeter : IGreeter
{
    public void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}