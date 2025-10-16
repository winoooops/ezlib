using Fundamentals.Enumerate.Interface;

namespace Fundamentals.Enumerate.LinkedList;

public class MyLinkedListEnumerator<T> : IMyEnumerator<T>
{
  private readonly LinkedList<T> _list;
  private LinkedListNode<T>? _current;
  
  public MyLinkedListEnumerator(LinkedList<T> list)
  {
    _list = list;
    _current = null;
  }
  
  public bool MoveNext()
  {
    if (_current == null)
    {
      _current = _list.First;
      return true;
    }

    if (_current.Next != null)
    {
      _current = _current.Next;
      return true;
    }
    
    return false;
  }

  public void Reset()
  {
    _current = null;
  }

  public T Current => _current == null ? throw new InvalidOperationException("Invalid move") : _current.Value;
}