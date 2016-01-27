using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dileep.Practise.Algorithms.SortingTechniques
{
    public class SelectionSort
    {
        public void Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < input.Length; j++)
                {
                    if (input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    int temp = input[i];
                    input[i] = input[minIndex];
                    input[minIndex] = temp;
                }
            }
        }
    }
}
