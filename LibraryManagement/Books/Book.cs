namespace LibraryManagement.Books;

public class Book
{
  public string ID { get; init; }    
  
  public string Title { set; get; }
  
  public string Author { set; get; }

  public Book(string title, string author)
  {
    ID = Guid.NewGuid().ToString(); 
    Title = title;
    Author = author;
  }
}