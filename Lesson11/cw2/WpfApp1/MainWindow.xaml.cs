using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

namespace WpfApp1
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

        private double number;
        private double number1;
        private double final_result;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void InputTwo_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultChar('+');
        }

        private double ConvertNumber(string input)
        {
            double output;
            if (double.TryParse(input, out output))
            {
                return output;
            }
            throw new Exception();
        }

        public void ResultChar(char input)
        {
            try
            {
                number = ConvertNumber(InputOne.Text);
                number1 = ConvertNumber(InputTwo.Text);
                switch (input)
                {
                    case '+':
                        Result.Text = (number + number1).ToString();
                        break;
                    case '-':
                        Result.Text = (number - number1).ToString();
                        break;
                    case '*':
                        Result.Text = (number * number1).ToString();
                        break;
                    case '/':
                        if (number1 == 0)
                        {
                            MessageBox.Show("Don't divide by zero!");
                        }
                        else
                            Result.Text = (number / number1).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }

            InputOne.Text = string.Empty;
            InputTwo.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResultChar('-');
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ResultChar('*');
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ResultChar('/');
        }
    }
}