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
    /// Start up page with three possibilities
    /// </summary>
    public partial class StartupUI : Page
    {
        public StartupUI()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
        }

        private void PlayButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new KindGameUI());
        }

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void AboutButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AboutUI());
        }
    }
}
