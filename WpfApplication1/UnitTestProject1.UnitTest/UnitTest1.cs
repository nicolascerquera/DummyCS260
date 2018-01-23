using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1;

namespace UnitTestProject1.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldPass_GetsTwonumber_SumsThemCorrectly()
        {
            // Arrange
            Test_Class number = new Test_Class(12,10);
            // Act
            var num = number.Num1 + number.Num2;
            // Assert
            Assert.AreEqual(22,num);
        }
    }
}
