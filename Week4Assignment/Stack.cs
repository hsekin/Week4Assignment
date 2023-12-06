using System;
namespace Week4Assignment
{
    class Stack<T>
    {
        private List<T> items;

            public Stack()
        {
            items = new List<T>();
        }

        
        public void Push(T item)
        {
            items.Add(item);
            Console.WriteLine($"Pushed: {item}");
        }

        
        public T Pop()
        {
            T poppedItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            Console.WriteLine($"Popped: {poppedItem}");
            return poppedItem;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot peek.");
                return default(T);
            }

            return items[items.Count - 1];
        }
        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}

