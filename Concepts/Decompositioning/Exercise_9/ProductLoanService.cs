using Decompositioning.Exercise_9.Products;

namespace Decompositioning.Exercise_9;

public class ProductLoanService
{
    public void Borrow(Product product, Member member)
    {
        if (member.BorrowedProducts.Count >= member.MaximumBorrowedProducts)
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

        var currentDate = DateTime.Now;

        product.IsBorrowed = true;
        product.BorrowDate = currentDate;
        product.DueDate = currentDate.AddDays(product.MaxBorrowTimeInDays);
        product.CurrentBorrower = member;
        
        member.BorrowedProducts.Add(product);
        Console.WriteLine($"Product \"{product.Title}\" borrowed.");
    }

    public void Return(Product product, Member member)
    {
        if (!product.IsBorrowed)
        {
            Console.WriteLine($"There is no active loan for \"{product.Title}\".");
            return;
        }

        if (product.CurrentBorrower?.MemberId != member.MemberId)
        {
            Console.WriteLine("You're not borrowing this product.");
            return;
        }

        product.IsBorrowed = false;
        product.CurrentBorrower = null;
        product.BorrowDate = null;
        product.DueDate = null;
        
        member.BorrowedProducts.Remove(product);
        Console.WriteLine($"Product \"{product.Title}\" returned.");
    }
}