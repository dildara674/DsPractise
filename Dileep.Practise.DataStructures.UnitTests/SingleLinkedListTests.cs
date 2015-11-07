using System;
using System.Runtime.Remoting.Messaging;
using Dileep.Practise.DataStructures.AbstractDataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dileep.Practise.DataStructures.UnitTests
{
    [TestClass]
    public class SingleLinkedListTests
    {
        private SingleLinkedList List;
        
        public SingleLinkedListTests()
        {
            List = new SingleLinkedList();
        }

        [TestInitialize]
        public void Intialialize()
        {
            VerifyEmpty();
        }

        private void VerifyEmpty()
        {
            Assert.IsTrue(List.Count() == 0, "Empty list count should not be " + List.Count());
        }

        private void VerifySingleItemInList(object value)
        {
            Assert.IsTrue(List.Count() == 1, "List count should not be " + List.Count() +". Expected count 1");
            Assert.AreEqual(List.Head, List.Tail, "Head and Tail shoudl point to same object in list with one item.");
            Assert.IsNull(List.Head.Next,"Head.Next is not null for list with 1 item.");
            Assert.IsTrue(List.Head.Value.Equals(value),"Head value is not eaual to the only item in the list.");
            Assert.IsTrue(List.Tail.Value.Equals(value), "Tail value is not eaual to the only item in the list.");
        }

        private void VerifyTwoItemsinList(object value)
        {
            Assert.IsTrue(List.Count() == 2, "List count should not be " + List.Count() + ". Expected count 2");
            Assert.AreNotEqual(List.Head, List.Tail, "Head and Tail shoudl point to same object in list with one item.");
            Assert.AreEqual(List.Head.Next,List.Tail, "Head.Next is not pointing to Tail.");
            Assert.IsNull(List.Tail.Next, "Tail next item value is not null.");
            Assert.IsTrue(List.Tail.Value.Equals(value), "Tail value is not eaual to the second item in the list.");
        }

        private void VerifyMultipleItemsInList()
        {
            Assert.IsTrue(List.Count() > 1, "List count should be greater than 1. Actual Count: " + List.Count());
            Assert.AreNotEqual(List.Head, List.Tail, "Head and Tail shoudl not point to same object in list with multiple items.");
            Assert.IsNotNull(List.Head.Next, "Head.Next is null for list with multiple item.");
            Assert.IsNull(List.Tail.Next, "Tail next item value is not null.");
        }

        [TestMethod]
        public void AddFrontTest()
        {
            //Add to front on empty list.
            List.AddFront(1);
            VerifySingleItemInList(1);
            //Add to front with 1 node in list.
            List.AddFront(2);
            VerifyTwoItemsinList(1);
            //Add to front with multiple nodes in list.
            List.AddFront(3);
            VerifyMultipleItemsInList();
            Assert.AreEqual(List.Count(),3,"List count not equals to the expected count 3.");
        }

        [TestMethod]
        public void AddLastTest()
        {
            //Add to last on empty list.
            List.AddLast(1);
            VerifySingleItemInList(1);
            //Add to last with 1 node in list.
            List.AddLast(2);
            VerifyTwoItemsinList(2);
            //Add to last with multiple nodes in list.
            List.AddLast(3);
            VerifyMultipleItemsInList();
            Assert.AreEqual(List.Count(), 3, "List count not equals to the expected count 3.");
        }

        [TestMethod]
        public void InsertTest()
        {
            try
            {
                List.InsertAt(2, 1);
                Assert.Fail("Insert at Invalid index worked.");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Equals("Invalid Index"));
            }
            List.AddFront(3);
            List.AddLast(5);
            try
            {
                List.InsertAt(4, 1);
                Assert.Fail("Insert at Invalid index worked.");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Equals("Invalid Index"));
            }
            List.AddFront(2);
            List.AddFront(1);
            List.InsertAt(4, 10);
            List.AddLast(6);
            List.InsertAt(7,7);
            Assert.AreEqual(10,List.ElementAt(4));
        }

        [TestMethod]
        public void DeleteFrontTest()
        {
            try
            {
                List.DeleteFirst();
                Assert.Fail("Deleting first on empty list should fail.");
            }
            catch (Exception ex)
            {

                Assert.IsTrue( ex.Message.Equals("List is Empty."));
            }

            List.AddFront(1);
            List.DeleteFirst();
            VerifyEmpty();
            List.AddFront(1);
            List.AddLast(2);
            List.DeleteFirst();
            VerifySingleItemInList(2);
        }

        [TestMethod]
        public void DeleteLastTest()
        {
            try
            {
                List.DeleteLast();
                Assert.Fail("Deleting Last on empty list should fail.");
            }
            catch (Exception ex)
            {

                Assert.IsTrue(ex.Message.Equals("List is Empty."));
            }
            List.AddFront(1);
            List.DeleteLast();
            VerifyEmpty();
            List.AddFront(1);
            List.AddLast(2);
            List.DeleteLast();
            VerifySingleItemInList(1);
            List.Print();
            List.PrintReverse();
        }

        [TestMethod]
        public void DeleteIndexTest()
        {
            List.AddFront(1);
            List.AddLast(2);
            List.AddLast(3);
            List.AddLast(4);
            List.DeleteMiddle(2);
            List.DeleteMiddle(3);
            try
            {
                List.DeleteMiddle(5);
                Assert.Fail("Deleting Last on ivalid index should fail.");
            }
            catch (Exception ex)
            {

                Assert.IsTrue(ex.Message.Equals("Invalid Index"));
            }
            
            List.Print();
        }

        
    }
}
