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
                    TxtBMaterial.Visibility = Visibility.Collapsed;
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
                    TxtBMaterial.Visibility = Visibility.Collapsed;
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
                    TxtBMaterial.Visibility = Visibility.Collapsed;
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
                    TxtBMaterial.Visibility = Visibility.Collapsed;
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
                    TxtBMaterial.Visibility = Visibility.Collapsed;
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
                case "Водостоки дома":
                    TxtBMaterial.Visibility = Visibility.Collapsed;
                    Drain_For_Home drain_For_ = new Drain_For_Home();
                    drain_For_.Image_Drain = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    drain_For_.Price_Drain = Convert.ToInt32(TxtBpice.Text);
                    drain_For_.Drain_Color = TxtbCoolorobject.Text;
                    MainWindow.house.Drain_For_Home.Add(drain_For_);
                    MainWindow.house.SaveChanges();
                    home.ID_Drain = drain_For_.ID_Drain;
                    Home k = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    k.ID_Drain = drain_For_.ID_Drain;
                    MainWindow.house.Home.Add(k);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Цоколь дома":
                    TxtBMaterial.Visibility = Visibility.Collapsed;
                    House_Basement_Cokol_ house_Basement_ = new House_Basement_Cokol_();
                    house_Basement_.Image_Basement = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    house_Basement_.Price_Basement = Convert.ToInt32(TxtBpice.Text);
                    house_Basement_.Basement_Color = TxtbCoolorobject.Text;
                    MainWindow.house.House_Basement_Cokol_.Add(house_Basement_);
                    MainWindow.house.SaveChanges();
                    home.ID_Basement = house_Basement_.ID_Basement;
                    Home l = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    l.ID_Balka = house_Basement_.ID_Basement;
                    MainWindow.house.Home.Add(l);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Ступени дома":
                    TxtBMaterial.Visibility = Visibility.Collapsed;
                    House_Steps steps  = new House_Steps();
                    steps.Image_Steps = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    steps.Price_Steps = Convert.ToInt32(TxtBpice.Text);
                    steps.Steps_Color = TxtbCoolorobject.Text;
                    MainWindow.house.House_Steps.Add(steps);
                    MainWindow.house.SaveChanges();
                    home.ID_Steps = steps.ID_Steps;
                    Home n = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    n.ID_Steps = steps.ID_Steps;
                    MainWindow.house.Home.Add(n);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Окна дома":
                    TxtBMaterial.Visibility = Visibility.Collapsed;
                    House_Windows windows = new House_Windows();
                    windows.Image_Window = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    windows.Price_Roof = Convert.ToInt32(TxtBpice.Text);
                    windows.Window_Color = TxtbCoolorobject.Text;
                    MainWindow.house.House_Windows.Add(windows);
                    MainWindow.house.SaveChanges();
                    home.ID_Window = windows.ID_Window;
                    Home y = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    y.ID_Window = windows.ID_Window;
                    MainWindow.house.Home.Add(y);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Терраса дома":
                    TxtBMaterial.Visibility = Visibility.Collapsed;
                    Terrace_Home terrace_Home = new Terrace_Home();
                    terrace_Home.Image_Terrace = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    terrace_Home.Price_Terrace = Convert.ToInt32(TxtBpice.Text);
                    terrace_Home.Material_Terrace = TxtbCoolorobject.Text;
                    MainWindow.house.Terrace_Home.Add(terrace_Home);
                    MainWindow.house.SaveChanges();
                    home.ID_Terrace = terrace_Home.ID_Terrace;
                    Home o = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    o.ID_Terrace = terrace_Home.ID_Terrace;
                    MainWindow.house.Home.Add(o);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Готовые решения":
                    TxtbCoolorobject.Visibility = Visibility.Collapsed;
                    Turnkey_solution_for_home turnkey_Solution = new Turnkey_solution_for_home();
                    turnkey_Solution.Image = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    turnkey_Solution.Price_Solution = Convert.ToInt32(TxtBpice.Text);
                    MainWindow.house.Turnkey_solution_for_home.Add(turnkey_Solution);
                    MainWindow.house.SaveChanges();
                    home.ID_Solution = turnkey_Solution.ID_Solution;
                    Home m = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    m.ID_Terrace = turnkey_Solution.ID_Solution;
                    MainWindow.house.Home.Add(m);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Перила дома":
                    Railing_For_Home railing = new Railing_For_Home();
                    railing.Image_Railing = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    railing.Price_Railing = Convert.ToInt32(TxtBpice.Text);
                    railing.Color_Railing = TxtbCoolorobject.Text;
                    MainWindow.house.Railing_For_Home.Add(railing);
                    MainWindow.house.SaveChanges();
                    home.ID_Railing = railing.ID_Railing;
                    Home s = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    s.ID_Terrace = railing.ID_Railing;
                    MainWindow.house.Home.Add(s);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                    break;
                case "Штукатурка дома":
                    Plaster_for_the_house the_House = new Plaster_for_the_house();
                    the_House.Image_Plaster = getJPGFromImageControl(Image_Vibor.Source as BitmapImage);
                    the_House.Price_Plaster = Convert.ToInt32(TxtBpice.Text);
                    the_House.Color_Plaster = TxtbCoolorobject.Text;
                    MainWindow.house.Plaster_for_the_house.Add(the_House);
                    MainWindow.house.SaveChanges();
                    home.ID_Plaster = the_House.ID_Plaster;
                    Home t = MainWindow.house.Home.Where(x => x.ID_Home == home.ID_Home).FirstOrDefault();
                    t.ID_Plaster = the_House.ID_Plaster;
                    MainWindow.house.Home.Add(t);
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
