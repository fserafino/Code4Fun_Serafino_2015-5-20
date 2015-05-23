﻿using System;
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
            int CurrentArrayLength = new Random().Next();
            int ShuffleArray = new ShuffleArray().GetShuffleArray(CurrentArrayLength).Length;
        } 

        [Test]
        public void ArrayShouldNotContainsDuplicates()
        {
            
        }
    }
}
