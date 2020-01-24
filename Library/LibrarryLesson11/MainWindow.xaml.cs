
using System.Windows;

namespace LibrarryLesson11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Catalogue Library = new Catalogue();
        public MainWindow()
        {
            InitializeComponent();

            Library.Test();
            
            MessageBox.Show(Library.SearchByTitle("Krzyżacy"));

            MessageBox.Show(Library.SearchById(7));

        }

        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            AddingBook subWindow = new AddingBook();
            subWindow.Show();
        }

        private void add_journal_Click(object sender, RoutedEventArgs e)
        {
            AddingJournal journal = new AddingJournal();
            journal.Show();
        }

        private void search_by_id_Click(object sender, RoutedEventArgs e)
        {
            var title = new SearchTitle();
            title.Show();
        }

        private void search_by_title_Click(object sender, RoutedEventArgs e)
        {

            if (search_keyword_tb.Text == "")
                MessageBox.Show("Nothing to search here. Please enter some keyword into box.");
            else
            {
                MessageBox.Show(Library.SearchByTitle(search_keyword_tb.Text));
            }

        }
    }
}
