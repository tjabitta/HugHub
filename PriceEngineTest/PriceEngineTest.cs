﻿using System;
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
        IPriceEngine priceEngine;
        [TestInitialize()]
        public void Initialize()
        {
            priceEngine = new PriceEngine();
        }
        [TestMethod]
        public void TestGetPrice()
        {
            decimal actualPrice = Decimal.Parse("92.67");
            decimal actualTax = Decimal.Parse("11.1204");
            string actualInsurer = "zxcvbnm";
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
            var expectedPrice = priceEngine.GetPrice(request, out tax, out insurer, out error);

            Assert.AreEqual(actualPrice, expectedPrice);
            Assert.AreEqual(actualTax, tax);
            Assert.AreEqual(actualInsurer, insurer);
        }
    }
}
