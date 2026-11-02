using Decompositioning.Exercise_9.Products;

namespace Decompositioning.Exercise_9;

public class Member
{
    private static int _nextMemberId = 1;
    
    public string Name { get; private set; }
    public int MemberId { get; private set; }
    public List<Product> BorrowedProducts { get; } = [];
    public int MaximumBorrowedProducts { get; } = 3;

    public Member(string name)
    {
        Name = name;
        MemberId = _nextMemberId++;
    }
}