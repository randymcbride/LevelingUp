using System;
using System.Collections;
using System.Collections.Generic;

namespace OO_Patterns._7_Optional_Objects.After
{
	public class Maybe<T>
	{
		private IEnumerable<T> Content { get; }

		public static Maybe<T> Some(T value) => new Maybe<T>(new T[] { value });
		public static Maybe<T> None() => new Maybe<T>(new T[0]);

		public void Do(Action<T> action)
		{
			foreach(T value in Content)
			{
				action(value);
			}
		}

		private Maybe(IEnumerable<T> content)
		{
			Content = content;
		}
	}
}
