using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;
using System.Collections.Generic;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void IsAnagram_TargetWordDifferent_False()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "The quick brown fox jumps over the lazy dog";
            Assert.AreEqual("Error: please input a word to compare", testRepeatCounter.CountMatches ("", givenString));
        }
    }
}
