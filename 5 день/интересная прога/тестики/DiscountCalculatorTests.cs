using Microsoft.VisualStudio.TestTools.UnitTesting;
using Master_floor;

namespace MasterFloorTests
{
    [TestClass]
    public class DiscountCalculatorTests
    {
        [TestMethod]
        public void CalculateDiscount_WithTotalLessThan10000_Returns0Percent()
        {
            // Arrange
            decimal total = 5000;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("0%", result);
        }

        [TestMethod]
        public void CalculateDiscount_WithTotalBetween10000And49999_Returns5Percent()
        {
            // Arrange
            decimal total = 15000;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("5%", result);
        }

        [TestMethod]
        public void CalculateDiscount_WithTotalBetween50000And199999_Returns10Percent()
        {
            // Arrange
            decimal total = 60000;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("10%", result);
        }

        [TestMethod]
        public void CalculateDiscount_WithTotal200000OrMore_Returns15Percent()
        {
            // Arrange
            decimal total = 400000;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("15%", result);
        }

        [TestMethod]
        public void CalculateDiscount_WithExactly10000_Returns5Percent()
        {
            // Arrange
            decimal total = 10000;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("5%", result);
        }

        [TestMethod]
        public void CalculateDiscount_WithExactly50000_Returns10Percent()
        {
            // Arrange
            decimal total = 50000;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("10%", result);
        }

        [TestMethod]
        public void CalculateDiscount_WithExactly200000_Returns15Percent()
        {
            // Arrange
            decimal total = 200000;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("15%", result);
        }

        [TestMethod]
        public void CalculateDiscount_WithTotalZero_Returns0Percent()
        {
            // Arrange
            decimal total = 0;
            
            // Act
            string result = DiscountCalculator.CalculateDiscount(total);
            
            // Assert
            Assert.AreEqual("0%", result);
        }
    }
}
