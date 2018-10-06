using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralGenerator.Models;
using RomanNumeralGenerator.Controllers;

namespace RomanNumeralGenerator.Tests
{
    [TestClass]
    public class InvalidInput
    {

        [TestMethod]
        public void TestEmpty()
        {
            NumeralGenerator.InputType result = NumeralGenerator.InputType.Error;
            Assert.AreEqual(result, NumeralGenerator.DetermineInputType(""));
        }

        [TestMethod]
        public void TestArabicNegative()
        {
            NumeralGenerator.InputType result = NumeralGenerator.InputType.Error;
            Assert.AreEqual(result, NumeralGenerator.DetermineInputType("345-5234"));
        }

        [TestMethod]
        public void TestNArabicSymbol()
        {
            NumeralGenerator.InputType result = NumeralGenerator.InputType.Error;
            Assert.AreEqual(result, NumeralGenerator.DetermineInputType("234#343"));
        }

        [TestMethod]
        public void TestNumeralNegative()
        {
            NumeralGenerator.InputType result = NumeralGenerator.InputType.Error;
            Assert.AreEqual(result, NumeralGenerator.DetermineInputType("XVI-9DCL"));
        }

        [TestMethod]
        public void TestNumeralSymbol()
        {
            NumeralGenerator.InputType result = NumeralGenerator.InputType.Error;
            Assert.AreEqual(result, NumeralGenerator.DetermineInputType("IVX*I"));
        }

        [TestMethod]
        public void TestNumeralcSpace()
        {
            NumeralGenerator.InputType result = NumeralGenerator.InputType.Error;
            Assert.AreEqual(result, NumeralGenerator.DetermineInputType("DLIV IX"));
        }


    }
}
