using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
	public class InsertSortAlg : ChoiseAlg
    {
        public static  void InsertionSort(BigInteger[] inArray)
        {
            for (int i = 0; i < inArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inArray[j - 1] > inArray[j])
                    {
                       
                        Swap(ref inArray[j], ref inArray[j - 1]);
                      
                       
                    }

                }
            }
        }
    }
}
