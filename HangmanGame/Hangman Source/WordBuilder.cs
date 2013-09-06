using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace HangmanGame.Hangman_Source
{
    public class WordBuilder
    {
        private StackPanel wordPanel;
        private Word gameWord;
        private List<Label> letters;

        /// <summary>
        /// Creates a new word builder to visialized a word
        /// </summary>
        /// <param name="wordPanel">Panel for visualization of the word</param>
        /// <param name="gameWord">Game word</param>
        public WordBuilder(StackPanel wordPanel, Word gameWord)
        {
            this.wordPanel = wordPanel;
            this.gameWord = gameWord;
            this.letters = new List<Label>();
        }

        public StackPanel WordPanel
        {
            get { return this.wordPanel; }
            set { this.wordPanel = value; }
        }
        /// <summary>
        /// Displayed on the player each letter as a dash
        /// </summary>
        /// <param name="gameWord">Game word</param>
        public void BuildWord(Word gameWord)
        {
            for (int index = 0; index < gameWord.GameWord.Length; index++)
            {
                Label letter = new Label();
                letter.Foreground = Brushes.White;
                letter.FontSize = 16;
                letter.FontFamily = new FontFamily("Tekton Pro Ext");

                if (this.gameWord.GameWord[index] != ' ')
                {
                    letter.Content = '-';
                }
                else
                {
                    letter.Content = ' ';
                }

                this.letters.Add(letter);
                this.wordPanel.Children.Add(letter);
            }
        }

        /// <summary>
        /// Shows a letter on the player
        /// </summary>
        /// <param name="letter">Letter from word which should be displayed on the player</param>
        public void ShowLetter(char letter)
        {
            for (int index = 0; index < this.gameWord.GameWord.Length; index++)
            {
                if (this.gameWord.GameWord[index] == letter)
                {
                    letters[index].Content = letter;
                }
            }
        }

        /// <summary>
        /// Method which looks for a dashes
        /// </summary>
        public bool LookForDash()
        {
            bool isLetter = true;

            foreach (Label letter in letters)
            {
                if (letter.Content.Equals('-'))
                {
                    return false;
                }
            }

            return isLetter;
        }
    }
}
