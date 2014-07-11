using System;

namespace GreenOliveTests
{
	public class Dish
	{
		private string _name;
		private int _price;

		public string Name {
			get { return _name; }
			set { _name = value; }
		}

		public int Price {
			get { return _price; }
			set { _price = value; }
		}
	}
}

