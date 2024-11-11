using KiemThuCoBan_Lab_1_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_2_Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        #region Test add method
        [Test]
        public void Calculator_Add_ReturnsSumOfZeroNumber()
        {
            var result = _calculator.Add(0, 0);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfZeroOneNumber()
        {
            var result = _calculator.Add(0, 1);
            Assert.That (result, Is.EqualTo(1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfOneZeroNumber()
        {
            var result = _calculator.Add(1, 0);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfNegativeZeroNumber()
        {
            var result = _calculator.Add(-1, 0);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfZeroNegativeNumber()
        {
            var result = _calculator.Add(0, -1);
            Assert.That(result, Is.EqualTo(-1));
        }
        [Test]
        public void Calculator_Add_ReturnsSumOfNegativePositiveNumber()
        {
            var result = _calculator.Add(-1, 1);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Calculator_Add_ReturnsIntMaxValue()
        {
            var aiFirstNumber = int.MaxValue - 1;
            var aiSecondNumber = 1;
            var result = _calculator.Add(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }
        [Test]
        public void Calculator_Add_ReturnsIntMinValue()
        {
            var aiFirstNumber = int.MinValue + 1;
            var aiSecondNumber = -1;
            var result = _calculator.Add(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MinValue));
        }
        [Test]
        public void Calculator_Add_ReturnsValueWithMaxMinValue()
        {
            var aiFirstNumber = int.MaxValue ;
            var aiSecondNumber = int.MinValue;
            var result = _calculator.Add(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(-1));
        }
        #endregion

        #region Test subtract method
        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfZeroNumber()
        {
            var result = _calculator.Subtract(0, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfZeroOneNumber()
        {
            var result = _calculator.Subtract(0, 1);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfOneZeroNumber()
        {
            var result = _calculator.Subtract(1, 0);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfNegativeZeroNumber()
        {
            var result = _calculator.Subtract(-1, 0);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfZeroNegativeNumber()
        {
            var result = _calculator.Subtract(0, -1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Calculator_Subtract_ReturnsDifferenceOfNegativePositiveNumber()
        {
            var result = _calculator.Subtract(-1, 1);
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void Calculator_Subtract_ReturnsIntMaxValue()
        {
            var aiFirstNumber = int.MaxValue;
            var aiSecondNumber = 0;
            var result = _calculator.Subtract(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MaxValue));
        }

        [Test]
        public void Calculator_Subtract_ReturnsIntMinValue()
        {
            var aiFirstNumber = int.MinValue;
            var aiSecondNumber = 0;
            var result = _calculator.Subtract(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(int.MinValue));
        }

        [Test]
        public void Calculator_Subtract_ReturnsValueWithMaxMinValue()
        {
            var aiFirstNumber = int.MaxValue;
            var aiSecondNumber = int.MaxValue;
            var result = _calculator.Subtract(aiFirstNumber, aiSecondNumber);
            Assert.That(result, Is.EqualTo(0));
        }
        #endregion

        #region Test factorial method
        [Test]
        public void Calculator_Factorial_ReturnsOneWithZero()
        {
            Assert.That(_calculator.Factorial(0), Is.EqualTo(1));
        }
        [Test]
        public void Calculator_Factorial_ReturnsOneWithOne()
        {
            Assert.That(_calculator.Factorial(1), Is.EqualTo(1));
        }
        [Test]
        public void Calculator_Factorial_ReturnsPositive()
        {
            Assert.That(_calculator.Factorial(2), Is.EqualTo(2));
            Assert.That(_calculator.Factorial(3), Is.EqualTo(6));
            Assert.That(_calculator.Factorial(4), Is.EqualTo(24));
            Assert.That(_calculator.Factorial(5), Is.EqualTo(120));
        }
        [Test]
        public void Calculator_Factorial_ThrowException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Factorial(-1));
        }
        #endregion
    }
}
