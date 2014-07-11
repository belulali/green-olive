using NUnit.Framework;
using System;

namespace GreenOliveTests
{
	[TestFixture]
	public class PlateTests
	{
		const string dishName = "llapingacho";
		const int dishPrice = 4;

		[Test]
		public void TestADishCanHaveAName()		
		{
			Dish dish = new Dish();
			dish.Name = dishName;

			Assert.AreEqual (dishName, dish.Name);
		}
			
		[Test]
		public void TestADishCanHaveAPrice()
		{
			var dish = new Dish { Price = dishPrice };

			Assert.AreEqual (dishPrice, dish.Price);
		}
	}
}

