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

namespace Lekcja12b
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Kalkulator";
        }
        int działanie;

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // ... lista
            List<string> data = new List<string>() { "Dodawanie", "Odejmowanie", "Mnożenie", "Dzielenie" };

            // ... ustawienie referencji
            var comboBox = sender as ComboBox;

            // ... ustawienie zródla
            comboBox.ItemsSource = data;

            // ... czy cos domyslnie ma byc wybrane
            comboBox.SelectedIndex = 0;
        }
        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... dostep do combo.
            var comboBox = sender as ComboBox;

            działanie = comboBox.SelectedIndex;
        }

        private void Licz_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                
                switch (działanie)
                {
                    case 0:
                        MessageBox.Show(Convert.ToString(Convert.ToDouble(pierwsza.Text)+Convert.ToDouble(druga.Text)));
                        break;
                    case 1:
                        MessageBox.Show(Convert.ToString(Convert.ToDouble(pierwsza.Text) - Convert.ToDouble(druga.Text)));
                        break;
                    case 2:
                        MessageBox.Show(Convert.ToString(Convert.ToDouble(pierwsza.Text) * Convert.ToDouble(druga.Text)));
                        break;
                    case 3:
                        MessageBox.Show(Convert.ToString(Convert.ToDouble(pierwsza.Text) / Convert.ToDouble(druga.Text)));
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }
    }
}
