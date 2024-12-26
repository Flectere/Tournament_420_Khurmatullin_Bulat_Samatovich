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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tournament_420_Khurmatullin_Bulat_Samatovich.DB;

namespace Tournament_420_Khurmatullin_Bulat_Samatovich.Pages
{
    /// <summary>
    /// Логика взаимодействия для MemberMainPage.xaml
    /// </summary>
    public partial class MemberMainPage : Page
    {
        public MemberMainPage()
        {
            InitializeComponent();
            ListUsers.ItemsSource = DBConnection.entities.Team.ToList();
        }
        Team selectedTeam = new Team();

        private void ListUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedTeam = ListUsers.SelectedItem as Team;
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new JoinTournamentPage());
        }

        private void JoinBt_Click(object sender, RoutedEventArgs e)
        {
            MemberTeam memberTeam = new MemberTeam();
            DBConnection.entities.MemberTeam.Add(memberTeam);
            DBConnection.entities.SaveChanges();
        }
    }
}
