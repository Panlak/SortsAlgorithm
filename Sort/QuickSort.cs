using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
	class QuickSort : BitwiseSorting
	{
        public static int Partition(BigInteger[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        public static BigInteger[] QuickSortM(BigInteger[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSortM(array, minIndex, pivotIndex - 1);
            QuickSortM(array, pivotIndex + 1, maxIndex);
            return array;
        }
        public static BigInteger[] QuickSortM(BigInteger[] array)
        {
            return QuickSortM(array, 0, array.Length - 1);
        }
    }
}
