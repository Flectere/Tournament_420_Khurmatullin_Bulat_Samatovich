﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tournament_420_Khurmatullin_Bulat_Samatovich.DB;

namespace Tournament_420_Khurmatullin_Bulat_Samatovich.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWatcherPage.xaml
    /// </summary>
    public partial class RegistrationWatcherPage : Page
    {
        public RegistrationWatcherPage()
        {
            InitializeComponent();
        }

        private void EnterBt_Click(object sender, RoutedEventArgs e)
        {
            Watcher member = new Watcher();

            member.Login = LoginTb.Text;
            DBConnection.entities.Watcher.Add(member);
            DBConnection.entities.SaveChanges();
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
