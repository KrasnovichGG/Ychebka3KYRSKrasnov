﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        public static Houses_WiKiEntities1 house = new Houses_WiKiEntities1();
        public static Auth authUser;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_OTZIV_Click(object sender, RoutedEventArgs e)
        {
           SmtpClient smtpClient = new SmtpClient();
           smtpClient.Credentials = new NetworkCredential("Sasha-kr90@bk.ru", "Tge2MzEYdDfZ8CPmRQ3B");
            smtpClient.Host = ("smtp.mail.ru");
            smtpClient.Port = 587;
           smtpClient.EnableSsl = true;
           MailMessage mailMessage = new MailMessage();
           mailMessage.From = new MailAddress("Sasha-kr90@bk.ru");
            mailMessage.To.Add(new MailAddress(TxTBEmail.Text));
            mailMessage.Subject = "Тема сообщения: " + TxTBsybject.Text;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "Имя: " + TxTBName.Text + "<br>" + "Телефон: " + TxTBPhone.Text + "<br>" + "Почта:" + TxTBEmail.Text + "<br>" + "Текст сообщения: "  + txtboxotziv.Text;
            smtpClient.Send(mailMessage);
            
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