using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dileep.Practise.Algorithms.SortingTechniques
{
    public class InsertionSort
    {
        public void Sort(int[] input,bool ascending = true)
        {
            var startTime = DateTime.Now;
            for (int i = 1; i < input.Length; i++)
            {
                bool condition = ascending ? (input[i] < input[i - 1]) : (input[i] > input[i - 1]);
                if (condition)
                {
                    int j = i;
                    while (j > 0 )
                    {
                        condition = ascending ? (input[j] < input[j - 1]) : (input[j] > input[j - 1]);
                        if (condition)
                        {
                            int temp = input[j];
                            input[j] = input[j - 1];
                            input[j - 1] = temp;
                            j--;
                        }
                        else
                        {
                            j = 0;
                        }
                    }
                }
            }
            var endTime = DateTime.Now;
            Console.WriteLine("Took" + (endTime-startTime).TotalMilliseconds);
        }
    }
}
