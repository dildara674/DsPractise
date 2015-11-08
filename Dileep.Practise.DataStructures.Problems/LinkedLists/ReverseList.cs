public class ReverseList()
{

public void TestReverseIterative()
    {
        Console.WriteLine("Test started!");
        SingleLinkedList list = new SingleLinkedList();
        list.AddFront(3);
        list.AddFront(2);
        list.AddFront(1);
        
        
        list.Print();
        //list = ReverseLinkedListIterative(list);
        list = ReverseLinkedListRecursive(list);
        Console.WriteLine("Reverse Ended!");
        list.Print();
        Console.WriteLine("Test Ended!");
    }
    
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

