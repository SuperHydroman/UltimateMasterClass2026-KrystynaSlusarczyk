namespace Decompositioning.Exercise_9.Products;

public class Product
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int ProductId { get; private set; }
    protected virtual int MaxBorrowTimeInDays { get; } = 7;
    
    public Product(string title)
    {
        Title = title;
    }
}