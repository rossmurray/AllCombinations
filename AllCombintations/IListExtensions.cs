using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCombintations
{
	public static class IListExtensions
	{
		public static IEnumerable<IEnumerable<T>> AllCombinations<T>(this IList<T> source)
		{
			yield return Enumerable.Empty<T>();
			var count = source.Count();
			ulong combinationMax = (ulong)1 << count;
			for (ulong mask = 1; mask < combinationMax; mask++)
			{
				var combination = new List<T>();
				for (int i = 0; i < count; i++)
				{
					if (((ulong)1 << i & mask) != 0)
					{
						combination.Add(source[i]);
					}
				}
				yield return combination;
			}
			yield break;
		}
	}
}
