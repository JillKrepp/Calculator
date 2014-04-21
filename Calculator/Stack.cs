using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Stack<T>
    {
        private List<T> stk;
        public Stack ()
        {
            stk = new List<T>();
        }

        public void Push (T value)
        {
            stk.Add(value);
        }

        public T Peek()
        {
            return stk[size() - 1];
        }

        public T Pop()
        {
            T val = stk[size() - 1];
            stk.RemoveAt(size() - 1);
            return val;
        }

        public int size()
        {
            return stk.Count;
        }
        public bool isEmpty()
        {
            return size() == 0;
        }
    }
}
