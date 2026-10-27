namespace Decompositioning.Exercise_9.Products;

public class Magazine : Product
{
    private string Author { get; }
    private string Isbn { get; }
    protected override int MaxBorrowTimeInDays { get; } = 14;

    public Magazine(string title, string author, string isbn) : base(title)
    {
        Author = author;
        Isbn = isbn;
    }
}