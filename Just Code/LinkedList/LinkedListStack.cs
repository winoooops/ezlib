namespace Fundamentals.LinkedList;

public class LinkedListStack<T>
{
    private LinkedList<T> _list = new();
    
    public int Count => _list.Count;

    public void Push(T item)
    {
        _list.AddLast(item);
    }

    public T Pop()
    {
      if (Count == 0) throw new InvalidOperationException("Stack is empty");
      var value = _list.Last.Value;
      _list.RemoveLast();
      return value;
    }

    public T Peek()
    {
      if (Count == 0) throw new InvalidOperationException("Stack is empty");
      return _list.Last.Value;
    }

    public bool IsEmpty()
    {
      return Count == 0;
    }
}