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
    /// Логика взаимодействия для ThirdBlock.xaml
    /// </summary>
    public partial class ThirdBlock : Window
    {
        Home Home { get; set; }
        public ThirdBlock(Home home)
        {
            InitializeComponent();
            Home = home;
            var houseroof = (from cust in MainWindow.house.Home_Roof
             join ph in MainWindow.house.Roof_of_the_house on cust.ID_Roof equals ph.ID_Roof
             where cust.ID_Home == Home.ID_Home
             select new { ph.Roof_Color }).ToList();
            cmb1.ItemsSource = houseroof;
        }
    }
}
