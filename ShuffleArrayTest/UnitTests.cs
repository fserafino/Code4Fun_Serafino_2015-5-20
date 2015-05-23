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
    }
}
