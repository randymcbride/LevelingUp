using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
	public class GeoService
	{
		public LatAndLong LatAndLong { get; } = new LatAndLong();
	}

	public class LatAndLong
	{
		internal Tuple<double, double> FromAddress(string origin)
		{
			return new Tuple<double, double>(1.0, 1.0);
		}
	}
}
