using System;
using NUnit.Framework;

namespace Calculator.Test
{
    public class CalculatorTest {
        [Test]
        public void TestAddOfAAndB()
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Add(2, 5);

            // assert
            Assert.That(result, Is.EqualTo(7));
        }

        // Anvender TestCaseAttribute for dual purpose: ramme flere mulige testcases for Add
        [TestCase(5, 0, 5)]
        [TestCase(5, 5, 10)]
        [TestCase(5, -5, 0)]
        [TestCase(-5, -5, -10)]
        public void TestAddOfAAndB(int a, int b, double intendedResult)
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Add(a, b);

            // assert
            Assert.That(result, Is.EqualTo(intendedResult));
        }



        [Test]
        public void TestSubstractionOfAAndB()
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Substraction(10,5);

            // assert
            Assert.That(result, Is.EqualTo(5));
        }

        // Anvender TestCaseAttribute for dual purpose: ramme flere mulige testcases for Substraction
        [TestCase(5, 0, 5)]
        [TestCase(0, 5, -5)]
        [TestCase(5, 5, 0)]
        [TestCase(5, -5, 10)]
        [TestCase(-5, -5, 0)]
        [TestCase(20, 5, 15)]
        public void TestSubstractionOfAAndB(int a, int b, double intendedResult)
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Substraction(a, b);

            // assert
            Assert.That(result, Is.EqualTo(intendedResult));
        }




        [Test]
        public void TestMultiplicationOfAAndB()
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Multiply(10, 10);

            // assert
            Assert.That(result, Is.EqualTo(100));
        }

        // Anvender TestCaseAttribute for dual purpose: ramme flere mulige testcases for Multiplication
        [TestCase(5, 0, 0)]
        [TestCase(0, -5, 0)]
        [TestCase(5, 5, 25)]
        [TestCase(-5, -5, 25 )]
        [TestCase(-5, 5, -25 )]
        public void TestMultiplicationOfAAndB(int a, int b, double intendedResult)
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Multiply(a, b);

            // assert
            Assert.That(result, Is.EqualTo(intendedResult));
        }



        [Test]
        public void TestThatXIsRaisedToThePowerOfEXP()
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Power(10, 2);

            // assert
            Assert.That(result, Is.EqualTo(100));

        }

        // Anvender TestCaseAttribute for dual purpose: ramme flere mulige testcases for Math.Power()
        [TestCase(5, 0, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(0, -5, double.PositiveInfinity)]
        [TestCase(5, -5, 0.00032)]
        [TestCase(-5, 5, -3125)]
        [TestCase(-2, 0, -1)]
        public void TestThatXIsRaisedToThePowerOfEXP(int a, int b, double intendedResult)
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Power(a, b);

            // assert
            Assert.That(result, Is.EqualTo(intendedResult));
        }


        // Anvender TestCaseAttribute for dual purpose: ramme flere mulige testcases for Divided
        [TestCase(8, 2, 4)]
        [TestCase(10, 2, 5)]
        [TestCase(5, 0, double.PositiveInfinity)]
        [TestCase(0, 3, 0)]
        public void TestThatDividedISDividedWithDivisor(double divided, double divisor, double intendedResult)
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.Divide(divided, divisor);

            // assert
            Assert.That(result, Is.EqualTo(intendedResult));
        }

        // Anvender TestCaseAttribute for dual purpose: ramme flere mulige testcases for Math.Sqrt()
        [TestCase(36, 6)]
        [TestCase(-5, double.NaN)]
        [TestCase(16,4)]
        [TestCase(49, 7)]
        public void TestSqrtOfa(double a, double intendedResult)
        {
            // arrange
            var cal = new Calculator();

            // act 
            var result = cal.SquareRoot(a);

            // assert
            Assert.That(result, Is.EqualTo(intendedResult));
        }

    }
}

