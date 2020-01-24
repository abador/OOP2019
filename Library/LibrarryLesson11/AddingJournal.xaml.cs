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
    /// Interaction logic for AddingJournal.xaml
    /// </summary>
    public partial class AddingJournal : Window
    {
        public AddingJournal()
        {
            InitializeComponent();
        }

        private void exit_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {

            if (!(jtitle_tb.Text == "" || jpublisher_tb.Text == "" || jyear_of_publish.Text == "" ||
                  jnumber_tb.Text == ""))             {
                int.TryParse(jyear_of_publish.Text, out var output);
                int.TryParse(jnumber_tb.Text, out var output2);
                int.TryParse(id_tb.Text, out var output3);

                if (output2 > 0 || output > 0 || output3 > 0)
                {
                    MainWindow.Library.ListOfPositions.Add(new Journal(jtitle_tb.Text, output3, jpublisher_tb.Text, output, output2));;
                    MessageBox.Show("Journal has been added successfully.");
                }
                else
                    MessageBox.Show("Invalid input with number fields.");
            }
            else
                MessageBox.Show("You should fill all text boxes.");

            if (MainWindow.Library.ListOfPositions == null) //nie wiem czy potrzebne spytaj szarego xD
                MessageBox.Show("List is empty, failed to add new journals.");
        }
    }
}
