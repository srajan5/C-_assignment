using System;
using System.Collections;

    interface ICloneable
    {
        void Push();
        void Pop();
    }
    public class MyStack : ICloneable
    {
        private List<int> stack = new List<int>();
        private int _top;
        public int Top { get { return _top; } set { this._top = value; } }
        private int _stackSize;
        public int StackSize { get { return _stackSize; } set { this._stackSize = value; } }

        public void Push()
        {
            
            if (stack.Count == _stackSize)
            {
                Console.WriteLine("Full Stack");
                return;
            }
            stack.Add(this._top);
        }
        public void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Empty Stack");
                return;
            }
            stack.RemoveAt(stack.Count - 1);
        }

        public void DisplayStack()
        {
            foreach (int S in stack)
            {
                Console.WriteLine("The size of the Stack is {0}",StackSize);
                Console.WriteLine("Displaying the stack ");
                Console.WriteLine(S);
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            MyStack s = new MyStack();
            s.StackSize = 5;
            Console.WriteLine("pushed and popped items");
            s.Top = 15;
            s.Push();
            s.Top = 23;
            s.Push(); 
            s.DisplayStack();
            s.Pop();
            

        }
    }


