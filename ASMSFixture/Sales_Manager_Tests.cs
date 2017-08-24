using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreSystem;

namespace ASMSFixture
{
    [TestClass]
    public class Sales_Manager_Tests
    {
        SalesManager manager;

        public Sales_Manager_Tests()
        {
            manager = new SalesManager();
        }

        [TestMethod]
        public void A_New_Sale_Should_Update_Sales_Record()
        {
            manager.NewSale(20330);
            Assert.IsTrue(manager.GetTodaysSale() == 20330);
        }
    }
}
