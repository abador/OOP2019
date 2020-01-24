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

namespace Lesson11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private string name = string.Empty;

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyTextBoxWyświetlanie.Text == "Write a name:") return;
            MyButton.Background = Brushes.Red;
            name = MyTextBoxWyświetlanie.Text;
            MyTextBoxPobieranie.Text = $"{this.name}";
        }


        private void MyTextBoxPobieranie_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void MyTextBoxWyświetlanie_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MyTextBoxWyświetlanie.Text = $"Write a name: ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyTextBoxPobieranie.Clear();
        }
    }
}
