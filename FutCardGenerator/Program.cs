namespace FutCardGenerator;

internal class Program
{
    static void Main(string[] args)
    {
        CardBase card1 = new();
        CardBase card2 = new("Cristiano", "Ronaldo", true, 99, 99, 99, 99, 99, 99, 99);
        CardBase card3 = new("a", "a", true, 64, 99, 99, 99, 99, 99, 99);
        CardBase card4 = new("Cristiano", "Ronaldo", true, 74, 99, 99, 99, 99, 99, 99);

        card1.Info();
        Console.WriteLine("----------------------------");
        card2.Info();
        Console.WriteLine("----------------------------");
        card3.Info();
        Console.WriteLine("----------------------------");
        card4.Info();
    }
}
