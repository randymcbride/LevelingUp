using System;
using System.Collections.Generic;
using System.Linq;

namespace OO_Patterns.Looping.After
{
	public static class IEnumerableExtensions
	{
		public static T WithMinimum<T, Key>
			(this IEnumerable<T> sequence, Func<T, Key> operation)
			where Key : IComparable<Key> 
			=> sequence
				.Select(t => Tuple.Create(t, operation(t)))
				.Aggregate((min, current) => current.Item2.CompareTo(min.Item2) < 0 ? current : min)
				.Item1;
	}
}
