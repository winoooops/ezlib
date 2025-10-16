
using Fundamentals.Enumerate.LinkedList;
using Fundamentals.Enumerate.List;

public class Demo
{
  public static void RunListEnumerator()
  {
    Console.WriteLine("---------------------List Enumerator Demo----------------------");
    var myList = new MyList<int>();
    myList.Add(1);
    myList.Add(3);
    myList.Add(5);
    myList.Add(7);
    myList.Add(9);

    var listEnumerator = myList.GetEnumerator();
    while (listEnumerator.MoveNext())
    {
      Console.WriteLine(listEnumerator.Current);
    }
    
    listEnumerator.Reset();
    Console.WriteLine("Doing it again for no reason");

    while (listEnumerator.MoveNext())
    {
      Console.WriteLine(listEnumerator.Current);
    }
    
    Console.WriteLine("---------------------List Enumerator End----------------------");
  }

  public static void RunLinkedListEnumerator()
  {
    Console.WriteLine("---------------------LinkedList Enumerator Demo----------------------");
    var myLinkedList = new MyLinkedList<int>();
    myLinkedList.AddLast(1);
    myLinkedList.AddLast(3);
    myLinkedList.AddLast(5);
    myLinkedList.AddLast(7);
    myLinkedList.AddLast(9);
    
    var listEnumerator = myLinkedList.GetEnumerator();
    while (listEnumerator.MoveNext())
    {
      Console.WriteLine(listEnumerator.Current);  
    }
    
    listEnumerator.Reset();
    Console.WriteLine("Doing it again for no reason");
    while (listEnumerator.MoveNext())
    {
      Console.WriteLine(listEnumerator.Current);
    }
    
    Console.WriteLine("---------------------LinkedList Enumerator Back----------------------");
  }
}