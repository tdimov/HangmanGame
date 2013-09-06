using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangmanGame.Hangman_Source;

namespace HangmanGame.Hangman_Source
{
    public class MultiplayerGame : Game
    {
        private Player secondPlayer;
        /// <summary>
        /// Creates new multiplayer game
        /// </summary>
        /// <param name="firstPlayer">First player</param>
        /// <param name="secondPlayer">Second player</param>
        /// <param name="category">Game category</param>
        /// <param name="word">Game word</param>
        /// <param name="checker">Word checker</param>
        public MultiplayerGame(Player firstPlayer, Player secondPlayer, Category category, Word word, WordChecker checker)
            : base(firstPlayer, category, word, checker)
        {
            this.secondPlayer = secondPlayer;
        }

        /// <summary>
        /// Second player who play
        /// </summary>
        public Player SecondPlayer
        {
            get { return this.secondPlayer; }
            set { this.secondPlayer = value; }
        }
    }
}
