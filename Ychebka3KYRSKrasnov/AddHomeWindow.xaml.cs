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
            CmbVibor.ItemsSource = homes.Select(x => x.Name);
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
                    house_Facade.ID_Facade = 2;
                    MainWindow.house.House_Facade.Add(house_Facade);
                    MainWindow.house.SaveChanges();
                    home.ID_Facade = house_Facade.ID_Facade;
                    Home a = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    a.ID_Facade = house_Facade.ID_Facade;
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Vlad CHMO");
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
