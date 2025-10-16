namespace Fundamentals.LinkedList;

// implementing Reverse Polish Notation Algorithm
public class RPNAlgo
{
   //  using something "3 4 + 2 * 7 /" for calculation
   // it should be doing (3 + 4) * 2 / 7
   // maintaining only 1 stack to save computing resources
   private static Stack<int> stack = new Stack<int>();

   public static int Calculate(string s)
   {
      foreach (var token in s.Split(" "))
      {
         if (int.TryParse(token, out var number))
         {
           stack.Push(number); 
         }
         else
         {
            var b = stack.Pop();
            var a = stack.Pop();
            switch (token)
            {
               case "+":
                  stack.Push(a + b);
                  break;
               case "-":
                  stack.Push(a - b);
                  break;
               case "*":
                  stack.Push(a * b);
                  break;
               case "/":
                  stack.Push(a / b);
                  break;
               default:
                  throw new Exception("Invalid operator");
            }
         }
      }

      return stack.Count == 1 ? stack.Pop() : throw new Exception("Invalid Reverse Poland Notation Expression");
   }
}