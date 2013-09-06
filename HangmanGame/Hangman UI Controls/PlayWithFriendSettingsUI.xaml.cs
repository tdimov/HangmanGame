using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HangmanGame.Hangman_Source;

namespace HangmanGame.Hangman_UI_Controls
{
    /// <summary>
    /// First and second player set their names and first player sets category and word
    /// </summary>
    public partial class PlayWithFriendSettingsUI : Page
    {
        public PlayWithFriendSettingsUI()
        {
            InitializeComponent();
        }

        private void StartGameButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.CheckAllFields())
            {
                MessageBox.Show("You must fill in all text fields!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Player firstPlayer = new Player(this.FirstPlayerName.Text);
                Player secondPlayer = new Player(this.SecondPlayerName.Text);
                Category gameCategory = new Category(this.Category.Text);
                Word gameWord = new Word(this.Word.Text);
                WordChecker checker = new WordChecker(gameWord);
                MultiplayerGame game = new MultiplayerGame(firstPlayer, secondPlayer, gameCategory, gameWord, checker);
                MultiplayerGameUI gameUI = new MultiplayerGameUI(game);
                this.NavigationService.Navigate(gameUI);
            }
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new KindGameUI());
        }

        private bool CheckAllFields()
        {
            bool isEmpty = true;

            if (this.FirstPlayerName.Text == "" || this.SecondPlayerName.Text == "" || this.Category.Text == "" || this.Word.Text == "")
            {
                return isEmpty;
            }

            return false;
        }

    }
}
