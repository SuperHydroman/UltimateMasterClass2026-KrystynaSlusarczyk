namespace Decompositioning.Exercise_9.Products;

public class Book : Product
{
    private string Author { get; }
    private string Isbn { get; }
    protected override int MaxBorrowTimeInDays { get; } = 21;

    public Book(string title, string author, string isbn) : base(title)
    {
        Author = author;
        Isbn = isbn;
    }
}