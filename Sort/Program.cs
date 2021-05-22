using Bubble_Sort;
using Sort;
using System;
using Pastel;
using System.Numerics;
using System.Diagnostics;
namespace BubbleSort
{
	//n^2
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;
			Console.WriteLine("Сортування бульбальшкою");
			Console.Write("Початковий масив:\t");
			BigInteger[] someArray = new BigInteger[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
			Print(someArray,false);
			Console.WriteLine();
			BubbleSortAlg.Bubble_Sort(someArray);
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вибором");
			BigInteger[] someArraySelection = new BigInteger[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			Console.WriteLine();
			ChoiseAlg.ViborSort(someArraySelection);
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вставкою");		
			someArray = new BigInteger[] { 40, 30, 10, 70, 50, 20, 60, };
			Console.Write("Початковий масив:\t");
			Print(someArray,false);
			Console.WriteLine();
			InsertSortAlg.InsertionSort(someArray);
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);

			Console.WriteLine("-------------------------------------------------------------------------------");
			Random random = new Random();
			BigInteger[] arrey = new BigInteger[10000];
			var sw = new Stopwatch();			
			for (int i = 0; i < arrey.Length; i++)
			{
				arrey[i] = random.Next(10,100);
			}
			sw.Start();
			InsertSortAlg.InsertionSort(arrey);
			sw.Stop();
			Console.WriteLine($"Time Spent: {sw.Elapsed}");



		}
		public static void Print(BigInteger[] arrey,bool color)
		{
			for (int i = 0; i < arrey.Length; i++)
			{
				if(color == false)
					Console.Write(arrey[i].ToString().Pastel("#e1ff00") + " ");
				else
					Console.Write(arrey[i].ToString().Pastel("##00ff04") + " ");
			}
			Console.WriteLine();
		}
	}
}