using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dileep.Practise.DataStructures.AbstractDataTypes;

namespace Dileep.Practise.DataStructures.UnitTests
{
    [TestClass]
    public class StackTests
    {
        private Stack thisStack;
        [TestInitialize]
        public void Intialize()
        {
            thisStack = new Stack(8);
        }

        [TestMethod]
        [TestCategory("BVT")]
        public void PushTests()
        {
            //Insert into empty stack.
            thisStack.Push(1);
            Assert.IsTrue(thisStack.Size == 1,"Expected Stack Size = 1, Actual Size =" + thisStack.Size);
            Assert.IsTrue(thisStack.Top().ToString().Equals("1"), "Expected Top = 1, Actual Top =" + thisStack.Top());

            //Insert into stack with elements
            for (int i = 2; i <= 8; i++)
            {
                thisStack.Push(i);
                Assert.IsTrue(thisStack.Size == i, "Expected Stack Size = " + i +", Actual Size =" + thisStack.Size);
                Assert.IsTrue(thisStack.Top().ToString().Equals(i.ToString()), "Expected Top = "+ i +", Actual Top =" + thisStack.Top());
            }
            
            //Insert when the stack is full.
            try
            {
                thisStack.Push(9);
                Assert.Fail("Stack overload worked with 9 elements");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType().Equals(typeof(Exception)) && ex.Message.Equals("Stack Overflow exception!"));
                //throw;
            }
            
            //Insert when the stack is overflowing
            try
            {
                thisStack.Push(10);
                Assert.Fail("Stack overload worked with 10 elements");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType().Equals(typeof(Exception)) && ex.Message.Equals("Stack Overflow exception!"));
            }
        }

        [TestMethod()]
        [TestCategory("BVT")]
        public void PopTests()
        {
            try
            {
                thisStack.Pop();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType().Equals(typeof(Exception)) && ex.Message.Equals("Stack is empty!"));
            }

            thisStack.Push(1);
            Assert.IsTrue(thisStack.Size == 1, "Expected Stack Size = 1, Actual Size =" + thisStack.Size);
            Assert.IsTrue(thisStack.Top().ToString().Equals("1"), "Expected Top = 1, Actual Top =" + thisStack.Top());
            

            thisStack.Pop();
            Assert.IsTrue(thisStack.Size == 0, "Expected Stack Size = 0, Actual Size =" + thisStack.Size);

            //Insert into stack with elements
            for (int i = 1; i <= 8; i++)
            {
                thisStack.Push(i);
                Assert.IsTrue(thisStack.Size == i, "Expected Stack Size = " + i + ", Actual Size =" + thisStack.Size);
                Assert.IsTrue(thisStack.Top().ToString().Equals(i.ToString()), "Expected Top = " + i + ", Actual Top =" + thisStack.Top());
            }

            //Insert into stack with elements
            for (int i = 8; i > 0; i--)
            {
                thisStack.Pop();
                Assert.IsTrue(thisStack.Size == i-1, "Expected Stack Size = " + (i-1) + ", Actual Size =" + thisStack.Size);
                if (i == 1)
                {
                    try
                    {
                        thisStack.Top();
                    }
                    catch (Exception ex)
                    {
                        Assert.IsTrue(ex.GetType().Equals(typeof(Exception)) && ex.Message.Equals("Stack is empty!"));
                    }
                }
                else
                {
                    Assert.IsTrue(thisStack.Top().ToString().Equals((i - 1).ToString()), "Expected Top = " + (i - 1) + ", Actual Top =" + thisStack.Top());
                }
                
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            thisStack = null;
        }
    }
}
