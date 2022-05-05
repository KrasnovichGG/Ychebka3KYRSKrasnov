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

namespace Ychebka3KYRSKrasnov
{
    /// <summary>
    /// Логика взаимодействия для WindowHouses.xaml
    /// </summary>
    public partial class WindowHouses : Window
    {
        public WindowHouses()
        {
            InitializeComponent();
        }

        private void Btn_Add_Home_Click(object sender, RoutedEventArgs e)
        {
            AddHomeWindow addHomeWindow = new AddHomeWindow();
            addHomeWindow.Show();

        }

        private void Image_1Home_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ThirdBlock thirdBlock = new ThirdBlock(MainWindow.house.Home.Where(x=>x.ID_Home == 1).FirstOrDefault());
            thirdBlock.Show();
        }

        private void Image_2Home_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            home2 home2 = new home2(MainWindow.house.Home.Where(x => x.ID_Home == 10).FirstOrDefault());
            home2.Show();
        }

        private void Image_3Home_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
           home3 home3 = new home3(MainWindow.house.Home.Where(x => x.ID_Home == 9).FirstOrDefault());
           home3.Show();
        }
    }
}
