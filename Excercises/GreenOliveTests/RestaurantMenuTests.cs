using NUnit.Framework;
using System;
using System.Collections.Generic;
using NUnit.Framework.SyntaxHelpers;

namespace GreenOliveTests
{
	[TestFixture]
	public class RestaurantMenuTests
	{
		private Dish _dish;
		private Dish _dish2;
		List<Dish> _dishes;
		RestaurantMenu _menu;


		[SetUp]
		public void SetUp ()
		{
			_dish = new Dish {Name = "llapingacho"};
			_dish2 = new Dish();
			_dishes = new List<Dish>();
			_menu = new RestaurantMenu (_dishes);
		}

		[Test]
		public void TestDishCanBeAddedToAMenu ()		
		{
			_menu.Add(_dish);

			var menuDishes = _menu.Dishes;

			int numberOfDishes = menuDishes.Count;
			Assert.AreEqual(1, numberOfDishes);
		}

		[Test]
		public void TestDishCanBeRemovedFromTheMenu ()		
		{
			_menu.Add(_dish);
			_menu.Add(_dish2);
			_menu.Remove(_dish);

			var menuDishes = _menu.Dishes;

			Assert.That (menuDishes, Has.Member (_dish2));
			Assert.That (menuDishes, Has.No.Member (_dish));
		}

		[Test]
		public void TestShouldReturnADishFromTheMenuByItsName()		
		{
			_menu.Add(_dish);

			var foundDish = _menu.FindDish (_dish.Name);

			Assert.AreEqual (_dish, foundDish);
		}
	}
}
