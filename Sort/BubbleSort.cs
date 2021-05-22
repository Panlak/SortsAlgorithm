using Pastel;
using System;
using System.Numerics;

namespace Bubble_Sort
{
	public  class BubbleSortAlg
	{
		protected static void Swap(ref BigInteger aFirstArg, ref BigInteger aSecondArg)
		{
			BigInteger tmpParam = aFirstArg;
			aFirstArg = aSecondArg;
			aSecondArg = tmpParam;
		}
		protected static void Swap(ref int aFirstArg, ref int aSecondArg)
		{
			int tmpParam = aFirstArg;
			aFirstArg = aSecondArg;
			aSecondArg = tmpParam;
		}
		public static void Bubble_Sort(BigInteger[] anArray)
		{

			for (int i = 0; i < anArray.Length; i++)
			{
				for (int j = 0; j < anArray.Length - 1 - i; j++)
				{
					if (anArray[j] > anArray[j + 1])
					{
						
						Swap(ref anArray[j], ref anArray[j + 1]);
						
					}
				}
			}
		}
		public static void Print(BigInteger[] arrey , BigInteger num1 , BigInteger num2,bool flag)
		{
			if (flag)
			{
				Console.Write("До: \t");
				for (int i = 0; i < arrey.Length; i++)
				{

					if (arrey[i] == num1 || arrey[i] == num2)
						Console.Write(arrey[i].ToString().Pastel("#ff0000") + " ");
					else
						Console.Write(arrey[i].ToString().Pastel("#00ff04") + " ");
				}
			}
			else
			{
				Console.Write("Після: \t");
				for (int i = 0; i < arrey.Length; i++)
				{
					if (arrey[i] == num1 || arrey[i] == num2)
						Console.Write(arrey[i].ToString().Pastel("##fbff00") + " ");
					else
						Console.Write(arrey[i].ToString().Pastel("#00ff04") + " ");
				}
			}

			
			Console.WriteLine("");
			Console.WriteLine("");
		}

	}
}
