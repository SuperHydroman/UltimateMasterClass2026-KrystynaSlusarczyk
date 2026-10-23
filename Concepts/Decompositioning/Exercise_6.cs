namespace Decompositioning;

public class Exercise_6 : Exercise
{
    protected override void Demonstrate()
    {
        OrderProcessor.ProcessOnlineOrder(39.99m, 2);
        Console.WriteLine("-------------------");
        OrderProcessor.ProcessStoreOrder(69.99m, 2);
    }
}

public static class OrderProcessor
{
    private const decimal Discount = 0.9m;
    
    public static void ProcessOnlineOrder(decimal price, int quantity)
        => ProcessOrder(price, quantity, 5.99m);

    public static void ProcessStoreOrder(decimal price, int quantity)
        => ProcessOrder(price, quantity);

    private static void ProcessOrder(decimal price, int quantity, decimal shippingCost = 0m)
    {
        decimal total = CalculatePrice(price, quantity, shippingCost);

        if (IsValidForDiscount(total))
            total *= Discount;

        Console.WriteLine($"Order total: {total}");
    }

    private static decimal CalculatePrice(decimal price, int quantity, decimal shippingCost)
    {
        decimal subtotal = price * quantity;
        decimal total = subtotal + shippingCost;

        return total;
    }

    private static bool IsValidForDiscount(decimal number)
    {
        return number > 100;
    }
}