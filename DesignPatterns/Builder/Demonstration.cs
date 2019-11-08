using DesignPatterns.Builder.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Builder
{
	[TestClass]
	public class Demonstration
	{
		[TestMethod]
		public void Demo()
		{
			var director = new BoardGameDirector();
			var terraformingMars = director.Build(new TerraformingMarsBuilder());
			var brassBurmingham = director.Build(new BrassBurminghamBuilder());
			Debug.WriteLine(terraformingMars.ToString());
			Debug.WriteLine(brassBurmingham.ToString());
		}
	}
}
