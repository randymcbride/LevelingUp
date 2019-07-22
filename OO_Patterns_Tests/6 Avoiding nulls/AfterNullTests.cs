using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._6_Avoiding_Nulls.After;
using System;

namespace OO_Patterns_Tests._6_Avoiding_nulls
{
	[TestClass]
	public class AfterNullTests
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void ConstructorDoesNotAcceptNulls()
		{
			var articleWithoutWarranty = new SoldArticle(null);
			var canBeReturned = articleWithoutWarranty.CanBeReturned;
		}

		[TestMethod]
		public void VoidWarranty()
		{
			var articleWithoutWarranty = new SoldArticle(new VoidWarranty());
			var canBeReturned = articleWithoutWarranty.CanBeReturned;
			Assert.IsFalse(canBeReturned);
		}
	}
}
