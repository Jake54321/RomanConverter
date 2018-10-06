using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralGenerator.Controllers;
using RomanNumeralGenerator.Models;

namespace RomanNumeralGenerator.Tests
{
    [TestClass]
    public class ArabicConversionTests
    {
        [TestMethod]
        public void TestI()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("I");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("1",NumeralValue);            
        }

        [TestMethod]
        public void TestV()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("V");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("5", NumeralValue);
        }


        [TestMethod]
        public void TestX()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("X");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("10", NumeralValue);
        }

        [TestMethod]
        public void TestL()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("L");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("50", NumeralValue);
        }

        [TestMethod]
        public void TestC()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("C");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("100", NumeralValue);
        }

        [TestMethod]
        public void TestD()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("D");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("500", NumeralValue);
        }

        [TestMethod]
        public void TestM()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("M");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("1000", NumeralValue);
        }

        [TestMethod]
        public void TestValidIV()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("IV");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("4", NumeralValue);
        }

        [TestMethod]
        public void TestValidIX()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("IX");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("9", NumeralValue);
        }

        [TestMethod]
        public void TestValidXX()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("XX");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("20", NumeralValue);
        }

        [TestMethod]
        public void TestValidCLXXIX()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("CLXXIX");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("179", NumeralValue);
        }

        [TestMethod]
        public void TestValidDXLIX()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("DXLIX");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("549", NumeralValue);
        }

        [TestMethod]
        public void TestValidMCMXCVIII()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("MCMXCVIII");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("1998", NumeralValue);
        }

        [TestMethod]
        public void TestValidMMXLIX()
        {
            string NumeralValue = "";
            NumeralValue = NumeralGenerator.ConvertToArabic("MMXLIX");
            Assert.IsNotNull(NumeralValue);
            Assert.AreEqual("2049", NumeralValue);
        }


    }
}
