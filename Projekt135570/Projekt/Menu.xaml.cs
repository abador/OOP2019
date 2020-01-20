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
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:/Users/F/source/repos/Projekt/images/backgrounds/background.png", UriKind.Absolute));
            this.Background = myBrush;
        }

        private void MoveToChampions(object sender, RoutedEventArgs e)
        {
            Champions newWindow = new Champions();
            newWindow.Show();
            this.Close();
        }

        private void MoveToInformation(object sender, RoutedEventArgs e)
        {
            Information newWindow = new Information();
            newWindow.Show();
            this.Close();
        }

        private void MoveToCredits(object sender, RoutedEventArgs e)
        {
            Credits newWindow = new Credits();
            newWindow.Show();
            this.Close();
        }
    }
}
