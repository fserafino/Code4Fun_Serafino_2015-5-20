using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Code4Fun.Exercises;

namespace Code4Fun.Tests
{
    [TestFixture]

    public class ShuffleArrayTest

    {
        [Test]
        public void ArrayShouldContainsNItems()
        {
            int ExpectedArrayLength = new Random().Next(1, Convert.ToInt32(ushort.MaxValue));
            int CurrentArrayLength = new ShuffleArray().GetShuffleArray(ExpectedArrayLength).Length;
            Assert.AreEqual(ExpectedArrayLength, CurrentArrayLength);
        } 

        [Test]
        public void ArrayShouldNotContainsDuplicates()
        {
            int ExpectedArrayLength = new Random().Next(1, Convert.ToInt32(ushort.MaxValue));
            int[] CurrentArrayLength = new ShuffleArray().GetShuffleArray(ExpectedArrayLength);
            Assert.That(CurrentArrayLength, Is.Unique);
        }

        [Test]
        public void ArrayMinimumIsOne()
        {
            int ExpectedMinimum = 1;
            int CurrentMinimum = new ShuffleArray().GetShuffleArray(new Random().Next(1, Convert.ToInt32(ushort.MaxValue))).Min();
            Assert.AreEqual(ExpectedMinimum, CurrentMinimum);
        }

        [Test]
        public void ArrayMaximumIsEqualToItsLength()
        {
            int ExpectedMaximum = new Random().Next(1, Convert.ToInt32(ushort.MaxValue));
            int CurrentMaximum = new ShuffleArray().GetShuffleArray(ExpectedMaximum).Max();
            Assert.AreEqual(ExpectedMaximum, CurrentMaximum);
        }

        [Test]
        public void UpperCaseNotAllowed()
        {
            string StringToBeEncoded = "hello World";
            string ExpectedString = "Error, one or more characters not allowed";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }

        [Test]
        public void SpecialCharactersNotAllowed()
        {

        }

        [Test]
        public void TestOne()
        {

        }

        [Test]
        public void TestTwo()
        {

        }

        [Test]
        public void TestThree()
        {

        }

        [Test]
        public void TestFour()
        {

        }

        [Test]
        public void TestFive()
        {

        }

        [Test]
        public void TestSix()
        {

        }

        [Test]
        public void TestSeven()
        {

        }

        [Test]
        public void TestEight()
        {

        }

        [Test]
        public void TestNine()
        {

        }
    }
}
