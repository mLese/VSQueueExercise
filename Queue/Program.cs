using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    interface IQueue<T>
    {
        void enqueue(T value);
        T dequeue();
        T peek();
        int size();
    }

    public class MyQueue<T> : IQueue<T>
    {
        public T dequeue()
        {
            throw new NotImplementedException();
        }

        public void enqueue(T value)
        {
            throw new NotImplementedException();
        }

        public T peek()
        {
            throw new NotImplementedException();
        }

        public int size()
        {
            throw new NotImplementedException();
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
        }
}
