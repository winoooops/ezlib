using LibraryManagement.Books.Interfaces;

namespace LibraryManagement.Books;

public class BookService : IBookOperation
{
  public static BookService Instance { get; } = new BookService();

  private List<Book> _books = new();
  
  private Queue<string> _borrowedBooks = new();

  private Stack<Book> _returnedBooks = new();
  
  private BookService() {}

  public void AddBook(Book book)
  {
    if (_books.Find(b => b.Title == book.Title) != null)
    {
      Console.WriteLine("Book already registered");
      return;
    }
    _books.Add(book);
  }

  public void AddBook(List<Book> books)
  {
    foreach (var book in books)
    {
      AddBook(book);
    }
  }

  public void RemoveBook(Book book)
  {
    if (_books.Find(b => b.Title == book.Title) == null)
    {
      Console.WriteLine("Book not found");
      return;
    }

    _books.Remove(book);
  }

  public void RemoveBook(List<Book> books)
  {
    foreach (var book in books)
    {
      RemoveBook(book);
    }
  }

  public Book? GetBook(string id)
  {
    return _books.Find(b=> b.ID == id);
  }

  
  public void BorrowBook(string title, User user)
  {
    var book = _books.Find(b => b.Title == title);
    
    if (book == null)
    {
      Console.WriteLine("Book not found");
      return;
    }
    
    _borrowedBooks.Enqueue(user.ID);
    user.BindBook(book.ID);
  }

  public void ReturnBook(string title, User user)
  {
    var book = _books.Find(b => b.Title == title);
    if (book == null) return;
    
    _returnedBooks.Push(book); 
    user.UnbindBook(book.ID);
  }
  
  public void ShowBorrowedBooks()
  {
    foreach (var bID in _borrowedBooks)
    {
      Console.WriteLine(_books.Find(b => b.ID == bID)?.Title); 
    }
  }
}