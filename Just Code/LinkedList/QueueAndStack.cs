namespace Fundamentals.LinkedList;

public class QueueAndStack
{
   public static void RunTests()
   {
      var stack = new LinkedListStack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Pop();
      Console.WriteLine("Stack: [LIFO], now looking at: {0}", stack.Peek());

      var Queue = new LinkedListQueue<int>();
      Queue.Enqueue(1);
      Queue.Enqueue(2);
      Queue.Enqueue(3);
      Queue.Dequeue();
      Console.WriteLine("Queue:[FIFO], now looking at: {0}", Queue.Peek());
   }
}