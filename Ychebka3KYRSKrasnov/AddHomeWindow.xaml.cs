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
    /// Логика взаимодействия для AddHomeWindow.xaml
    /// </summary>
    public partial class AddHomeWindow : Window
    {
        public AddHomeWindow()
        {
            InitializeComponent();
            List<Home> homes = MainWindow.house.Home.ToList();
            LstViewChastiDoma.ItemsSource = new List<string>() {"Фасад дома","Брусчатка дома","Крыша дома","Двери дома","Балки дома","Водостоки дома","Цоколь дома","Ступени дома","Окна дома","Терраса дома","Готовые решения","Перила дома","Штукатурка дома"};
            CmbVibor.ItemsSource = homes.Select(x => x.Name);
        }
    }
}
