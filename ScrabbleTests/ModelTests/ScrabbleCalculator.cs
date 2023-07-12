using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;


namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleGameTests
    {
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
            string userInput = "Jason";
            ScrabbleGame newScrabbleGame = new ScrabbleGame(userInput);
            string word = newScrabbleGame.UserWord;
            Assert.AreEqual(userInput, word);
        }
        
    }
}