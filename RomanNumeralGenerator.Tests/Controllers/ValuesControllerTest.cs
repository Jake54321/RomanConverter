using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralGenerator;
using RomanNumeralGenerator.Controllers;

namespace RomanNumeralGenerator.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {

        [TestMethod]
        public void GetByNumeral()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Get("CLXXIX");

            // Assert
            Assert.AreEqual("179", result);
        }

        [TestMethod]
        public void GetByArabic()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Get("1998");

            // Assert
            Assert.AreEqual("MCMXCVIII", result);
        }


    }
}
