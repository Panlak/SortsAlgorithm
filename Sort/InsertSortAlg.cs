using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
	public class InsertSortAlg : ChoiseAlg
    {
        public static  void InsertionSort(int[] inArray)
        {
            int x;
            int j;
            for (int i = 1; i < inArray.Length; i++)
            {
                x = inArray[i];
                j = i;
                while (j > 0 && inArray[j - 1] > x)
                {
                    Print(inArray, inArray[j], inArray[j - 1],true);
                    Swap(ref inArray[j],ref inArray[ j - 1]);
                    Print(inArray, inArray[j], inArray[j - 1], false);
                    j -= 1;
                }
                inArray[j] = x;
            }
        }
    }
}
