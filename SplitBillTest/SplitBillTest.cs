using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitBillClassLibrary;
using SplitBillClassLibrary.YourLibraryName;

namespace SplitBillTest
{
    [TestClass]
    public class SplitterTests
    {
        
            [TestMethod]
            public void SplitAmount_EqualSplit_ShouldReturnCorrectValue()
            {
                // Arrange
                var splitter = new Splitter();

                // Act
                var result = splitter.SplitAmount(100, 10);

                // Assert
                Assert.AreEqual(20, result);
            }

            [TestMethod]
            public void SplitAmount_ReturnsZero_WhenTotalAmountIsZero()
            {
                // Arrange
                var calculator = new Splitter();

                // Act
                decimal result = calculator.SplitAmount(0, 10);

                // Assert
                Assert.AreEqual(0, result);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void SplitAmount_ThrowsException_WhenNumberOfPeopleIsZero()
            {
                // Arrange
                var calculator = new Splitter();

                // Act
                decimal result = calculator.SplitAmount(100, 0);

                // Assert
                // Exception is expected to be thrown
            }

        [TestMethod]
        public void TipPerPerson_ReturnsCorrectTipAmount_WhenValidInput()
        {
            // Arrange
            var calculator = new TipCalculator();
            decimal totalPrice = 100;
            int numberOfPeople = 5;
            float tipPercentage = 15;

            // Act
            decimal result = calculator.TipPerPerson(totalPrice, numberOfPeople, tipPercentage);

            // Assert
            Assert.AreEqual(3, result); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TipPerPerson_ThrowsException_WhenNumberOfPeopleIsZero()
        {
            // Arrange
            var calculator = new TipCalculator();
            decimal totalPrice = 100;
            int numberOfPeople = 0;
            float tipPercentage = 15;

            // Act
            decimal result = calculator.TipPerPerson(totalPrice, numberOfPeople, tipPercentage);

            // Assert
            // Exception is expected to be thrown
        }

    }

}