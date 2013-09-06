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

namespace HangmanGame.Hangman_UI_Controls
{
    /// <summary>
    /// Here player should chooses what kind of game wants to play
    /// </summary>
    public partial class KindGameUI : Page
    {
        public KindGameUI()
        {
            InitializeComponent();
        }

        private void PlayAloneButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PlayAloneSettingsUI());
        }

        private void PlayWithFriendButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PlayWithFriendSettingsUI());
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartupUI());
        }
    }
}
