using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dileep.Practise.DataStructures.AbstractDataTypes
{
    public class BinaryTree
    {
        public int Count
        {
            get { return GetCount(); }
        }

        public int Height { get; set; }

        public BinaryTreeNode Root { get; set; }

        
        //Methods
        public void TraversPreOrder()
        {
            TraversPreOrder(Root);
        }

        private void TraversPreOrder(BinaryTreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Value);
                TraversPreOrder(root.Left);
                TraversPreOrder(root.Right);
            }
        }

        public void TraversePreOrderNonRecursive()
        {
            if (Root != null)
            {
                Stack stack = new Stack(this.Count);
                var root = Root;
                while (true)
                {
                    while (root != null)
                    {
                        Console.WriteLine(root.Value);
                        stack.Push(root);
                        root = root.Left;
                    }

                    if (stack.Size > 0)
                    {
                        root = (BinaryTreeNode) stack.Pop();
                        root = root.Right;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void TraversInOrder()
        {
            TraversInOrder(Root);
        }

        public void TraversInOrder(BinaryTreeNode root)
        {
            if (root != null)
            {
                TraversInOrder(root.Left);
                Console.WriteLine(root.Value);
                TraversInOrder(root.Right);
            }
        }

        public void TraverseInOrderNonRecursive()
        {
            if (Root != null)
            {
                Stack stack = new Stack(this.Count);
                var root = Root;
                while (true)
                {
                    while (root != null)
                    {
                        stack.Push(root);
                        root = root.Left;
                    }

                    if (stack.Size > 0)
                    {
                        root = (BinaryTreeNode)stack.Pop();
                        Console.WriteLine(root.Value);
                        root = root.Right;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void TraversPostOrder()
        {
            TraversPostOrder(Root);
        }

        public void TraversPostOrder(BinaryTreeNode root)
        {
            if (root != null)
            {
                TraversPostOrder(root.Left);
                TraversPostOrder(root.Right);
                Console.WriteLine(root.Value);
            }
        }

        public void TraversePostOrderNonRecursive()
        {
            if (Root != null)
            {
                Stack stack = new Stack(this.Count);
                var root = Root;
                while (true)
                {
                    if (root != null)
                    {
                        stack.Push(root);
                        root = root.Left;
                    }

                    else 
                    {
                        if (stack.Size > 0)
                        {

                            if (((BinaryTreeNode)stack.Top()).Right == null)
                            {
                                root = (BinaryTreeNode)stack.Pop();
                                Console.WriteLine(root.Value);

                                var top = (BinaryTreeNode)stack.Top();
                                if (root.Value == top.Right.Value)
                                {
                                    Console.WriteLine(top.Value);
                                    stack.Pop();
                                }

                                if (stack.Size > 0)
                                    root = ((BinaryTreeNode)stack.Top()).Right;
                            }
                            else
                            {
                                root = null;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    
                }
            }
        }

        private int GetCount()
        {
            int count = 0;
            var root = Root;
            if (root != null)
            {
                Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    count++;
                    root = queue.Dequeue();
                    if(root.Left != null) queue.Enqueue(root.Left);
                    if(root.Right != null) queue.Enqueue(root.Right);
                }
            }
            
            return count;
        }

    }
}
