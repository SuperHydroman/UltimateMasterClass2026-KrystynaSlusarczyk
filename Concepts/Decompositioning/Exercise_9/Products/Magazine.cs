namespace Decompositioning.Exercise_9.Products;

public class Magazine : Product
{
    private string IssueNumber { get; }
    private DateTime PublishDate { get; }
    public override int MaxBorrowTimeInDays { get; } = 14;

    public Magazine(string title, string issueNumber, DateTime publishDate) : base(title)
    {
        IssueNumber = issueNumber;
        PublishDate = publishDate;
    }
}