using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dileep.Practise.DataStructures.AbstractDataTypes
{
    public class Heap
    {
        private int DefaultCapacity = 16;
        //private int Size = 16;
        private int[] items;
        public int Size { get; set; }

        public Heap()
        {
            items = new int[DefaultCapacity];
        }

        private void ResizeArray()
        {
            try
            {
                int[] temp = new int[items.Length * 2];
                items.CopyTo(temp, 0);
                items = temp;
                //Size = items.Length * 2;
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }

        private void Heapify(int itemIndex)
        {
            while (items[itemIndex] < items[(itemIndex - 1) / 2] && itemIndex > 0)
            {
                int temp = (itemIndex - 1)/2;
                items[(itemIndex - 1) /2 ] = items[itemIndex];
                items[itemIndex] = temp;
                itemIndex = (itemIndex - 1)/2;
            }
        }

        //public interface methods
        public void Insert(int newItem)
        {
            //Resize array if required.
            if (items.Count() == items.Length)
            {
                ResizeArray();
            }

            //add item to the last
            items[items.Count()] = newItem;
            //Heapify

        }

        
    }
}
