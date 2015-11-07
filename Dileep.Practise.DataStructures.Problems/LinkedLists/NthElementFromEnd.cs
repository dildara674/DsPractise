using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dileep.Practise.DataStructures.AbstractDataTypes;

namespace Dileep.Practise.DataStructures.Problems.LinkedLists
{
    public class NthElementFromEnd
    {
        /// <summary>
        /// Time Complexity is O(n^2). Space Complexity is 1
        /// </summary>
        /// <returns></returns>
        public object BrutalForceMethod(SingleLinkedList list, int n)
        {
            if (list.Head == null)
            {
                return null;
            }
            LinkedListNode current = list.Head;
            LinkedListNode temp = current;
            int remainingNodes = 0;
            while (temp.Next != null)
            {
                remainingNodes++;
                if (remainingNodes >= n)
                {
                    current = current.Next;
                    temp = current;
                    remainingNodes = 0;
                }
                else
                {
                    temp = temp.Next;
                }
            }

            if (remainingNodes == n - 1)
            {
                return current;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Time Complexity is O(n). Space Complexity is O(n)
        /// </summary>
        /// <returns></returns>
        public object UsingLength(SingleLinkedList list, int n)
        {
            if (list.Head == null)
            {
                return null;
            }
            var current = list.Head;
            int l = 1;
            //calculate length
            while (current.Next != null)
            {
                l++;
                current = current.Next;
            }

            int i = l - n + 1;
            if (i > 0)
            {
                current = list.Head;
                while (i > 1)
                {
                    current = current.Next;
                    i--;
                }
                return current;
            }
            return null;
        }
        
        public object UsingHashTable(SingleLinkedList list, int n)
        {
            if (list.Head == null)
            {
                return null;
            }
            Hashtable table = new Hashtable();
            var current = list.Head;

            for (int i = 1; current != null; i++)
            {
                table.Add(i,current);
                current = current.Next;
            }

            int x = table.Count - n + 1;
            if (x > 0)
            {
                return table[x];
            }
            return null;
        }

        public object UsingRangeMethod(SingleLinkedList list, int n)
        {
            if (list.Head == null)
            {
                return null;
            }

            var first = list.Head;
            var last = list.Head;

            for (int i = 1; i < n; i++)
            {
                if (last.Next != null)
                {
                    last = last.Next;
                }
                else
                {
                    return null;
                }
            }

            while (last.Next != null)
            {
                last = last.Next;
                first = first.Next;
            }

            return first;
        }
    }
}
