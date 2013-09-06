using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangmanGame.Hangman_Source
{
    class WordsReader
    {
        /// <summary>
        /// Gets list of words for given category
        /// </summary>
        /// <param name="tableName">The name of category</param>
        /// <returns>List of words for given category</returns>
        public List<Word> GetWords(string categoryName)
        {
            List<Word> words = new List<Word>();
            StreamReader reader = new StreamReader(@"..\..\Hangman Words\" + categoryName + ".txt");

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    words.Add(new Word(line));
                    line = reader.ReadLine();
                }
            }

            return words;
        }
    }
}
