using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using Ychebka3KYRSKrasnov.db;

namespace Ychebka3KYRSKrasnov
{
    /// <summary>
    /// Логика взаимодействия для home3.xaml
    /// </summary>
    public partial class home3 : Window
    {
        
        Home Home { get; set; }

        public home3(Home home)
        {
            InitializeComponent();
            Home = home;
            VivodIZBd();

        }
        public void VivodIZBd()
        {

            cmb1.ItemsSource = MainWindow.house.Home_Balki.Where(x => x.ID_Home == Home.ID_Home).ToList();
            cmb2.ItemsSource = MainWindow.house.Home_Fasad.Where(g => g.ID_Home == Home.ID_Home).ToList();
            cmb3.ItemsSource = MainWindow.house.Home_Roof.Where(c => c.ID_Home == Home.ID_Home).ToList();
            cmb4.ItemsSource = MainWindow.house.Home_Drain.Where(j => j.ID_Home == Home.ID_Home).ToList();
            cmb5.ItemsSource = MainWindow.house.Home_Railing.Where(k => k.ID_Home == Home.ID_Home).ToList();
            cmb6.ItemsSource = MainWindow.house.Home_Window.Where(k => k.ID_Home == Home.ID_Home).ToList();

        }
        Home_Balki tt1;
        Home_Fasad tt2;
        Home_Roof tt3;
        Home_Drain tt4;
        Home_Railing tt5;
        Home_Window tt6;
        private void cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt1 = cmb1.SelectedItem as Home_Balki;
            img1.Source = new Bitmap(new MemoryStream(tt1.Balki_House.Image_Balka)).BitmapToImageSource();
        }

        private void cmb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt2 = cmb2.SelectedItem as Home_Fasad;
            img2.Source = new Bitmap(new MemoryStream(tt2.House_Facade.Image_Facade)).BitmapToImageSource();
        }
        private void cmb3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt3 = cmb3.SelectedItem as Home_Roof;
            img3.Source = new Bitmap(new MemoryStream(tt3.Roof_of_the_house.Image_Roof)).BitmapToImageSource();
        }
        private void cmb4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt4 = cmb4.SelectedItem as Home_Drain;
            img4.Source = new Bitmap(new MemoryStream(tt4.Drain_For_Home.Image_Drain)).BitmapToImageSource();
        }
        private void cmb5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt5 = cmb5.SelectedItem as Home_Railing;
            img5.Source = new Bitmap(new MemoryStream(tt5.Railing_For_Home.Image_Railing)).BitmapToImageSource();
        }

        private void cmb6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt6 = cmb6.SelectedItem as Home_Window;
            img6.Source = new Bitmap(new MemoryStream(tt6.House_Windows.Image_Window)).BitmapToImageSource();
        }

        private void btnOfotmitHome_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Итоговая цена вашего дома {Home.Price + (Convert.ToDecimal(tt1.Balki_House.Price_Balka)) + (Convert.ToDecimal(tt3.Roof_of_the_house.Price_Roof)) + (Convert.ToDecimal(tt2.House_Facade.Price_Facade)) + (Convert.ToDecimal(tt5.Railing_For_Home.Price_Railing)) + (Convert.ToDecimal(tt4.Drain_For_Home.Price_Drain) + (Convert.ToDecimal(tt6.House_Windows.Price_Roof)))}");
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

