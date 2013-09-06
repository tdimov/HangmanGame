using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Hangman_Source
{
    public class Player
    {
        private string playerName;

        /// <summary>
        /// Creates a new player
        /// </summary>
        /// <param name="playerName">The name of the player</param>
        public Player(string playerName)
        {
            this.playerName = playerName;
        }

        /// <summary>
        /// The name of the player
        /// </summary>
        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }
    }
}
