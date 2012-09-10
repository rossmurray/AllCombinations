using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCombintations
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new int[]{1, 2, 3};
			var allCombinations = list.AllCombinations();
			Console.WriteLine("Initial list: " + RenderCollection(list));
			Console.WriteLine("Combinations:");
			foreach (var combination in allCombinations)
			{
				Console.WriteLine(RenderCollection(combination));
			}
			Console.WriteLine("Total combinations: " + allCombinations.Count());
		}

		private static string RenderCollection<T>(IEnumerable<T> collection)
		{
			var sb = new StringBuilder("{");
			sb.Append(String.Join(", ", collection));
			sb.Append("}");
			return sb.ToString();
		}
	}
}
