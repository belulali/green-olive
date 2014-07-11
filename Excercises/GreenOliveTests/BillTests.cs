using System;
using NUnit;
using NUnit.Framework;
using Rhino.Mocks;

namespace GreenOliveTests
{
	[TestFixture]
	public class BillTests
	{
		[Test ()]
		public void testReturnsTheDetailsOfTheOrder() {
			Order orderMock = MockRepository.GenerateMock<Order>();
			Bill bill = new Bill (orderMock);
			orderMock.Stub (mock => mock.GetDetails ());
			//Assert.AreEqual ("GREEN\tOLIVE\n" +
			//	"FACTURA\n2\tLLAPINGACHO\t@\t3\n", bill.ShowDetails ());
		}

	}
}

