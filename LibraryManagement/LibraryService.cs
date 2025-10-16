using System.Collections;
using LibraryManagement.Books;

namespace LibraryManagement;

public class LibraryService
{
  private Dictionary<string, User?> _users = new();
  private Hashtable settings = new Hashtable();
  private BookService _bookService;
  
  public LibraryService(BookService bookService)
  {
    _bookService = bookService;
    PerformAdmin();
  }

  public User? AddUser(string name)
  {
    var newUser = new User(name);
    
    if (_users.TryAdd(newUser.ID, newUser)) return newUser;
    Console.WriteLine($"User [id: {newUser.ID}, name: {newUser.Name}]already exists!");
    return null;
  }

  public bool IsUserExist(User user)
  {
    if (_users.TryGetValue(user.ID, out var _))
    {
      return true;
    };
    
    return false;
  }

  public void AddBook(List<Book> books)
  {
    _bookService.AddBook(books);
  }

  public void AddBook(Book book)
  {
    _bookService.AddBook(book);
  }

  public void RemoveBook(List<Book> books)
  {
    _bookService.RemoveBook(books); 
  }

  public void RemoveBook(Book book)
  {
    _bookService.RemoveBook(book);
  }

  public void BorrowBook(string title, User user)
  {
    _bookService.BorrowBook(title, user);
  }

  public void ReturnBook(string title, User user)
  {
    _bookService.ReturnBook(title, user);
  }

  public void FindBorrowingBookByUser(User user)
  {
    if (user.books.Count == 0)
    {
      Console.WriteLine($"User [id: {user.ID}, name: {user.Name}] not borrowing any books!");
      return;
    }
    
    foreach (var bid in user.books)
    {
      var book = _bookService.GetBook(bid);
      if (book != null)
      {
        Console.WriteLine($"User [id: {user.ID}, name: {user.Name}] is borrowing {book.Title}"); 
      }
    } 
  }

  public void EntryNotice()
  {
    Console.WriteLine("----------------------------------");
    foreach (DictionaryEntry setting in settings)
    {
      Console.WriteLine("This library {0}: {1}", setting.Key, setting.Value); 
    }
    Console.WriteLine("----------------------------------");
  }

  private void PerformAdmin()
  {
    settings.Add("closeAt", "8PM"); 
    settings.Add("openAt", "9AM"); 
    settings.Add("name", "JR Digital Library");
  }
}