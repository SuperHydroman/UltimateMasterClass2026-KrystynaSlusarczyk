using Decompositioning.Exercise_9.Products;

namespace Decompositioning.Exercise_9;

public class Exercise_9 : Exercise
{
    protected override void Demonstrate()
    {
        var loanService = new ProductLoanService();

        var gideon = new Member("Gideon");
        var emma = new Member("Emma");
        var lucas = new Member("Lucas");
        List<Member> members = [gideon, emma, lucas];

        var lordOfTheRings = new Book("Lord of the Rings", "J.R.R. Tolkien", "978-0618343997");
        var theHobbit = new Book("The Hobbit", "J.R.R. Tolkien", "978-0547928227");
        var nineteenEightyFour = new Book("1984", "George Orwell", "978-0451524935");
        var theGreatGatsby = new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565");
        var interstellar = new Dvd("Interstellar", "Christopher Nolan", 169);
        var spiritedAway = new Dvd("Spirited Away", "Hayao Miyazaki", 125);
        var nationalGeographic = new Magazine("National Geographic", "November 2026", new DateTime(2026, 11, 1));
        var scienceFocus = new Magazine("BBC Science Focus", "Issue 410", new DateTime(2026, 10, 1));

        List<Product> allProducts =
        [
            lordOfTheRings, theHobbit, nineteenEightyFour, theGreatGatsby,
            interstellar, spiritedAway, nationalGeographic, scienceFocus
        ];

        ShowSection("1. Meet the members");
        foreach (var member in members)
            Console.WriteLine($"Member #{member.MemberId}: {member.Name} (limit: {member.MaximumBorrowedProducts} items)");

        ShowSection("2. The library opens: all eight items are available");
        LibraryOverviewService.DisplayAllProducts(allProducts);
        Console.WriteLine("Gideon has not borrowed anything yet:");
        LibraryOverviewService.DisplayBorrowedProductsByMember(gideon);

        ShowSection("3. Optional product descriptions");
        lordOfTheRings.SetDescription("An epic journey through Middle-earth.");
        Console.WriteLine($"{lordOfTheRings.Title}: {lordOfTheRings.Description}");
        lordOfTheRings.RemoveDescription();
        Console.WriteLine($"After removing the description: {lordOfTheRings.Description ?? "(no description)"}");

        ShowSection("4. Successful loans: books, DVDs and magazines");
        Console.WriteLine("Gideon borrows three items; Emma borrows one.");
        loanService.Borrow(lordOfTheRings, gideon);
        loanService.Borrow(interstellar, gideon);
        loanService.Borrow(nationalGeographic, gideon);
        loanService.Borrow(theHobbit, emma);
        Console.WriteLine();
        LibraryOverviewService.DisplayAllProducts(allProducts);
        LibraryOverviewService.DisplayBorrowedProductsByMember(gideon);
        LibraryOverviewService.DisplayBorrowedProductsByMember(emma);

        Console.WriteLine("The borrowing periods come from each product type:");
        foreach (var product in gideon.BorrowedProducts)
            Console.WriteLine($"{product.Title}: {product.MaxBorrowTimeInDays} days; due {product.DueDate:yyyy-MM-dd}");

        ShowSection("5. Borrowing restrictions");
        Console.WriteLine("Gideon attempts a fourth loan (should be rejected):");
        loanService.Borrow(nineteenEightyFour, gideon);
        Console.WriteLine("Emma attempts to borrow her own checked-out item again (should be rejected):");
        loanService.Borrow(theHobbit, emma);
        Console.WriteLine("Lucas attempts to borrow Gideon's book (should be rejected):");
        loanService.Borrow(lordOfTheRings, lucas);
        Console.WriteLine();
        LibraryOverviewService.DisplayAllProducts(allProducts);

        ShowSection("6. Returning items");
        Console.WriteLine("Emma attempts to return Gideon's DVD (should be rejected):");
        loanService.Return(interstellar, emma);
        Console.WriteLine("Gideon returns his DVD successfully:");
        loanService.Return(interstellar, gideon);
        Console.WriteLine("Gideon attempts to return that DVD again (should be rejected):");
        loanService.Return(interstellar, gideon);
        Console.WriteLine();
        LibraryOverviewService.DisplayBorrowedProductsByMember(gideon);

        ShowSection("7. A return frees a slot and makes the item available again");
        Console.WriteLine("Gideon can now borrow 1984; Lucas can borrow the returned DVD.");
        loanService.Borrow(nineteenEightyFour, gideon);
        loanService.Borrow(interstellar, lucas);
        Console.WriteLine();
        LibraryOverviewService.DisplayAllProducts(allProducts);
        foreach (var member in members)
            LibraryOverviewService.DisplayBorrowedProductsByMember(member);

        ShowSection("8. Everyone returns their items");
        foreach (var member in members)
        {
            // Return() removes items from the original list, so iterate over a copy.
            foreach (var product in member.BorrowedProducts.ToList())
                loanService.Return(product, member);
        }

        Console.WriteLine();
        LibraryOverviewService.DisplayAllProducts(allProducts);
        foreach (var member in members)
        {
            Console.WriteLine($"{member.Name}:");
            LibraryOverviewService.DisplayBorrowedProductsByMember(member);
        }
    }

    private static void ShowSection(string title)
    {
        Console.WriteLine();
        Console.WriteLine(new string('=', 78));
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 78));
        Console.WriteLine();
    }
}