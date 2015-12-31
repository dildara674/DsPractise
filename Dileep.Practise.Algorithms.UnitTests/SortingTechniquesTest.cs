using System;
using System.Linq;
using System.Text;
using Dileep.Practise.Algorithms.SortingTechniques;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dileep.Practise.Algorithms.UnitTests
{
    [TestClass]
    public class SortingTechniquesTest
    {
        private int[] input;
        [TestInitialize]
        public void Intialize()
        {
            input = new int[200000];
            Random random = new Random();
            for (int i = 0; i < 200000; i++)
            {
                input[i] = random.Next(900000);
            }
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            InsertionSort sorting = new InsertionSort();
            sorting.Sort(input);

            StringBuilder builder = new StringBuilder();
            input.ToList().ForEach(i => builder.Append(i + ","));
            Console.WriteLine(builder.ToString().TrimEnd(','));
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            SelectionSort sorting = new SelectionSort();
            sorting.Sort(input);

            StringBuilder builder = new StringBuilder();
            input.ToList().ForEach(i => builder.Append(i + ","));
            Console.WriteLine(builder.ToString().TrimEnd(','));
        }
    }
}
