class Program
{
    public static void Main()
    {
        var numbers = new[] { 34, 15, 88, 2 };

        var minNUmber = numbers.Min(x => x);
        Console.WriteLine(minNUmber);
    }
}