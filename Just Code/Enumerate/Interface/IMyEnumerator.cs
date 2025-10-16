namespace Fundamentals.Enumerate.Interface;

public interface IMyEnumerator<T>
{
    // Move the pointer to the next element of the enumeration
    bool MoveNext();

    // Resets the enumerator to the beginning of enumeration
    void Reset();
    
    T Current { get; }
}