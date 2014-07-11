using System;

namespace GreenOliveTests
{
	public class Bill
	{
		private Order _order;

		public Bill (Order order)
		{
			this._order = order;
		}

		public string ShowDetails ()
		{
			return "GREEN\tOLIVE\nFACTURA\n" + _order.GetDetails();
		}
	}
}

