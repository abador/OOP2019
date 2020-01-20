using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Champions.xaml
    /// </summary>
    public partial class Champions : Window
    {
        public Champions()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                new BitmapImage(new Uri("C:/Users/F/source/repos/Projekt/images/backgrounds/background.png", UriKind.Absolute));
            this.Background = myBrush;
        }
        private void MoveToMenu(object sender, RoutedEventArgs e)
        {
            Menu newWindow = new Menu();
            newWindow.Show();
            this.Close();
        }

        private void AmumuClick(object sender, RoutedEventArgs e)
        {
            Amumu newWindow = new Amumu();
            newWindow.Show();
            this.Close();
        }
        private void AnnieClick(object sender, RoutedEventArgs e)
        {
            Annie newWindow = new Annie();
            newWindow.Show();
            this.Close();
        }
        private void AsheClick(object sender, RoutedEventArgs e)
        {
            Ashe newWindow = new Ashe();
            newWindow.Show();
            this.Close();
        }
        private void BlitzcrankClick(object sender, RoutedEventArgs e)
        {
            Blitzcrank newWindow = new Blitzcrank();
            newWindow.Show();
            this.Close();
        }
        private void CaitlynClick(object sender, RoutedEventArgs e)
        {
            Caitlyn newWindow = new Caitlyn();
            newWindow.Show();
            this.Close();
        }
        private void DianaClick(object sender, RoutedEventArgs e)
        {
            Diana newWindow = new Diana();
            newWindow.Show();
            this.Close();
        }
        private void DrMundoClick(object sender, RoutedEventArgs e)
        {
            DrMundo newWindow = new DrMundo();
            newWindow.Show();
            this.Close();
        }
        private void EzrealClick(object sender, RoutedEventArgs e)
        {
            Ezreal newWindow = new Ezreal();
            newWindow.Show();
            this.Close();
        }
        private void GarenClick(object sender, RoutedEventArgs e)
        {
            Garen newWindow = new Garen();
            newWindow.Show();
            this.Close();
        }
        private void JannaClick(object sender, RoutedEventArgs e)
        {
            Janna newWindow = new Janna();
            newWindow.Show();
            this.Close();
        }
        private void LeonaClick(object sender, RoutedEventArgs e)
        {
            Leona newWindow = new Leona();
            newWindow.Show();
            this.Close();
        }
        private void LuxClick(object sender, RoutedEventArgs e)
        {
            Lux newWindow = new Lux();
            newWindow.Show();
            this.Close();
        }
        private void MalphiteClick(object sender, RoutedEventArgs e)
        {
            Malphite newWindow = new Malphite();
            newWindow.Show();
            this.Close();
        }
        private void MalzaharClick(object sender, RoutedEventArgs e)
        {
            Malzahar newWindow = new Malzahar();
            newWindow.Show();
            this.Close();
        }
        private void MaokaiClick(object sender, RoutedEventArgs e)
        {
            Maokai newWindow = new Maokai();
            newWindow.Show();
            this.Close();
        }
        private void MasterYiClick(object sender, RoutedEventArgs e)
        {
            MasterYi newWindow = new MasterYi();
            newWindow.Show();
            this.Close();
        }
        private void MissFortuneClick(object sender, RoutedEventArgs e)
        {
            MissFortune newWindow = new MissFortune();
            newWindow.Show();
            this.Close();
        }
        private void MorganaClick(object sender, RoutedEventArgs e)
        {
            Morgana newWindow = new Morgana();
            newWindow.Show();
            this.Close();
        }
        private void NasusClick(object sender, RoutedEventArgs e)
        {
            Nasus newWindow = new Nasus();
            newWindow.Show();
            this.Close();
        }
        private void NeekoClick(object sender, RoutedEventArgs e)
        {
            Neeko newWindow = new Neeko();
            newWindow.Show();
            this.Close();
        }
        private void ShyvanaClick(object sender, RoutedEventArgs e)
        {
            Shyvana newWindow = new Shyvana();
            newWindow.Show();
            this.Close();
        }
        private void SkarnerClick(object sender, RoutedEventArgs e)
        {
            Skarner newWindow = new Skarner();
            newWindow.Show();
            this.Close();
        }
        private void SorakaClick(object sender, RoutedEventArgs e)
        {
            Soraka newWindow = new Soraka();
            newWindow.Show();
            this.Close();
        }
        private void TristanaClick(object sender, RoutedEventArgs e)
        {
            Tristana newWindow = new Tristana();
            newWindow.Show();
            this.Close();
        }
        private void VolibearClick(object sender, RoutedEventArgs e)
        {
            Volibear newWindow = new Volibear();
            newWindow.Show();
            this.Close();
        }

    }
}