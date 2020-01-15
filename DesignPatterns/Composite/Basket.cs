using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite
{
	public class Basket : IAsset
	{
		public List<IAsset> Assets { get; set; } = new List<IAsset>();

		public decimal Value => Assets.Sum(a => a.Value);

		public decimal Return(DateTime? begin = null, DateTime? end = null) => Assets.Sum(a => a.Return(begin, end));
	}
}
