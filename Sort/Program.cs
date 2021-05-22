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
			var sw1 = new Stopwatch();
			sw1.Start();
			BubbleSortAlg.Bubble_Sort(someArray);
			sw1.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw1.Elapsed}");
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вибором");
			BigInteger[] someArraySelection = new BigInteger[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			Console.WriteLine();
			var sw2 = new Stopwatch();
			sw2.Start();
			ChoiseAlg.ViborSort(someArraySelection);
			sw2.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw2.Elapsed}");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вставкою");		
			someArray = new BigInteger[] { 40, 30, 10, 70, 50, 20, 60, };
			Console.Write("Початковий масив:\t");
			Print(someArray,false);
			Console.WriteLine();
			var sw3 = new Stopwatch();
			sw3.Start();
			InsertSortAlg.InsertionSort(someArray);
			sw3.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw3.Elapsed}");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------------------------------------------");
			//////////////////////////////////////////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування Шела");
			someArray = new BigInteger[] { 40, 30, 10, 70, 50, 20, 60, };
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw4 = new Stopwatch();
			sw4.Start();
			ShellSort.Shell(someArray);
			sw4.Stop();
			Console.WriteLine();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw4.Elapsed}");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------------------------------------------");
			Console.WriteLine("Порозрядне сортування");
			someArray = new BigInteger[] { 39, 47, 54, 59, 34, 41, 32 };
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw5 = new Stopwatch();
			sw5.Start();
			BitwiseSorting.sorting(someArray,10,2);
			sw5.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray, true);
			Console.WriteLine("");
			Console.WriteLine($"Time Spent: {sw5.Elapsed}");
			Console.WriteLine();
			Console.WriteLine("-------------------------------------------------------------------------------");
			Console.WriteLine("Швидке сортування");
			someArray = new BigInteger[] { 39, 47, 54, 59, 34, 41, 32 };
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw6 = new Stopwatch();
			sw6.Start();
			QuickSort.QuickSortM(someArray);
			Console.Write("Відсортований  масив:\t");
			Print(someArray, true);
			sw6.Stop();
			Console.WriteLine("");
			Console.WriteLine($"Time Spent: {sw6.Elapsed}");
			Console.WriteLine();
			Console.WriteLine("-------------------------------------------------------------------------------");
			Console.WriteLine("Сортування підрахунком");
			someArray = new BigInteger[] { 39, 47, 54, 59, 34, 41, 32,36,46 };
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw8 = new Stopwatch();
			sw8.Start();
			СountingСalculations.CountingSort(someArray);
			sw8.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray, true);
			Console.WriteLine($"Time Spent: {sw8.Elapsed}");
			Console.WriteLine();
			Console.WriteLine("-------------------------------------------------------------------------------");




			Random random = new Random();
			BigInteger[] arrey = new BigInteger[10000];
			var sw7 = new Stopwatch();			
			for (int i = 0; i < arrey.Length; i++)
			{
				arrey[i] = random.Next(10,100);
			}
			sw7.Start();
			InsertSortAlg.InsertionSort(arrey);
			sw7.Stop();
			Console.WriteLine($"Time Spent: {sw7.Elapsed}");
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