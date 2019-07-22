using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._6_Avoiding_Nulls.Before;
using System;

namespace OO_Patterns_Tests._6_Avoiding_nulls
{
	[TestClass]
	public class NullTests
	{
		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void NullTest()
		{
			var articleWithoutWarranty = new SoldArticle(null);
			var canBeReturned = articleWithoutWarranty.CanBeReturned;
		}
	}
}
