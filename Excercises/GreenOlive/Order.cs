using System;
using System.Collections.Generic;

namespace GreenOliveTests

{

	public class Order
	{
		private Dictionary<Dish, int> _orderItems = new Dictionary<Dish, int>();

		public double Price 
		{
			get 
			{
				var totalPrice = 0;
				foreach (var dishItem in _orderItems) 
				{
					var dishPrice = dishItem.Key.Price * dishItem.Value;
					totalPrice += dishPrice;
				}
				return totalPrice;
			}
		}

		public double VAT {
			get 
			{
				return Price * 0.12;
			}
		}

		public double TotalPrice
		{
			get 
			{
				return Price + VAT;
			}
		}

		public void Add (Dish dish, int quantity)
		{
			_orderItems.Add (dish, quantity);	
		}

		public bool HasDish (Dish dish)
		{
			return _orderItems.ContainsKey (dish);
		}

		public object HowManyOf (Dish dish)
		{
			return _orderItems [dish];
		}

		public int CalculateTotalPricePerPlate (Dish plate)
		{
			int totalPricePerPlate = 0;
			int quantity;
			_orderItems.TryGetValue(plate, out quantity);
			totalPricePerPlate += plate.Price * quantity;
			return totalPricePerPlate;
		}

		public string GetDetails ()
		{
			string details = "";
			foreach(Dish plate in _orderItems.Keys)
			{
				details += GetIndividualDetails(plate) +  ".........................." + CalculateTotalPricePerPlate(plate) + "\n";
			}
			return details;
		}

		 
		private string GetIndividualDetails (Dish plate)
		{
			string name = plate.Name;
			int price = plate.Price;
			int quantity;
			_orderItems.TryGetValue(plate, out quantity);
			return quantity + "\t" + name.ToUpper() + "\t@\t" + price + "\n";
		}
	}
}

	


