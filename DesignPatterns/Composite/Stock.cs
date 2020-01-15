using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
	public class Stock : IAsset
	{
		public List<Valuation> Valuations { get; set; } = new List<Valuation>();
		public decimal Value => Valuations.OrderByDescending(v => v.Date).FirstOrDefault()?.Value ?? 0;

		public decimal Return(DateTime? begin = null, DateTime? end = null)
		{
			var valuation1 = begin.HasValue
				? Valuations.OrderByDescending(v => v.Date).FirstOrDefault(v => v.Date <= begin.Value)
				: Valuations.OrderBy(v => v.Date).FirstOrDefault();

			var valuation2 = end.HasValue
				? Valuations.OrderBy(v => v.Date).FirstOrDefault(v => v.Date >= end.Value)
				: Valuations.OrderByDescending(v => v.Date).FirstOrDefault();

			if (valuation1 == null || valuation2 == null)
				throw new ArgumentOutOfRangeException("We dont have data for that range");

			return valuation2.Value - valuation1.Value;
		}
	}
}
