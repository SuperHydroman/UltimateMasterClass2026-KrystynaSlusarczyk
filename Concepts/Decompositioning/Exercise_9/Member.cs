using Decompositioning.Exercise_9.Products;

namespace Decompositioning.Exercise_9;

public class Member
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int MemberId { get; private set; }
    public List<Product> BorrowedProducts { get; } = [];
    public int MaximumBorrowedProducts { get; } = 3;

    public Member(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ListBorrowedProducts()
    {
        if (BorrowedProducts.Count == 0)
        {
            Console.WriteLine("No borrowed products.");
            return;
        }

        int nameWidth = Math.Max(
            "Name".Length,
            BorrowedProducts.Max(product => product.Title.Length)
        );

        int typeWidth = Math.Max(
            "Type".Length,
            BorrowedProducts.Max(product => product.GetType().Name.Length)
        );

        int borrowedWidth = Math.Max(
            "IsBorrowed".Length,
            BorrowedProducts.Max(product => product.IsBorrowed.ToString().Length)
        );

        string separator = $"+-{"".PadRight(nameWidth, '-')}-+-{"".PadRight(typeWidth, '-')}-+-{"".PadRight(borrowedWidth, '-')}-+";

        Console.WriteLine(separator);
        Console.WriteLine($"| {"Name".PadRight(nameWidth)} | {"Type".PadRight(typeWidth)} | {"IsBorrowed".PadRight(borrowedWidth)} |");
        Console.WriteLine(separator);

        foreach (Product product in BorrowedProducts)
        {
            Console.WriteLine(
                $"| {product.Title.PadRight(nameWidth)} | " +
                $"{product.GetType().Name.PadRight(typeWidth)} | " +
                $"{product.IsBorrowed.ToString().PadRight(borrowedWidth)} |"
            );
        }

        Console.WriteLine(separator);
    }
}