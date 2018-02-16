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
            string givenString = "Cat";
            Assert.AreEqual("never", testRepeatCounter.CountMatches ("cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordIsInStringButNextToLetters_Never()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cats";
            Assert.AreEqual("never", testRepeatCounter.CountMatches ("cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordIsInStringNextToOkayChars_Once()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "A cat slept.";
            Assert.AreEqual("once", testRepeatCounter.CountMatches ("cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordIsInStringTwice_Twice()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cat cat";
            Assert.AreEqual("twice", testRepeatCounter.CountMatches ("cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordIsInStringThrice_Thrice()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cat cat cat";
            Assert.AreEqual("thrice", testRepeatCounter.CountMatches ("cat", givenString));
        }
        [TestMethod]
        public void CountsWord_TargetWordIsInString4Times_4Times()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "cat cat cat cat";
            Assert.AreEqual("4 times", testRepeatCounter.CountMatches ("cat", givenString));
        }
        [TestMethod]
        public void CountsWord_DoesEverytingForALongerString_Thrice()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter();
            string givenString = "Cat cats cat scat scatter cats cat's cat; car cat";
            Assert.AreEqual("thrice", testRepeatCounter.CountMatches ("cat", givenString));
        }
    }
}
