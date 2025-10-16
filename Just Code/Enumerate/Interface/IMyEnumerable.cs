namespace Fundamentals.Enumerate.Interface;

public interface IMyEnumerable<T>
{
  public IMyEnumerator<T> GetEnumerator();   
}