using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralGenerator.Controllers;
using RomanNumeralGenerator.Models;

namespace RomanNumeralGenerator.Tests
{
    [TestClass]
    public class NumeralConversionTests
    {

        [TestMethod]
        public void TestValid4()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToNumeral("4");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("IV", NumeralValue);
        }

        [TestMethod]
        public void TestValid9()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToNumeral("9");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("IX", NumeralValue);
        }

        [TestMethod]
        public void TestValid20()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToNumeral("20");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("XX", NumeralValue);
        }

        [TestMethod]
        public void TestValid179()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToNumeral("179");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("CLXXIX", NumeralValue);
        }

        [TestMethod]
        public void TestValid549()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToNumeral("549");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("DXLIX", NumeralValue);
        }

        [TestMethod]
        public void TestValid1998()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToNumeral("1998");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("MCMXCVIII", NumeralValue);
        }

        [TestMethod]
        public void TestValidMMXLIX()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToNumeral("2049");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("MMXLIX", NumeralValue);
        }



    }
}
