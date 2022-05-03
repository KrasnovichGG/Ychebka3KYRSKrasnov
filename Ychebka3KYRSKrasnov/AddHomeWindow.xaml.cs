using Microsoft.Win32;
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
    /// Логика взаимодействия для AddHomeWindow.xaml
    /// </summary>
    public partial class AddHomeWindow : Window
    {
        string SELECTiTEM = "";
        List<Home> homes = null;
        public AddHomeWindow()
        {
            InitializeComponent();
            homes = MainWindow.house.Home.ToList();
            LstViewChastiDoma.ItemsSource = new List<string>() {"Фасад дома","Брусчатка дома","Крыша дома","Двери дома","Балки дома","Водостоки дома","Цоколь дома","Ступени дома","Окна дома","Терраса дома","Готовые решения","Перила дома","Штукатурка дома"};
            CmbVibor.ItemsSource = homes.Select(x => x.Name).Distinct();
        }

        private void LstViewChastiDoma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SELECTiTEM = ((sender as ListView).SelectedItem).ToString();


        }

        private void BtnAddToDB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Image_Vibor.Source = new Bitmap(openFileDialog.FileName).BitmapToImageSource();
            }
            else 
            {
                MessageBox.Show("Выберите фото");
                return;
            }
            var home = homes.Find(x => x.Name == CmbVibor.SelectedItem.ToString());
            
            switch(SELECTiTEM)
            {
                case "Фасад дома": 
                    House_Facade house_Facade = new House_Facade();
                    house_Facade.Image_Facade = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    house_Facade.Price_Facade = TxtBpice.Text;
                    house_Facade.Facade_Color = TxtbCoolorobject.Text;
                    MainWindow.house.House_Facade.Add(house_Facade);
                    MainWindow.house.SaveChanges();
                    home.ID_Facade = house_Facade.ID_Facade;
                    Home a = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    a.ID_Facade = house_Facade.ID_Facade;
                    MainWindow.house.Home.Add(a);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Брусчатка дома":
                    Pavers_House pavers_House = new Pavers_House();
                    pavers_House.Image_Pavers = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    pavers_House.Price_Pavers = Convert.ToDecimal(TxtBpice.Text);
                    pavers_House.Pavers_Color = TxtbCoolorobject.Text;
                    MainWindow.house.Pavers_House.Add(pavers_House);
                    MainWindow.house.SaveChanges();
                    home.ID_Pavers = pavers_House.ID_Pavers;
                    Home b = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    b.ID_Pavers = pavers_House.ID_Pavers;
                    MainWindow.house.Home.Add(b);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Крыша дома":
                    Roof_of_the_house roof = new Roof_of_the_house();
                    roof.Image_Roof = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    roof.Price_Roof = Convert.ToDecimal(TxtBpice.Text);
                    roof.Roof_Color = TxtbCoolorobject.Text;
                    MainWindow.house.Roof_of_the_house.Add(roof);
                    MainWindow.house.SaveChanges();
                    home.ID_Roof = roof.ID_Roof;
                    Home v = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    v.ID_Roof = roof.ID_Roof;
                    MainWindow.house.Home.Add(v);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Двери дома":
                    Door_For_House door_ = new Door_For_House();
                    door_.Image_Dooor = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    door_.Price_Door = Convert.ToInt32(TxtBpice.Text);
                    door_.Door_Color = TxtbCoolorobject.Text;
                    MainWindow.house.Door_For_House.Add(door_);
                    MainWindow.house.SaveChanges();
                    home.ID_Door = door_.ID_Door;
                    Home f = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    f.ID_Door = door_.ID_Door;
                    MainWindow.house.Home.Add(f);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Балки дома":
                    Balki_House balki_ = new Balki_House();
                    balki_.Image_Balka = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    balki_.Price_Balka = Convert.ToInt32(TxtBpice.Text);
                    balki_.Color_Balka = TxtbCoolorobject.Text;
                    MainWindow.house.Balki_House.Add(balki_);
                    MainWindow.house.SaveChanges();
                    home.ID_Balka = balki_.ID_Balka;
                    Home d = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    d.ID_Balka = balki_.ID_Balka;
                    MainWindow.house.Home.Add(d);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
            }
        }

        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }
    }

    static class Extensions
    {
        public static BitmapImage BitmapToImageSource(this Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
                return bitmapimage;
            }
        }
    }
}
