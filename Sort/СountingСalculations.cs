using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
	class СountingСalculations : BitwiseSorting
	{
        public static BigInteger[] CountingSort(BigInteger[] array)
        {
            //поиск минимального и максимального значений
            var min = array[0];
            var max = array[0];
            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
                else if (element < min)
                {
                    min = element;
                }
            }

            //поправка
            var correctionFactor = min != 0 ? -min : 0;
            max += correctionFactor;

            var count = new int[(ulong)max + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[(ulong)(array[i] + correctionFactor)]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i - correctionFactor;
                    index++;
                }
            }

            return array;
        }
    }
}
