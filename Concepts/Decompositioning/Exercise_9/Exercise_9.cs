using Decompositioning.Exercise_9.Products;

namespace Decompositioning.Exercise_9;

public class Exercise_9 : Exercise
{
    protected override void Demonstrate()
    {
        var borrowProductService = new BorrowProductService();

        // Members
        var memberOne = new Member("Gideon", 24);
        var memberTwo = new Member("Emma", 22);
        var memberThree = new Member("Lucas", 31);
        var memberFour = new Member("Sophie", 27);

        // Books
        var bookOne = new Book("Lord of the Rings", "J.R.R. Tolkien", "978-0618343997");
        var bookTwo = new Book("The Hobbit", "J.R.R. Tolkien", "978-0547928227");
        var bookThree = new Book("1984", "George Orwell", "978-0451524935");
        var bookFour = new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", "978-0747532699");
        var bookFive = new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565");
    }
}