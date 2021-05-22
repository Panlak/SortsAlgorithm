using Bubble_Sort;
using Sort;
using System;
using Pastel;
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
			int[] someArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
			Print(someArray,false);
			Console.WriteLine();
			BubbleSortAlg.Bubble_Sort(someArray);
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вибором");	
			someArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
			Console.Write("Початковий масив:\t");
			Print(someArray, false);
			Console.WriteLine();
			ChoiseAlg.SelectionSort(someArray);
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------------------------------------------");
			////////////////////////////////////////////////////////////
			Console.WriteLine("Сортування вставкою");		
			someArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
			Console.Write("Початковий масив:\t");
			Print(someArray,false);
			Console.WriteLine();
			InsertSortAlg.InsertionSort(someArray);
			Console.Write("Відсортований  масив:\t");
			Print(someArray,true);
		}

		public static void Print(int[] arrey,bool color)
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