namespace LibraryManagement.Books.Interfaces;

public interface IBookOperation
{
  public void RegisterBooks(List<Book> books) {}
  
  public void AddBook(Book book) {}
  
  public void RemoveBook(Book book) {}
  
  public void BorrowBook(Book book, User user) {}
  
  public void ReturnBook(Book book, User user) {}
}