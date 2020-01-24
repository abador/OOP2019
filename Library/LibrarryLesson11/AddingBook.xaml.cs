using System.Collections.Generic;
using System.Windows;

namespace LibrarryLesson11
{
    /// <summary>
    /// Interaction logic for AddingBook.xaml
    /// </summary>
    public partial class AddingBook : Window
    {
        public AddingBook()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var new_catalogue = new Catalogue();

            if (!(authorfirstname_tb.Text == "" || asurname_tb.Text == "" || btitle_tb.Text == "" ||
                  id_name_tb.Text == "" || bpublisher_tb.Text == "" || yop_tb.Text == "" || nop_tb.Text == ""))
            {
                int.TryParse(yop_tb.Text, out var output);
                int.TryParse(nop_tb.Text, out var output2);
                int.TryParse(id_name_tb.Text, out var output3);

                if (output3 > 0 || output2 > 0 || output > 0)
                {
                    MainWindow.Library.ListOfPositions.Add(new Book(authorfirstname_tb.Text, asurname_tb.Text,
                        btitle_tb.Text,
                        output2, bpublisher_tb.Text, output,
                        output3));
                    MessageBox.Show("Book has been added successfully.");
                }
                else
                    MessageBox.Show("Invalid input with number fields.");
            }
            else
                MessageBox.Show("You should fill all text boxes.");
         
        }

        private void exit_button_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
