using System.Collections.Generic;

namespace Scrabble.Models
{
    public class ScrabbleGame
    {
        public string UserWord { get; set; }
        // private _userWord
        // Business Logic goes here.
        public Dictionary<char, int> ScrabbleKey { get; } = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 } };

        public int WordScore { get; set; }

        public ScrabbleGame(string userWord)
        {
            UserWord = userWord.ToLower();
            CalculateWordScore();
        }

        private void CalculateWordScore()
        {
            for( int i = 0; i < UserWord.Length; i++)
            {
                char letter = UserWord[i];
                int pointValue = ScrabbleKey[letter];
                WordScore += pointValue;
            }
        }

    }
}