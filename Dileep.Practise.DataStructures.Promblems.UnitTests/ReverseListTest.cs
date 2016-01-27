using System;
using Dileep.Practise.DataStructures.AbstractDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dileep.Practise.DataStructures.Promblems.UnitTests
{
    [TestClass]
    public class ReverseListTest
    {
        private SingleLinkedList list;

        [TestInitialize]
        public void Intialize()
        {
            list = new SingleLinkedList();
            list.AddFront(3);
            list.AddFront(2);
            list.AddFront(1);
            list.Print();
        }

        [TestMethod]
        public void TestReverseIterative()
        {
            Console.WriteLine("Test started!");
            ReverseList reverse = new ReverseList();
            list = reverse.ReverseLinkedListIterative(list);
            Console.WriteLine("Reverse Ended!");
            list.Print();
            Console.WriteLine("Test Ended!");
        }

        [TestMethod]
        public void TestReverseRecursive()
        {
            Console.WriteLine("Test started!");
            ReverseList reverse = new ReverseList();
            list = reverse.ReverseLinkedListRecursive(list);
            Console.WriteLine("Reverse Ended!");
            list.Print();
            Console.WriteLine("Test Ended!");
        }
    }
}
