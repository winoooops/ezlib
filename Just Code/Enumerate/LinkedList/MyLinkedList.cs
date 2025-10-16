using Fundamentals.Enumerate.Interface;

namespace Fundamentals.Enumerate.LinkedList;

public class MyLinkedList<T> : IMyEnumerable<T>
{
  private readonly LinkedList<T> _list = new();
  
  public int Count =>  _list.Count; 

  public void AddFirst(T item)
  {
    _list.AddFirst(item);
  }

  public void AddLast(T item)
  {
    _list.AddLast(item);
  }

  public void AddAfter(LinkedListNode<T> node, T item)
  {
    _list.AddAfter(node, item);
  }

  public void AddBefore(LinkedListNode<T> node, T item)
  {
    _list.AddBefore(node, item);
  }
  
  public IMyEnumerator<T> GetEnumerator()
  {
    return new MyLinkedListEnumerator<T>(_list);
  }
}