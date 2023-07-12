using System.Collections.Generic;

namespace Scrabble.Models
{
    public class ScrabbleGame
    {
        public string UserWord { get; set; }
        // Business Logic goes here.
        public ScrabbleGame(string userWord)
        {
            UserWord = userWord;
        }

    }
}