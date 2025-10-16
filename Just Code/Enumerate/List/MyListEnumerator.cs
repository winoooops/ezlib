using Fundamentals.Enumerate.Interface;

public class MyListEnumerator<T> : IMyEnumerator<T>
{
  private List<T> _list;
  private int _pointer;
  
  public MyListEnumerator(List<T> list)
  {
    _list = list;
    _pointer = -1;
  }

  public bool MoveNext()
  {
    if (_pointer + 1 == _list.Count) return false;
    _pointer++;
    return true;
  }

  public void Reset()
  {
    _pointer = -1;
  }

  public T Current
  {
    get
    {
      if (_pointer < 0 || _pointer >= _list.Count) throw new InvalidOperationException("Invalid Move");
      return _list[_pointer];
    }
  }
}