using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Hangman_Source
{
    public class Word
    {
        private string gameWord;

        /// <summary>
        /// Creates a new word for the game
        /// </summary>
        /// <param name="gameWord">Word for the game</param>
        public Word(string gameWord)
        {
            this.gameWord = gameWord.ToUpper();
        }

        /// <summary>
        /// Word for the game
        /// </summary>
        public string GameWord
        {
            get { return this.gameWord; }
            set { this.gameWord = value; }
        }
    }
}
