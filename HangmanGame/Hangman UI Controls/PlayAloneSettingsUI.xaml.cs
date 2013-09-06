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
    /// Here player sets your name and chooses from which category wants to be a word
    /// </summary>
    public partial class PlayAloneSettingsUI : Page
    {
        private WordsReader wordsReader = new WordsReader();

        public PlayAloneSettingsUI()
        {
            InitializeComponent();
        }

        private void StartGameButtonClick(object sender, RoutedEventArgs e)
        {
            Player player = new Player(this.PlayerName.Text);

            if (this.PlayerName.Text == "")
            {
                MessageBox.Show("You must set your player name!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Category gameCategory = GetCategory();
            Word gameWord = gameCategory.GetRandomWord();
            WordChecker checker = new WordChecker(gameWord);
            SinglePlayerGame game = new SinglePlayerGame(player, gameCategory, gameWord, checker);
            SingleGameUI gameUI = new SingleGameUI(game);

            this.NavigationService.Navigate(gameUI);
        }
        
        private Category GetCategory()
        {
            Category category = null;

            if ((bool)Animals.IsChecked)
            {
                category = new Category("Animals");
                category.Words = wordsReader.GetWords("Animals");
            }
            else if ((bool)Astrology.IsChecked)
            {
                category = new Category("Astrology");
                category.Words = wordsReader.GetWords("Astrology");
            }
            else if ((bool)BoysNames.IsChecked)
            {
                category = new Category("Boys Names");
                category.Words = wordsReader.GetWords("Boys Names");
            }
            else if ((bool)Cities.IsChecked)
            {
                category = new Category("Cities");
                category.Words = wordsReader.GetWords("Cities");
            }
            else if ((bool)Colours.IsChecked)
            {
                category = new Category("Colors");
                category.Words = wordsReader.GetWords("Colors");
            }
            else if ((bool)Countries.IsChecked)
            {
                category = new Category("Countries");
                category.Words = wordsReader.GetWords("Countries");
            }
            else if ((bool)GirlsNames.IsChecked)
            {
                category = new Category("Girls Names");
                category.Words = wordsReader.GetWords("Girls Names");
            }
            else if ((bool)Nouns.IsChecked)
            {
                category = new Category("Nouns");
                category.Words = wordsReader.GetWords("Nouns");
            }
            else if ((bool)Professions.IsChecked)
            {
                category = new Category("Professions");
                category.Words = wordsReader.GetWords("Professions");
            }
            else if ((bool)Sports.IsChecked)
            {
                category = new Category("Sports");
                category.Words = wordsReader.GetWords("Sports");
            }
            else
            {
                category = new Category("Verbs");
                category.Words = wordsReader.GetWords("Verbs");
            }

            return category;
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new KindGameUI());
        }
    }
}
