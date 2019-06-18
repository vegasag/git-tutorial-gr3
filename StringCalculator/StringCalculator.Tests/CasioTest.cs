using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    public class CasioTests
    { 
        [Test]
        public void CheckIfEmptyString()
        {
            // Arrange
            var calc = new Casio();


            // Act
            var result = calc.Add("");


            // Assert
            Assert.AreEqual(0, result);
        }
    }
}