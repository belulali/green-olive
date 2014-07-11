using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace GreenOliveTests
{
	[TestFixture]
	public class CashRegisterTests
	{

		[Test ()]
		public void testCashRegisterPrintsBillWithTheOrderDetails ()		
		{
			Order orderMock = MockRepository.GenerateMock<Order>;
			CashRegisterTests chashRegister = new CashRegisterTests(); 

		}
	}
}

