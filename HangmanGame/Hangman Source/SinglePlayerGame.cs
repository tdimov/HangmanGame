using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Hangman_Source
{
    public class SinglePlayerGame : Game
    {
        /// <summary>
        /// Creates a new singleplayer game
        /// </summary>
        /// <param name="player">Player who play</param>
        /// <param name="category">Game category</param>
        /// <param name="word">Game word</param>
        /// <param name="checker">Word checker</param>
        public SinglePlayerGame(Player player, Category category, Word word, WordChecker checker)
            : base(player, category, word, checker)
        {
        }
    }
}
