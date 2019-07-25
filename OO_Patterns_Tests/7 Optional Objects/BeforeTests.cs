using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._7_Optional_Objects.Before;
using System;

namespace OO_Patterns_Tests._7_Optional_Objects.Before
{
	[TestClass]
	public class BeforeTests
	{
		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void ThrowsNullReference_WhenArticleDoesNotHaveCircuitry()
		{
			var article = new SoldArticle();
			article.ClaimCircuitryWarranty(() => { });
		}
	}
}
