using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpTipsAndTraps.Traps
{
	[TestClass]
	public class CallingVirtualMethodFromConstructor
	{
		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void Test()
		{
			//Take a look at the implementation of the Base and Derived classes below to 
			//see why the ToString method throws an InvalidOperationException
			var derived = new Derived();
			Debug.WriteLine(derived.ToString());
		}
	}

	class Base
	{
		public Base()
		{
			//Call to a virtual method in a constructor can lead to unexpected results.
			SetDefaultProperties();
		}
		public DateTime? FavoriteDate { get; set; }
		//This method will always work in the base class, but if a derived class overrides 
		//the SetDefaultProperty method they could create problems.
		public override string ToString() => $"My favorite day of the year is {FavoriteDate.Value.Month} - {FavoriteDate.Value.Day}";
		protected virtual void SetDefaultProperties()
		{
			FavoriteDate = new DateTime(0, 12, 25);
		}
	}

	class Derived : Base
	{
		//A Derived class overrides the virtual method, and now the FavoriteDate property is not being set
		protected override void SetDefaultProperties()
		{

		}
	}
}
