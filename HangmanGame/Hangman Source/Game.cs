using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Hangman_Source
{
    public abstract class Game
    {
        private Player player;
        private Category category;
        private Word word;
        private WordChecker checker;

        /// <summary>
        /// Creates new game
        /// </summary>
        /// <param name="player">Game player</param>
        /// <param name="category">Game category</param>
        /// <param name="word">Game word</param>
        /// <param name="checker">Word checker that checks the word</param>
        public Game(Player player, Category category, Word word, WordChecker checker)
        {
            this.player = player;
            this.category = category;
            this.word = word;
            this.checker = checker;
        }

        /// <summary>
        /// The player of the game 
        /// </summary>
        public Player Player
        {
            get { return this.player; }
            set { this.player = value; }
        }

        /// <summary>
        /// The category of the game
        /// </summary>
        public Category Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        /// <summary>
        /// The word of the game
        /// </summary>
        public Word Word
        {
            get { return this.word; }
            set { this.word = value; }
        }

        /// <summary>
        /// The word checker
        /// </summary>
        public WordChecker Checker
        {
            get { return this.checker; }
            set { this.checker = value; }
        }
    }
}
