namespace FutCardGenerator;

internal class Program
{
    static void Main(string[] args)
    {
        CardBase card1 = new();
        CardBase card2 = new("Cristiano", "Ronaldo", true, 100, Positions.ST, 99, 99, 99, 99, 99, 99);
        CardBase card3 = new("a", "a", true, 88, Positions.GK, 99, 99, 99, 99, 99, 99);
        CardBase card4 = new("Cristiano", "Ronaldo", true, 73, Positions.LW, 99, 99, 99, 99, 99, 99);

        card1.Info();
        Console.WriteLine("----------------------------");
        card2.Info();
        Console.WriteLine("----------------------------");
        card3.Info();
        Console.WriteLine("----------------------------");
        card4.Info();
    }
}
