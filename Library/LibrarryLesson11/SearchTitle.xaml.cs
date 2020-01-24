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

namespace LibrarryLesson11
{
    /// <summary>
    /// Interaction logic for SearchTitle.xaml
    /// </summary>
    public partial class SearchTitle : Window
    {
        public SearchTitle()
        {
            InitializeComponent();
        }

        private void Close_search_CLick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SearchById_Click(object sender, RoutedEventArgs e)
        {

            int.TryParse(id_textbox.Text, out var output);

            MessageBox.Show(output > 0 ? MainWindow.Library.SearchById(output) : "Given ID doesn't exist.");
        }
    }
}
