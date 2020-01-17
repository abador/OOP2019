using System;
using System.Net;
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
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;

namespace Pogoda2
{
    /// <summary>
    /// Logika interakcji dla klasy Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {

        public string nazwaMiasta;
        
        public Welcome()
        {
            
            InitializeComponent();



        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            nazwaMiasta = nazwaM.Text;
           

        }
        private void Resp_btn_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadStringAsync(new Uri("https://api.openweathermap.org/data/2.5/weather?q=" + nazwaMiasta + ",pl&appid=c0a4d6b82fea81cd9272846dbd961cea"));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
            
        }
       

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            
            try
            {
                var obj = JsonConvert.DeserializeObject<Pogoda>(e.Result);
                result.Text = "Temperatura: " + Convert.ToString(String.Format("{0:N1}",obj.main.temp - 273.15) + "*C");
                Wilgotnosc.Text = "Wilgotność: " + Convert.ToString(String.Format("{0}", obj.main.humidity.ToString()) + "%");
                TempOdcz.Text = "Temperatura odczuwalna: " + Convert.ToString(String.Format("{0:N1}", obj.main.feels_like - 273.15) + "*C");
                Cisnienie.Text = "Ciśnienie: " + obj.main.pressure +" hpa";
                Predkosc_wiatru.Text = "Prędkość wiatru: " + obj.wind.speed + "km/h";
                NazwaM.Text = obj.name;
                foreach (var value in obj.weather)
                {
                    //Status chmurki
                    if(value.icon == "01d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/01d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if(value.icon == "02d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/02d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "03d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/03d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "04d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/04d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "09d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/09d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "10d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/10d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "11d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/11d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "13d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/13d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "50d")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/50d.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "01n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/01n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "02n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/02n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "03n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/03n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "04n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/04n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "09n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/09n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "10n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/10n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "11n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/11n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "13n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/13n.png", UriKind.RelativeOrAbsolute));
                    }
                    else if (value.icon == "50n")
                    {
                        kondycja.Source = new BitmapImage(new Uri(@"ikony/50n.png", UriKind.RelativeOrAbsolute));
                    }

                }
               
            }
            catch (System.Exception)
            {
                MessageBox.Show("Wprowadzone złe dane");
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow powrot = new MainWindow();
            powrot.Show();
            this.Close();
        }


    }
}
