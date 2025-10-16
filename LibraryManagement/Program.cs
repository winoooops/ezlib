using System.Collections;
using LibraryManagement.Books;

namespace LibraryManagement;

class Program
{
  static void Main(string[] args)
  {
    var library = new LibraryService(BookService.Instance);
    library.EntryNotice();
    
    // create and store books
    var books = new List<Book>()
    {
      new Book("Raising Billionaires: A Guide for Future Mars Presidents", "Ivanka Trump"),
      new Book("Make Mars Great Again", "Twitter AGI")
    };
    library.AddBook(books);
    
    // store users
    var donald = library.AddUser("Donald Trump");
    var elon = library.AddUser("Elon Musk");
    
    Console.WriteLine(library.IsUserExist(donald));
    Console.WriteLine(library.IsUserExist(elon));
    
    library.BorrowBook("Raising Billionaires: A Guide for Future Mars Presidents", elon);
    library.FindBorrowingBookByUser(elon);
    
    library.ReturnBook("Raising Billionaires: A Guide for Future Mars Presidents", elon);
    library.FindBorrowingBookByUser(elon);
    
    
    
  }
}