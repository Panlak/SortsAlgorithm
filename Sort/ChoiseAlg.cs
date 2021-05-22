using Bubble_Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
	public  class ChoiseAlg : BubbleSortAlg
    {
        public static BigInteger[] ViborSort(BigInteger[] mas)
        {

            for (int i = 0; i < mas.Length - 1; i++)
            {         
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                Swap(ref mas[min],ref mas[i]);
             
            }
            return mas;
        }
    }
}
