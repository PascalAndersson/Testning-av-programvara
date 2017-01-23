using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Int_Three_Should_ConvertTo_Fizz()
        {
            FizzBuzzlib fB = new FizzBuzzlib();

            int threeToFizz = 3;
            string expectedOutput = "Fizz";
            string actualOutput = fB.ConvertThreeToFizz(threeToFizz);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void Int_Five_Should_ConvertTo_Buzz()
        {
            FizzBuzzlib fB = new FizzBuzzlib();

            int fiveToBuzz = 5;
            string expectedOutput = "Buzz";
            string actualOuput = fB.ConvertFiveToBuzz(fiveToBuzz);

            Assert.AreEqual(expectedOutput, actualOuput);
        }

        [TestMethod]
        public void Int_Three_And_Int_Three_Should_ConvertTo_FizzBuzz()
        {
            FizzBuzzlib fB = new FizzBuzzlib();

            int threeToFizz = 3;
            int fiveToBuzz = 5;

            string expectedOutput = "FizzBuzz";
            string actualOuput = fB.ConvertThreeAndFiveToFizzBuzz(threeToFizz, fiveToBuzz);

            Assert.AreEqual(expectedOutput, actualOuput);
        }
    }
}
