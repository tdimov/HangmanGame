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
    /// Singleplayer game where the player is trying to guess the word
    /// </summary>
    public partial class SingleGameUI : Page
    {
        private SinglePlayerGame game;
        private WordBuilder wordBuilder;
        private Hangman hangman;
        private int letterCount;

        public SingleGameUI(SinglePlayerGame game)
        {
            InitializeComponent();

            this.game = game;
            this.PlayerName.Content = this.game.Player.PlayerName;
            this.Category.Content = this.game.Category.CategoryName;

            if (this.game.Word.GameWord.Contains(' '))
            {
                this.WordLength.Content = this.game.Word.GameWord.Length - 1;
            }
            else
            {
                this.WordLength.Content = this.game.Word.GameWord.Length;
            }

            this.wordBuilder = new WordBuilder(this.WordPanel, this.game.Word);
            this.hangman = new Hangman(this.HangmanDrawing);
            this.letterCount = 0;

            wordBuilder.BuildWord(this.game.Word);
        }

        private void NewGameButtonClick(object sender, RoutedEventArgs e)
        {
            PlayAloneSettingsUI playAloneSettingUI = new PlayAloneSettingsUI();
            playAloneSettingUI.PlayerName.Text = this.PlayerName.Content.ToString();
            this.NavigationService.Navigate(playAloneSettingUI);
        }

        private void ButtonAClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('A');
            LetterA.Foreground = Brushes.Black;
            LetterA.IsEnabled = false;
        }

        private void ButtonBClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('B');
            LetterB.Foreground = Brushes.Black;
            LetterB.IsEnabled = false;
        }

        private void ButtonCClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('C');
            LetterC.Foreground = Brushes.Black;
            LetterC.IsEnabled = false;
        }

        private void ButtonDClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('D');
            LetterD.Foreground = Brushes.Black;
            LetterD.IsEnabled = false;
        }

        private void ButtonEClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('E');
            LetterE.Foreground = Brushes.Black;
            LetterE.IsEnabled = false;
        }

        private void ButtonFClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('F');
            LetterF.Foreground = Brushes.Black;
            LetterF.IsEnabled = false;
        }

        private void ButtonGClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('G');
            LetterG.Foreground = Brushes.Black;
            LetterG.IsEnabled = false;
        }

        private void ButtonHClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('H');
            LetterH.Foreground = Brushes.Black;
            LetterH.IsEnabled = false;
        }

        private void ButtonIClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('I');
            LetterI.Foreground = Brushes.Black;
            LetterI.IsEnabled = false;
        }

        private void ButtonJClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('J');
            LetterJ.Foreground = Brushes.Black;
            LetterJ.IsEnabled = false;
        }

        private void ButtonKClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('K');
            LetterK.Foreground = Brushes.Black;
            LetterK.IsEnabled = false;
        }

        private void ButtonLClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('L');
            LetterL.Foreground = Brushes.Black;
            LetterL.IsEnabled = false;
        }

        private void ButtonMClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('M');
            LetterM.Foreground = Brushes.Black;
            LetterM.IsEnabled = false;
        }

        private void ButtonNClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('N');
            LetterN.Foreground = Brushes.Black;
            LetterN.IsEnabled = false;
        }

        private void ButtonOClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('O');
            LetterO.Foreground = Brushes.Black;
            LetterO.IsEnabled = false;
        }

        private void ButtonPClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('P');
            LetterP.Foreground = Brushes.Black;
            LetterP.IsEnabled = false;
        }

        private void ButtonQClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('Q');
            LetterQ.Foreground = Brushes.Black;
            LetterQ.IsEnabled = false;
        }

        private void ButtonRClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('R');
            LetterR.Foreground = Brushes.Black;
            LetterR.IsEnabled = false;
        }

        private void ButtonSClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('S');
            LetterS.Foreground = Brushes.Black;
            LetterS.IsEnabled = false;
        }

        private void ButtonTClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('T');
            LetterT.Foreground = Brushes.Black;
            LetterT.IsEnabled = false;
        }

        private void ButtonUClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('U');
            LetterU.Foreground = Brushes.Black;
            LetterU.IsEnabled = false;
        }

        private void ButtonVClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('V');
            LetterV.Foreground = Brushes.Black;
            LetterV.IsEnabled = false;
        }

        private void ButtonWClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('W');
            LetterW.Foreground = Brushes.Black;
            LetterW.IsEnabled = false;
        }

        private void ButtonXClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('X');
            LetterX.Foreground = Brushes.Black;
            LetterX.IsEnabled = false;
        }

        private void ButtonYClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('Y');
            LetterY.Foreground = Brushes.Black;
            LetterY.IsEnabled = false;
        }

        private void ButtonZClick(object sender, RoutedEventArgs e)
        {
            CheckLetter('Z');
            LetterZ.Foreground = Brushes.Black;
            LetterZ.IsEnabled = false;
        }

        private void CheckLetter(char letter)
        {
            bool exist = this.game.Checker.CheckWordByLatter(letter);

            if (exist)
            {
                this.wordBuilder.ShowLetter(letter);
                bool isLetter = this.wordBuilder.LookForDash();
                if (isLetter)
                {
                    MessageBox.Show("Congratulations! You are a winner!", "Congrats");
                    this.NavigationService.GoBack();
                }
            }
            else
            {
                this.MissedLetters.Content += letter + ", ";
                hangman.DrawHangman((HangmanParts)this.letterCount);
                this.letterCount++;
            }

            if (this.letterCount == 10)
            {  
                MessageBox.Show(String.Format("You lost the game. The word was -> {0}", this.game.Word.GameWord), "Game Over!");
                this.NavigationService.GoBack();
            }
        }

        private void SubmitButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.WordTextBox.Text == "")
            {
                MessageBox.Show("Your word is wrong", "Sorry!");
                hangman.DrawHangman((HangmanParts)this.letterCount);
                this.letterCount++;
                return;
            }

            bool isTheWordCorrect = this.game.Checker.CheckWordByWord(new Word(this.WordTextBox.Text.ToUpper()));

            if (isTheWordCorrect)
            {
                MessageBox.Show("Congratulations! You are a winner!", "Congrats");
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Your word is wrong", "Sorry!");
                this.WordTextBox.Text = "";
                hangman.DrawHangman((HangmanParts)this.letterCount);
                this.letterCount++;
            }
        }
    }
}
