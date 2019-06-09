using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns.Looping
{
	public class Painter
	{
		public bool IsAvailable { get; set; }
		public double Rate { get; set; }
		public double GetEstimate(double squareFeet) => squareFeet * Rate;
	}
}
