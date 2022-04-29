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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void Btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = MainWindow.house.Auth.FirstOrDefault(x => x.Login == txtboxlogin.Text.Trim());
                if (user != null)
                {
                    MessageBox.Show("Такой логин уже существует!");
                }
                else
                {
                    Person PER = new Person()
                    {
                        Name = txtboxname.Text,
                        Phone = Convert.ToInt32(txtboxphone.Text),
                        Email = txtboxemail.Text
                    };
                    MainWindow.house.Person.Add(PER);
                    MainWindow.house.SaveChanges();
                    Auth person = new Auth()
                    {
                        Login = txtboxlogin.Text.Trim(),
                        ID_Person = PER.ID_Person,
                        Password = PasBoxReg.Password.Trim(),
                        ID_Role = 2
                    };
                    MainWindow.house.Auth.Add(person);
                    MainWindow.house.SaveChanges();
                    MessageBox.Show("Успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        
    }
}
