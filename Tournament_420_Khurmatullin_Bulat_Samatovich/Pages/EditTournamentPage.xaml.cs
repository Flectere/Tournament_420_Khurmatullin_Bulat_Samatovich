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

namespace Tournament_420_Khurmatullin_Bulat_Samatovich.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditTournamentPage.xaml
    /// </summary>
    public partial class EditTournamentPage : Page
    {
        public EditTournamentPage()
        {
            InitializeComponent();
        }

        private void AddEmployeeBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrganizatorMainPage());
        }
    }
}
