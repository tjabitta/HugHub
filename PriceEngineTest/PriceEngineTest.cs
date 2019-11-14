using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ConsoleApp1.Domain.Interfaces;
using ConsoleApp1.Domain.Models;
using ConsoleApp1.Domain.Services;

namespace PriceEngineTest
{
    [TestClass]
    public class PriceEngineTest
    {

        [TestInitialize()]
        public void Initialize()
        {

        }
        [TestMethod]
        public void TestGetPrice()
        {
            decimal actualPrice = Decimal.Parse("92.67");
            var request = new PriceRequest()
            {
                RiskData = new RiskData()
                {
                    DOB = DateTime.Parse("1980-01-01"),
                    FirstName = "John",
                    LastName = "Smith",
                    Make = "Cool New Phone",
                    Value = 500
                }
            };

            decimal tax = 0;
            string insurer = "";
            string error = "";
            IPriceEngine priceEngine = new PriceEngine();
            var expectedPrice = priceEngine.GetPrice(request, out tax, out insurer, out error);

            Assert.AreEqual(actualPrice, expectedPrice);
        }
    }
}
