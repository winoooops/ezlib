namespace Fundamentals.LinkedList;

public class LinkedListQueue<T>
{
  private LinkedList<T> _list = new LinkedList<T>();
  
  public int Count => _list.Count;

  public void Enqueue(T item)
  {
    _list.AddLast(item);
  }

  public T Dequeue()
  {
    if (Count == 0)
    {
      throw new InvalidOperationException("Empty queue");
    }
    
    var value = _list.First.Value;
    _list.RemoveFirst();
    return value;
  }

  public T Peek()
  {
    if (Count == 0) throw new InvalidOperationException("Empty queue");
    return _list.First.Value;
  }

  public bool IsEmpty()
  {
    return Count == 0;
  }
}