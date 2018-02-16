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
        public void WordValid_TargetWordEmpty_Error1()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "The quick brown fox jumps over the lazy dog";
            Assert.AreEqual("Error: please input a word to compare", testRepeatCounter.CountMatches ("", givenString));
        }
        [TestMethod]
        public void WordValid_TargetWordInvalid_Error2()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "I saw a cat";
            Assert.AreEqual("Error: input was not a word", testRepeatCounter.CountMatches ("a cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordAndStringSame_Once()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cat";
            Assert.AreEqual("once", testRepeatCounter.CountMatches ("cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordAndStringDifferent_Never()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cat";
            Assert.AreEqual("never", testRepeatCounter.CountMatches ("Cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordIsInStringButNextToLetters_Never()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cat";
            Assert.AreEqual("never", testRepeatCounter.CountMatches ("cats", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordIsInStringNextToOkayChars_Once()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cat";
            Assert.AreEqual("once", testRepeatCounter.CountMatches ("A cat slept.", givenString));
        }
    }
}
