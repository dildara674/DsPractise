using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dileep.Practise.DataStructures.AbstractDataTypes
{
    public class SingleLinkedList
    {

        //Properties
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }

        //Create
        public SingleLinkedList()
        {
            
        }

        //Add in Begining
        public void AddFront(object value)
        {
            LinkedListNode newNode = new LinkedListNode()
            {
                Value = value,
                Next = null
            };
            //Check if empty
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        //Add Last
        public void AddLast(object value)
        {
            LinkedListNode newNode = new LinkedListNode()
            {
                Value = value
            };
            //Check if empty
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        //Insert in Middle
        public void InsertAt(int index, object value)
        {
            if (Head != null)
            {
                var current = Head;
                for (int i = 1; i < index-1;i++)
                {
                    if (current.Next == null)
                    {
                        //Raise linked list excpetion.
                        Console.WriteLine("Invalid Index");
                        throw new Exception("Invalid Index");
                    }
                    current = current.Next;
                }

                LinkedListNode newNode = new LinkedListNode()
                {
                    Value = value
                };
                if (current == Tail)
                {
                    current.Next = newNode;
                    Tail = newNode;
                }
                else
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
            else
            {
                Console.WriteLine("Invalid Index.List is empty");
                throw new Exception("Invalid Index");
            }
        }

        //Delete First
        public void DeleteFirst()
        {
            if (Head != null)
            {
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
                throw new Exception("List is Empty.");
            }
        }

        //Delete Last
        public void DeleteLast()
        {
            if (Tail != null)
            {
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    var current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    Tail = current;
                    current.Next = null;
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
                throw new Exception("List is Empty.");
            }
        }
        
        //Delete Middle
        public void DeleteMiddle(int index)
        {
            if (Head != null)
            {
                var current = Head;
                for (int i = 1; i < index-1 ; i++)
                {
                    if (current.Next == null)
                    {
                        //Raise linked list excpetion.
                        throw new Exception("Invalid Index");
                    }
                    current = current.Next;
                }
                
                if (current == Tail)
                {
                    throw new Exception("Invalid Index");
                }
                else
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null)
                    {
                        Tail = current;
                    }
                }
            }
            else
            {
                throw new Exception("Invalid Index");
            }
        }

        //Print
        public void Print()
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        //Print Reverse
        public void PrintReverse()
        {
            if (Head != null)
            {
                PrintNextValue(Head);
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        public int Count()
        {
            if (Head != null)
            {
                int counter = 1;
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                    counter++;
                }
                return counter;
            }
            else
            {
                return 0;
            }
        }

        public object ElementAt(int index)
        {
            if (Head != null)
            {
                var current = Head;
                for (int i = 1; i < index; i++)
                {
                    if (current.Next == null)
                    {
                        //Raise linked list excpetion.
                        Console.WriteLine("Invalid Index");
                        return null;
                    }
                    current = current.Next;
                }
                return current.Value;
            }
            else
            {
                Console.WriteLine("Invalid Index.List is empty");
                return null;
            }
        }

        private void PrintNextValue(LinkedListNode node)
        {
            if (node.Next == null)
            {
                Console.WriteLine(node.Value);
            }
            else
            {
                PrintNextValue(node.Next);
                Console.WriteLine(node.Value);
            }
        }

    }
}
