namespace Decompositioning.Exercise_9.Products;

public abstract class Product
{
    public string ProductId { get; private set; }
    public string Title { get; private set; }
    public string? Description { get; private set; }
    public DateTime? BorrowDate { get; set; }
    public DateTime? DueDate { get; set; }
    public bool IsBorrowed { get; set; }
    public Member? CurrentBorrower { get; set; }
    public virtual int MaxBorrowTimeInDays { get; } = 7;
    
    protected Product(string title)
    {
        Title = title;
        ProductId = Guid.NewGuid().ToString();
    }

    public void SetDescription(string description)
        => Description = description;

    public void RemoveDescription() 
        => Description = null;
}