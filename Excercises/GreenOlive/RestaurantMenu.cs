using System;
using System.Collections.Generic;


namespace GreenOliveTests
{
	public class RestaurantMenu
	{
		private List<Dish> _dishes;

		public RestaurantMenu(List<Dish> dishes)
		{
			this._dishes = dishes;
		}

		public List<Dish> Dishes 
		{
			get { return _dishes; }
		}

		public void Add (Dish dish)
		{
			_dishes.Add (dish);
		}

		public void Remove (Dish dish)
		{
			_dishes.Remove (dish);
		}

		public Dish FindDish (string name)
		{
			foreach(Dish dishItem in _dishes)
			{
				if (dishItem.Name.Equals(name)) 
				{
					return dishItem;
				}
			}
			return null;
		}
	}
}

