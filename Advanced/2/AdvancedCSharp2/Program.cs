using AdvancedCSharp2.Book;


public class Program
{
    static void Main(string[] args)
    {
        // Create a list of books for testing
        List<Book> bookList = new List<Book>
        {
            new Book("1234567890", "Book 1", new string[] { "Author 1", "Author 2" }, DateTime.Parse("2023-01-15"), 19.99m),
            new Book("9876543210", "Book 2", new string[] { "Author 3" }, DateTime.Parse("2022-11-20"), 12.49m),
            new Book("5555555555", "Book 3", new string[] { "Author 4", "Author 5" }, DateTime.Parse("2021-05-10"), 24.99m)
        };

        // Test case (a): User-Defined Delegate (GetTitle)
        LibraryEngine.ProcessBooksByDelegate(bookList, GetTitle);

        // Test case (b): Proper Built-in Delegate (Func delegate) (GetAuthors)
        LibraryEngine.ProcessBooksByFunc(bookList, GetAuthors);

        // Test case (c): Anonymous Method (GetISBN)
        LibraryEngine.ProcessBooksByAnonymous(bookList, delegate (Book B) { return B.ISBN; });

        // Test case (d): Lambda Expression (GetPublicationDate)
        LibraryEngine.ProcessBooksByLambda(bookList, B => B.PublicationDate.ToString("yyyy-MM-dd"));
    }

    // Test methods (matching signatures with BookFunctions methods)
    static string GetTitle(Book B)
    {
        return B.Title;
    }

    static string GetAuthors(Book B)
    {
        return string.Join(", ", B.Authors);
    }

      // Test method for ToString
    static string BookToString(Book B)
    {
        return B.ToString();
    }
}
