using Decompositioning.Exercise_9;
using Decompositioning.Exercise_9.Products;

namespace Decompositioning.Exercise_9;

public class BorrowProductService
{
    public void Borrow(Product product, Member member)
    {
        if (member.BorrowedProducts.Count > 3)
        {
            Console.WriteLine("You cannot borrow any more products.");
            return;
        }

        if (member.BorrowedProducts.Any(borrowProduct => borrowProduct.ProductId == product.ProductId))
        {
            Console.WriteLine("You already borrow this product.");
            return;
        }

        if (product.IsBorrowed)
        {
            Console.WriteLine("Item is already being borrowed.");
            return;
        }

        product.IsBorrowed = true;
        product.DueDate = DateTime.Now.AddDays(product.MaxBorrowTimeInDays);
        product.CurrentBorrower = member;
        member.BorrowedProducts.Add(product);
        Console.WriteLine("Product borrowed.");
    }
}