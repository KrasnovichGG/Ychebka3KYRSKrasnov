using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ychebka3KYRSKrasnov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Auth auth = new Auth();
        public static Houses_WiKiEntities house = new Houses_WiKiEntities();
        public static Auth authUser;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_REGISTRATION_Click(object sender, RoutedEventArgs e)
        {
            //BTN_REGISTRATION.ToolTip = "Запишет ваши данные!";
            //if (TxTBName.Text == "" || TxTBPhone.Text == "" || TxTBEmail.Text == "")
            //{
            //    MessageBox.Show("Введите свои данные");
            //}
            //else
            //{
            //    Person client = new Person();
            //    client.Name = TxTBName.Text;
            //    client.Phone = Convert.ToDecimal(TxTBPhone.Text);
            //    client.Email = TxTBEmail.Text;
            //    MainWindow.house.Person.Add(client);
            //    try
            //    {
            //        MainWindow.house.SaveChanges();
            //        MessageBox.Show("Всё норм,ты красавчик!");
            //    Auth user = new Auth();
            //    user.Login = TxTBName.Text;
            //    user.Password = TxTBPhone.Text;
            //    user.ID_Role = 2;
            //    user.ID_Person = client.ID_Person;
            //    MainWindow.house.Auth.Add(user);

            //        MainWindow.house.SaveChanges();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Такой логин уже существует!");
            //    }
            //}
        }

        private void LB_Registration_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            qwer.ScrollToVerticalOffset(3770);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}