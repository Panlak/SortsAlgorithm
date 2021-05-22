using Bubble_Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
	public  class ChoiseAlg : BubbleSortAlg
    {
        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }
        public static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Print(array, array[index], array[currentIndex],true);
                Swap(ref array[index], ref array[currentIndex]);
                Print(array, array[index], array[currentIndex], false);
            }

            return SelectionSort(array, currentIndex + 1);
        }
    }
}
