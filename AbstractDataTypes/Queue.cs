using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dileep.Practise.DataStructures.AbstractDataTypes
{
    public class Queue
    {
        private int capacity = 16;

        public int Front;
        public int Rear;

        public Queue(int size)
        {
            capacity = size;
        }

        public void Enqueue(object item)
        {
            
        }

        public object Dequeue()
        {
            return new object();
        }

    }
}
