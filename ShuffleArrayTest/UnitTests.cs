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

    public class UnitTests

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
            string StringToBeEncoded = "h*el^l3o Wo)ld";
            string ExpectedString = "Error, one or more characters not allowed";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }

        [Test]
        public void TestOne()
        {
            string StringToBeEncoded = "b";
            string ExpectedString = "22";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }

        [Test]
        public void TestTwo()
        {
            string StringToBeEncoded = "aa";
            string ExpectedString = "2_2";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }

        [Test]
        public void TestThree()
        {
            string StringToBeEncoded = "hi";
            string ExpectedString = "44_444";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }

        [Test]
        public void TestFour()
        {
            string StringToBeEncoded = "yes";
            string ExpectedString = "999337777";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }

        [Test]
        public void TestFive()
        {
            string StringToBeEncoded = "foo  bar";
            string ExpectedString = "333666_6660_022_2777";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }

        [Test]
        public void TestSix()
        {
            string StringToBeEncoded = "helloworld";
            string ExpectedString = "4433555_55566696667775553";
            string CurrentString = new PhoneKeypad().GetTheEncodedString(StringToBeEncoded);
            Assert.AreEqual(ExpectedString, CurrentString);
        }
    }
}
