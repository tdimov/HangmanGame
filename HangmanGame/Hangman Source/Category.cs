using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Hangman_Source
{
    public class Category
    {
        private string categoryName;
        private List<Word> words;

        /// <summary>
        /// Creates new category
        /// </summary>
        /// <param name="categoryName">The name of category</param>
        public Category(string categoryName)
        {
            this.categoryName = categoryName;
        }

        /// <summary>
        /// The name of category
        /// </summary>
        public String CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }

        /// <summary>
        /// List of words which the category contains
        /// </summary>
        public List<Word> Words
        {
            get { return this.words; }
            set { this.words = value; }
        }

        /// <summary>
        /// Get random word from the category
        /// </summary>
        /// <returns>Returns the selected word</returns>
        public Word GetRandomWord()
        {
            Random rnd = new Random();

            Word word;

            if (this.words != null)
            {
                word = new Word(this.words[rnd.Next(0, this.words.Count - 1)].GameWord.ToUpper());
            }
            else
            {
                throw new ArgumentNullException("The list of words is empty!");
            }

            return word;
        }

    }
}
