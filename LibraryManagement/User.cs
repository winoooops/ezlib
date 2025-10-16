using LibraryManagement.Books;

namespace LibraryManagement;

public class User
{
  public List<string> books { get; private set; } = new();
  
  public string ID { get; init; }
  
  public string Name { get; set; }

  public User(string name)
  {
    ID = Guid.NewGuid().ToString();
    Name = name;
  }

  public void BindBook(string bookId)
  {
    if (books.Contains(bookId)) return;
    books.Add(bookId);
  }

  public void UnbindBook(string bookId)
  {
    if (!books.Contains(bookId)) return;
    books.Remove(bookId);
  }
}