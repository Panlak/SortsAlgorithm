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

			Console.WriteLine("''Найпростіші алгоритми сортування''".Pastel("#fbff00"));
			Console.WriteLine("Сортування бульбальшкою".Pastel("#00ffff"));
			Console.Write("Початковий масив:\t");
			BigInteger[] someArray = randomArrey(20);
			Print(someArray,false);
			var sw1 = new Stopwatch();
			sw1.Start();
			BubbleSortAlg.Bubble_Sort(someArray);
			sw1.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw1.Elapsed}".Pastel("#ffbb00"));
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вибором".Pastel("#00ffff"));
			BigInteger[] someArraySelection = randomArrey(20);
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw2 = new Stopwatch();
			sw2.Start();
			ChoiseAlg.ViborSort(someArraySelection);
			sw2.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw2.Elapsed}".Pastel("#ffbb00"));
			
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вставкою".Pastel("#00ffff"));		
			someArray = randomArrey(20);
			Console.Write("Початковий масив:\t");
			Print(someArray,false);
			var sw3 = new Stopwatch();
			sw3.Start();
			InsertSortAlg.InsertionSort(someArray);
			sw3.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw3.Elapsed}".Pastel("#ffbb00"));
			Console.WriteLine("-----------------------------------------------------------------------------".Pastel("#00ff59"));
			Console.WriteLine("Наступна Лаблаторна Вдосконалені алгоритми сортування".Pastel("#fbff00"));
			Console.WriteLine("-----------------------------------------------------------------------------".Pastel("#00ff59"));
			
			//////////////////////////////////////////////////////////////////////////////////////////////////

			Console.WriteLine("Сортування Шела".Pastel("#00ffff"));
			someArray = randomArrey(20);
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw4 = new Stopwatch();
			sw4.Start();
			ShellSort.Shell(someArray);
			sw4.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine($"Time Spent: {sw4.Elapsed}".Pastel("#ffbb00"));
			Console.WriteLine("-----------------------------------------------------------------------------");
			Console.WriteLine("Порозрядне сортування".Pastel("#00ffff"));
			someArray = randomArrey(20);
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw5 = new Stopwatch();
			sw5.Start();
			BitwiseSorting.sorting(someArray,10,2);
			sw5.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray, true);		
			Console.WriteLine($"Time Spent: {sw5.Elapsed}".Pastel("#ffbb00"));	
			Console.WriteLine("-------------------------------------------------------------------------------");
			Console.WriteLine("Швидке сортування".Pastel("#00ffff"));
			someArray = randomArrey(20);
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw6 = new Stopwatch();
			sw6.Start();
			QuickSort.QuickSortM(someArray);
			Console.Write("Відсортований  масив:\t");
			Print(someArray, true);
			sw6.Stop();
			Console.WriteLine($"Time Spent: {sw6.Elapsed}".Pastel("#ffbb00"));
			Console.WriteLine("-------------------------------------------------------------------------------");
			Console.WriteLine("Сортування підрахунком".Pastel("#00ffff"));
			someArray = randomArrey(20);
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			var sw8 = new Stopwatch();
			sw8.Start();
			СountingСalculations.CountingSort(someArray);
			sw8.Stop();
			Console.Write("Відсортований  масив:\t");
			Print(someArray, true);
			Console.WriteLine($"Time Spent: {sw8.Elapsed}".Pastel("#ffbb00"));
			Console.WriteLine("-------------------------------------------------------------------------------");
		}

		public static BigInteger[] randomArrey(int max)
		{
			Random random = new Random();
			BigInteger[] arrey = new BigInteger[max];
			for (int i = 0; i < arrey.Length; i++)
			{
				arrey[i] = random.Next(1, max);
			}
			return arrey;
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