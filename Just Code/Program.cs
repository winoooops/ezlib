namespace Fundamentals;
using Fundamentals.LinkedList;


class Program
{
  static void Main(string[] args)
  {
    QueueAndStack.RunTests();;

    Console.WriteLine(RPNAlgo.Calculate("3 4 + 2 * 7 /"));
    
    Demo.RunListEnumerator();
    Demo.RunLinkedListEnumerator();
  }
}