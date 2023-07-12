using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;


namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleGameTests : IDisposable
    {
        public void Dispose()
        {
            ScrabbleGame.GameCollection.Clear();
            // alternate method below
            // ScrabbleGame.GameCollection = new List<ScrabbleGame> { };
        }
        // Test methods go here
        [TestMethod]
        // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
        public void ScrabbleGameConstructor_InstantiateClass_ScrabbleGame()
        {
            ScrabbleGame newScrabbleGame = new ScrabbleGame("cat");
            Assert.AreEqual(typeof(ScrabbleGame), newScrabbleGame.GetType());
            // any necessary logic to prep for test; instantiating new classes, etc.
            // we can also use the arrange, act, assert organization in any test. 
            // Assert.AreEqual(ExpectedResult, CodeToTest);
        }

        [TestMethod]
        public void GetUserWord_AccessUserWordField_String()
        {
            string userInput = "jason";
            ScrabbleGame newScrabbleGame = new ScrabbleGame(userInput);
            string word = newScrabbleGame.UserWord;
            Assert.AreEqual(userInput, word);
        }

        [TestMethod]
        public void GetScrabbleKey_AccessScrabbleKeyField_Dictionary()
        {
            Dictionary<char, int> expectedDictionary = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 } };
            ScrabbleGame testScrabbleGame = new ScrabbleGame("dog");
            CollectionAssert.AreEqual(expectedDictionary, testScrabbleGame.ScrabbleKey);
        }

        [TestMethod]
        public void GetWordScore_AccessWordScore_Int()
        {
            string userInput = "jason";
            int expectedValue = 12;
            ScrabbleGame newScrabbleGame = new ScrabbleGame(userInput);
            int score = newScrabbleGame.WordScore;
            Assert.AreEqual(expectedValue, score);
        }

        [TestMethod]
        public void CalculateWordScore_AddUpPointsPerWord_Int()
        {
            string userInput = "cat";
            int expectedScore = 5;
            ScrabbleGame scrabbleGame = new ScrabbleGame(userInput);
            int realScore = scrabbleGame.WordScore;
            Assert.AreEqual(expectedScore, realScore);
        }

        [TestMethod]
        public void SetGameCollection_AddInstanceofScrabbleGameToList_List()
        {
            string userInput = "cat";
            ScrabbleGame scrabbleGame = new ScrabbleGame(userInput);
            Assert.AreEqual(1, ScrabbleGame.GameCollection.Count);
        }

        [TestMethod]
        public void GetHighScore_AddHighScore_void()
        {
            string userInput = "cat";
            string userInput2 = "jazz";
            string userInput3 = "hi";
            ScrabbleGame scrabbleGame = new ScrabbleGame(userInput);
            ScrabbleGame scrabbleGame2 = new ScrabbleGame(userInput2);
            ScrabbleGame scrabbleGame3 = new ScrabbleGame(userInput3);
            Assert.AreEqual(29, ScrabbleGame.HighScore);
            Assert.AreEqual("jazz", ScrabbleGame.HighScoreWord);
        }

    }
}