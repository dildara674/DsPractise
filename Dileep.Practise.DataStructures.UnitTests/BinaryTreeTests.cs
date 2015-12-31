using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dileep.Practise.DataStructures.AbstractDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dileep.Practise.DataStructures.UnitTests
{
    [TestClass]
    public class BinaryTreeTests
    {
        private BinaryTree Tree;

        [TestInitialize]
        public void Intialize()
        {
            Tree = new BinaryTree();
            Tree.Root = new BinaryTreeNode() {Value = 1};
            Tree.Root.Left = new BinaryTreeNode() { Value = 2 ,Left = new BinaryTreeNode(){Value = 4}, Right = new BinaryTreeNode(){Value = 5}};
            Tree.Root.Right = new BinaryTreeNode() { Value = 3 ,Left = new BinaryTreeNode(){Value = 6}, Right = new BinaryTreeNode(){Value = 7}};
        }

        [TestMethod]
        public void TraversePreOrderTest()
        {
            Tree.TraversPreOrder();
        }

        [TestMethod]
        public void TraversePreOrderNonRecursiveTest()
        {
            Tree.TraversePreOrderNonRecursive();
        }
        

        [TestMethod]
        public void TraverseInOrderTest()
        {
            Tree.TraversInOrder();
        }

        [TestMethod]
        public void TraverseInOrderNonRecursiveTest()
        {
            Tree.TraverseInOrderNonRecursive();
        }

        [TestMethod]
        public void TraversePostOrderTest()
        {
            Tree.TraversPostOrder();
        }

        [TestMethod]
        public void TraversePostOrderNonRecursiveTest()
        {
            Tree.TraversePostOrderNonRecursive();
        }
    }
}
