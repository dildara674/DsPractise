using System;
using Dileep.Practise.DataStructures.AbstractDataTypes;

public class ReverseList
{

    
    
    public SingleLinkedList ReverseLinkedListRecursive(SingleLinkedList list)
    {
        if(list.Head == null) return list;
        
        var head = list.Head;
        var tail = list.Tail;
        ReverseNodes(list.Head);
        
        list.Tail = head;
        list.Head = tail;
        
        return list;
    }
    
    public void ReverseNodes(LinkedListNode node)
    {
        if(node.Next == null)
        {
            return;
        }
        var next = node.Next;
        ReverseNodes(next);
        next.Next = node;
        node.Next = null;
    }
    
    public SingleLinkedList ReverseLinkedListIterative(SingleLinkedList list)
    {
        Console.WriteLine("Reverse Started!");
        if(list.Head == null) return null;
        
        LinkedListNode current = list.Head;
        LinkedListNode previous = null;
        LinkedListNode next = current.Next;
        
        while(current != null)
        {
            next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }
        
        list.Head = previous;
        return list;
    }
}

