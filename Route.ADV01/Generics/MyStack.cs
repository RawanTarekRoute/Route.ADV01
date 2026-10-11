using System.ComponentModel;

namespace Route.ADV01.Generics
{
    internal class MyStack<T>
    {
        private T[] items;
        
        private int top;
        public int Count => top;

        public MyStack(int capacity)
        {
            items = new T[capacity];  
        }

        public void Push(T value)
        {
            if (top < items.Length)
                items[top++] = value; // post increment
        }

        public T Peek()
        {
            if (top > 0)
                return items[top - 1];

            return default;
        }

        public T Pop()
        {
            if (top > 0)
                return items[--top];

            return default;
        }

    }
}
