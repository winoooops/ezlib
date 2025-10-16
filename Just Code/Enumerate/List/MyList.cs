using Fundamentals.Enumerate.Interface;

namespace Fundamentals.Enumerate.List;

public class MyList<T> : IMyEnumerable<T>
{
  private readonly List<T> _list = new();
  
  public int Count => _list.Count;
  
  public T this[int index] => _list[index]; // so we could use index to get values at pointer

  public void Add(T item)
  {
    _list.Add(item);
  }
  
  
  public IMyEnumerator<T> GetEnumerator()
  {
    return new MyListEnumerator<T>(_list);
  }
}