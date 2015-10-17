using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dileep.Practise.DataStructures.AbstractDataTypes
{
    public class Stack
    {

        public const int DefaultCapacity = 1024;

        
        public int Size;
        private object[] elements;
        private readonly int capacity;


        public Stack(int size)
        {
            capacity = size;
            elements = new object[capacity];
        }

        public void Push(object item)
        {
            //is the size > capacity
            if (Size < capacity)
            {
                elements[Size] = item;
                Size++;
            }
            else
            {
                throw new Exception("Stack Overflow exception!");
            }
        }

        public object Pop()
        {
            if (Size > 0)
            {
                var pop = elements[Size-1];
                Size--;
                elements[Size] = null;
                return pop;
            }
            throw new Exception("Stack is empty!");
        }

        public void Travese()
        {
            if (Size > 0)
            {
                StringBuilder output = new StringBuilder(2*Size);
                for (int i = Size-1; i >= 0; i--)
                {
                    output.Append((i == Size - 1 ? string.Empty : ",") + elements[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no elements in the stack!");
            }
        }

        public bool Exists(object  a)
        {
            if (Size > 0)
            {
                for (int i = Size - 1; i >= 0; i--)
                {
                    if (a.Equals(elements[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public object Top()
        {
            if (Size > 0)
            {
                return elements[Size-1];
            }
            throw new Exception("Stack is empty!");
        }
    }
}
