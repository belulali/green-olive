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
			Order orderMock = MockRepository.GenerateStub<Order>;
			orderMock.Stub (x => x.GetDetails()).Return("1\tLLAPINGACHO\t@\t4");
			CashRegister cashRegister = new CashRegister ();
			cashRegister.printBill (orderMock);
			Assert


		}
	}
}

