using System.Collections.Generic;

namespace Scrabble.Models
{
    public class ScrabbleGame
    {
        public string UserWord { get; set; }
        // private _userWord
        // Business Logic goes here.
        public Dictionary<char, int> ScrabbleKey { get; } = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 } };

        public static List<ScrabbleGame> GameCollection { get; set;} = new List<ScrabbleGame> {};

        public static int HighScore { get; set; }
        public static string HighScoreWord { get; set; }

        private void CalculateHighScore()
        {
            if(GameCollection.Count == 1)
            {
                HighScore = WordScore;
                HighScoreWord = UserWord;
            } else{
                for( int i = 0; i < GameCollection.Count; i++)
            {
               if(GameCollection[i].WordScore>HighScore)
               {
                HighScore = GameCollection[i].WordScore;
                HighScoreWord = GameCollection[i].UserWord;
               }
            }
            }
        }

        public int WordScore { get; set; }

        public ScrabbleGame(string userWord)
        {
            UserWord = userWord.ToLower();
            CalculateWordScore();
            GameCollection.Add(this);
            CalculateHighScore();
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