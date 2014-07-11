using System;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

 
namespace GreenOliveTests
{
	[TestFixture]
	public class OrderTests
	{
		private Dish _dish1;
		private Dish _dish2;
		private Order _order;

		[SetUp]
		public void SetUp ()
		{
			_dish1 = new Dish {Name = "llapingacho", Price = 3};
			_dish2 = new Dish {Name = "locro", Price = 2};
			_order = new Order ();
		}

		[Test]
		public void ShouldHaveADish()
		{
			_order.Add (_dish1, 1);

			var hasDish = _order.HasDish (_dish1);

			Assert.That (hasDish, Is.True);
		}

		[Test]
		public void ShouldLetUsKnowTheQuantityOfADish()
		{
			const int expectedQuantity = 3;
			_order.Add (_dish1, expectedQuantity);

			var askedDishQuantity = _order.HowManyOf (_dish1);

			Assert.That (askedDishQuantity, Is.EqualTo (expectedQuantity));
		}

		[Test]
		public void ShouldReturnThePriceOfTheOrder() 
		{
			var dish1Quantity = 1;
			var dish2Quantity = 2;

			_order.Add (_dish1, dish1Quantity);
			_order.Add (_dish2, dish2Quantity);

			var expectedPrice = _dish1.Price * dish1Quantity + _dish2.Price * dish2Quantity;

			var actualPrice = _order.Price;

			Assert.That (actualPrice, Is.EqualTo (expectedPrice));
		}

		[Test]
		public void ShouldReturnZeroWhenNoDishesInTheOrder()
		{
			var actualPrice = _order.Price;

			Assert.AreEqual (0, actualPrice);
		}

		[Test]
		public void ShouldReturnZeroVATWhenNoDishesInTheOrder() 
		{
			var actualTax = _order.VAT;

			Assert.That (actualTax, Is.EqualTo (0));
		}

		[Test]
		public void ShouldNotReturnZeroVATIfThereAreDishesInTheOrder() 
		{
			var dish1Quantity = 1;
			_order.Add (_dish1, dish1Quantity);

			var price = _dish1.Price * dish1Quantity;
			var tax = price * 0.12;

			var actualTax = _order.VAT;

			Assert.That (actualTax, Is.EqualTo (tax));
		}

		[Test]
		public void ShouldReturnZeroWhenTheTotalPriceOfTheOrderIsZero()
		{
			var actualTotalPrice = _order.TotalPrice;

			Assert.That (actualTotalPrice, Is.EqualTo (0));
		}

		[Test]
		public void ShouldReturnTheTotalPriceOfTheOrder()
		{
			var dishQuantity = 2;
			_order.Add (_dish1, dishQuantity);

			var price = _order.Price;
			var tax = _order.VAT;
			var totalPrice = price + tax;

			var actualTotalPrice = _order.TotalPrice;

			Assert.That (actualTotalPrice, Is.EqualTo (totalPrice));
		}
			
//		[Test]
//		public void testCanCalculateTheTotal()		
//		{
//			_order.Add (_dish1, 2);
//			_order.Add (_plate2, 2);
//			Assert.AreEqual(11.2, _order.CalculateTotal());
//		}
//
//
//		[Test]
//		public void testReturnsFormatedData()		
//		{
//			_order.Add (_dish1, 2);
//			_order.Add (_plate2, 2);
//			Assert.AreEqual("2\tLLAPINGACHO\t@\t3\n..........................6\n2\tLOCRO\t@\t2\n..........................4\n", _order.GetDetails());
//		}
//
	}
}

