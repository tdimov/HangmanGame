using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Hangman_Source
{
    public class WordChecker
    {
        private Word wordVerification;

        /// <summary>
        /// Creates a new word checker
        /// </summary>
        /// <param name="wordVerification">Word for verification</param>
        public WordChecker(Word wordVerification)
        {
            this.wordVerification = wordVerification;
        }

        /// <summary>
        /// The word that has to be check
        /// </summary>
        public Word WordVerification
        {
            get { return this.wordVerification; }
            set { this.wordVerification = value; }
        }

        /// <summary>
        /// Checks the word by letter
        /// </summary>
        /// <param name="letter">Letter that should be check</param>
        /// <returns>Returns whether the word exists ot not</returns>
        public bool CheckWordByLatter(char letter)
        {
            bool exist = true;

            for (int index = 0; index < this.wordVerification.GameWord.Length; index++)
            {
                if (this.wordVerification.GameWord[index] == letter)
                {
                    return exist;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks the word with a word that is proposed by the player
        /// </summary>
        /// <param name="word">Proposed word</param>
        /// <returns>Returns whether the words match</returns>
        public bool CheckWordByWord(Word word)
        {
            bool exist = true;

            if (this.wordVerification.GameWord.Contains(word.GameWord))
            {
                return exist;
            }

            return false;
        }
    }
}
