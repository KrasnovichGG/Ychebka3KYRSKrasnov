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

namespace Ychebka3KYRSKrasnov
{
    /// <summary>
    /// Логика взаимодействия для home2.xaml
    /// </summary>
    public partial class home2 : Window
    {
        Home Home { get; set; }

        public home2(Home home)
        {
            InitializeComponent();
            Home = home;
            VivodIZBd();

        }
        public void VivodIZBd()
        {

            cmb1.ItemsSource = MainWindow.house.Home_Door.Where(x => x.ID_Home == Home.ID_Home).ToList();
            cmb2.ItemsSource = MainWindow.house.Home_Solution.Where(g => g.ID_Home == Home.ID_Home).ToList();
            cmb3.ItemsSource = MainWindow.house.Home_Cokol.Where(c => c.ID_Home == Home.ID_Home).ToList();
            cmb4.ItemsSource = MainWindow.house.Home_Plaster.Where(j => j.ID_Home == Home.ID_Home).ToList();
            cmb5.ItemsSource = MainWindow.house.Home_Steps.Where(k => k.ID_Home == Home.ID_Home).ToList();
      
        }
        Home_Door tt1;
        Home_Cokol tt3;
        Home_Solution tt2;
        Home_Plaster tt4;
        Home_Steps tt5;
        
        private void cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt1 = cmb1.SelectedItem as Home_Door;
            img1.Source = new Bitmap(new MemoryStream(tt1.Door_For_House.Image_Dooor)).BitmapToImageSource();
        }

        private void cmb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt2 = cmb2.SelectedItem as Home_Solution;
            img2.Source = new Bitmap(new MemoryStream(tt2.Turnkey_solution_for_home.Image)).BitmapToImageSource();
        }
        private void cmb3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt3 = cmb3.SelectedItem as Home_Cokol;
            img3.Source = new Bitmap(new MemoryStream(tt3.House_Basement_Cokol_.Image_Basement)).BitmapToImageSource();
        }

        private void cmb4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt4 = cmb4.SelectedItem as Home_Plaster;
            img4.Source = new Bitmap(new MemoryStream(tt4.Plaster_for_the_house.Image_Plaster)).BitmapToImageSource();
        }

        private void cmb5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tt5 = cmb5.SelectedItem as Home_Steps;
            img5.Source = new Bitmap(new MemoryStream(tt5.House_Steps.Image_Steps)).BitmapToImageSource();
        }

        //private void cmb6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    tt6 = cmb6.SelectedItem as Home_Drain;
        //    img6.Source = new Bitmap(new MemoryStream(tt6.Drain_For_Home.Image_Drain)).BitmapToImageSource();
        //}s

        private void btnOfotmitHome_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Итоговая цена вашего дома {Home.Price + (Convert.ToDecimal(tt1.Door_For_House.Price_Door)) + (Convert.ToDecimal(tt3.House_Basement_Cokol_.Price_Basement)) + (Convert.ToDecimal(tt2.Turnkey_solution_for_home.Price_Solution)) + (Convert.ToDecimal(tt5.House_Steps.Price_Steps)) + (Convert.ToDecimal(tt4.Plaster_for_the_house.Price_Plaster))}");
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

