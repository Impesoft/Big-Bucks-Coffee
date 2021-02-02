using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Big_Bucks_Coffee
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Page
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenClick(object sender, MouseButtonEventArgs e)
        {
            StartPage myStartPage = new StartPage();
            NavigationService.Navigate(myStartPage);
        }
    }
}