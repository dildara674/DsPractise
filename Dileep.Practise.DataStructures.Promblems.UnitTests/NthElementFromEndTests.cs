using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dileep.Practise.DataStructures.AbstractDataTypes;
using Dileep.Practise.DataStructures.Problems.LinkedLists;


namespace Dileep.Practise.DataStructures.Promblems.UnitTests
{
    [TestClass]
    public class NthElementFromEndTests
    {
        private SingleLinkedList List;
        private SingleLinkedList EmptyList;
        private SingleLinkedList SingleNodeList;
        
        [TestInitialize]
        public void Intialize()
        {
            EmptyList = new SingleLinkedList();
            SingleNodeList = new SingleLinkedList();
            SingleNodeList.AddLast(1);
            List = new SingleLinkedList();
            List.AddLast(1);
            List.AddLast(2);
            List.AddLast(3);
            List.AddLast(4);
            List.AddLast(5);
            List.AddLast(6);
        }
        [TestMethod]
        public void BrutalForceMethodTest()
        {
            var result = new NthElementFromEnd().BrutalForceMethod(EmptyList, 4);
            Assert.IsNull(result);

            result = new NthElementFromEnd().BrutalForceMethod(SingleNodeList, 1);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().BrutalForceMethod(SingleNodeList, 2);
            Assert.IsNull(result);

            result = new NthElementFromEnd().BrutalForceMethod(List,4);
            Assert.AreEqual(3,((LinkedListNode)result).Value);
            result = new NthElementFromEnd().BrutalForceMethod(List, 7);
            Assert.IsNull(result);
            result = new NthElementFromEnd().BrutalForceMethod(List, 6);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().BrutalForceMethod(List, 1);
            Assert.AreEqual(6, ((LinkedListNode)result).Value);
        }

        [TestMethod]
        public void UsingLengthTest()
        {
            //Empty List
            var result = new NthElementFromEnd().UsingLength(EmptyList, 4);
            Assert.IsNull(result);

            //Single node list
            result = new NthElementFromEnd().UsingLength(SingleNodeList, 1);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingLength(SingleNodeList, 2);
            Assert.IsNull(result);

            //Multi node list
            result = new NthElementFromEnd().UsingLength(List, 4);
            Assert.AreEqual(3, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingLength(List, 7);
            Assert.IsNull(result);
            result = new NthElementFromEnd().UsingLength(List, 6);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingLength(List, 1);
            Assert.AreEqual(6, ((LinkedListNode)result).Value);
        }

        [TestMethod]
        public void UsingHashTable()
        {
            //Empty List
            var result = new NthElementFromEnd().UsingHashTable(EmptyList, 4);
            Assert.IsNull(result);

            //Single node list
            result = new NthElementFromEnd().UsingHashTable(SingleNodeList, 1);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingHashTable(SingleNodeList, 2);
            Assert.IsNull(result);

            //Multi node list
            result = new NthElementFromEnd().UsingHashTable(List, 4);
            Assert.AreEqual(3, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingHashTable(List, 7);
            Assert.IsNull(result);
            result = new NthElementFromEnd().UsingHashTable(List, 6);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingHashTable(List, 1);
            Assert.AreEqual(6, ((LinkedListNode)result).Value);
        }
        
        
        [TestMethod]
        public void UsingRangeMethodTest()
        {
            //Empty List
            var result = new NthElementFromEnd().UsingRangeMethod(EmptyList, 4);
            Assert.IsNull(result);

            //Single node list
            result = new NthElementFromEnd().UsingRangeMethod(SingleNodeList, 1);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingRangeMethod(SingleNodeList, 2);
            Assert.IsNull(result);

            //Multi node list
            result = new NthElementFromEnd().UsingRangeMethod(List, 4);
            Assert.AreEqual(3, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingRangeMethod(List, 7);
            Assert.IsNull(result);
            result = new NthElementFromEnd().UsingRangeMethod(List, 6);
            Assert.AreEqual(1, ((LinkedListNode)result).Value);
            result = new NthElementFromEnd().UsingRangeMethod(List, 1);
            Assert.AreEqual(6, ((LinkedListNode)result).Value);
        }
    }
}
