namespace Decompositioning.Exercise_9.Products;

public class Member
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int MemberId { get; private set; }
    public List<Product> BorrowedProducts { get; }

    public Member(string name, int age)
    {
        Name = name;
        Age = age;
    }
}