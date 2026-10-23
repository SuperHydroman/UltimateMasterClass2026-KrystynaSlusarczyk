namespace Decompositioning;

public class Exercise_2 : Exercise
{
    protected override void Demonstrate()
    {
        PriceCalculator.CalculateBookPrice(24.99m);
        Console.WriteLine("-------------------");
        
        PriceCalculator.CalculateGamePrice(59.99m);
    }
}

public class PriceCalculator
{
    public static decimal CalculateBookPrice(decimal price)
        => CalculatePrice(price, 0.09m);

    public static decimal CalculateGamePrice(decimal price)
        => CalculatePrice(price: price, 0.21m);

    private static decimal CalculatePrice(decimal price, decimal taxRate)
    {
        decimal tax = price * taxRate;
        decimal total = price + tax;

        Console.WriteLine($"Original: {price}");
        Console.WriteLine($"Tax: {tax}");
        Console.WriteLine($"Total: {total}");

        return total;
    }
}