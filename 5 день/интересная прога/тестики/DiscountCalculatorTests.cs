using Microsoft.VisualStudio.TestTools.UnitTesting;
using Master_floor;

namespace MasterFloorTests
{
    [TestClass]
    public class DiscountCalculatorTests
    {
        private DiscountCalculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new DiscountCalculator();
        }

        [TestMethod]
        public void TestLowSales_NoDiscount()
        {
            // Arrange
            double salesAmount = 5000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("0%", discountResult);
        }

        [TestMethod]
        public void TestMediumSales_FivePercentDiscount()
        {
            // Arrange
            double salesAmount = 15000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("5%", discountResult);
        }

        [TestMethod]
        public void TestHighSales_TenPercentDiscount()
        {
            // Arrange
            double salesAmount = 60000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("10%", discountResult);
        }

        [TestMethod]
        public void TestVeryHighSales_FifteenPercentDiscount()
        {
            // Arrange
            double salesAmount = 400000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("15%", discountResult);
        }

        [TestMethod]
        public void TestBoundaryTenThousand_FivePercentDiscount()
        {
            // Arrange
            double salesAmount = 10000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("5%", discountResult);
        }

        [TestMethod]
        public void TestBoundaryFiftyThousand_TenPercentDiscount()
        {
            // Arrange
            double salesAmount = 50000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("10%", discountResult);
        }

        [TestMethod]
        public void TestBoundaryTwoHundredThousand_FifteenPercentDiscount()
        {
            // Arrange
            double salesAmount = 200000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("15%", discountResult);
        }

        [TestMethod]
        public void TestZeroSales_NoDiscount()
        {
            // Arrange
            double salesAmount = 0;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("0%", discountResult);
        }

        [TestMethod]
        public void TestSalesJustBelowThreshold_NoDiscount()
        {
            // Arrange
            double salesAmount = 9999.99;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("0%", discountResult);
        }

        [TestMethod]
        public void TestSalesJustAboveMaximum_FifteenPercentDiscount()
        {
            // Arrange
            double salesAmount = 500000;
            
            // Act
            string discountResult = DiscountCalculator.CalculateDiscount(salesAmount);
            
            // Assert
            Assert.AreEqual("15%", discountResult);
        }
    }
}
