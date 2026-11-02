using Decompositioning.Exercise_9.Products;

namespace Decompositioning.Exercise_9;

public static class LibraryOverviewService
{
    public static void DisplayAllProducts(List<Product> products)
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products found.");
            return;
        }
        
        GenerateTableForProducts(products, "All products");
    }

    public static void DisplayBorrowedProductsByMember(Member member)
    {
        var borrowedProducts = member.BorrowedProducts;
        
        if (borrowedProducts.Count == 0)
        {
            Console.WriteLine("No borrowed products.");
            return;
        }
        
        GenerateTableForProducts(borrowedProducts, $"All borrowed products for member \"{member.Name}\"");
    }

    private static void GenerateTableForProducts(List<Product> products, string header)
    {
        Console.WriteLine(header);
        
        int nameWidth = Math.Max(
            "Name".Length,
            products.Max(product => product.Title.Length)
        );

        int typeWidth = Math.Max(
            "Type".Length,
            products.Max(product => product.GetType().Name.Length)
        );

        int borrowedWidth = Math.Max(
            "Availability".Length,
            products.Max(product => product.IsBorrowed.ToString().Length)
        );

        int dueDateWidth = Math.Max(
            "Due date".Length,
            products.Max(product => product.DueDate.ToString()!.Length)
        );

        string separator = $"+-{"".PadRight(nameWidth, '-')}-+-{"".PadRight(typeWidth, '-')}-+-{"".PadRight(borrowedWidth, '-')}-+-{"".PadRight(dueDateWidth, '-')}-+";

        Console.WriteLine(separator);
        Console.WriteLine($"| {"Name".PadRight(nameWidth)} | {"Type".PadRight(typeWidth)} | {"Availability".PadRight(borrowedWidth)} | {"Due date".PadRight(dueDateWidth)} |");
        Console.WriteLine(separator);

        foreach (var product in products)
        {
            Console.WriteLine(
                $"| {product.Title.PadRight(nameWidth)} | " +
                $"{product.GetType().Name.PadRight(typeWidth)} | " +
                $"{(product.IsBorrowed ? "Unavailable" : "Available").PadRight(borrowedWidth)} | " +
                $"{(product.DueDate?.ToString("MM/dd/yyyy") ?? "-").PadRight(dueDateWidth)} |"
            );
        }

        Console.WriteLine(separator);
        Console.WriteLine();
    }
}