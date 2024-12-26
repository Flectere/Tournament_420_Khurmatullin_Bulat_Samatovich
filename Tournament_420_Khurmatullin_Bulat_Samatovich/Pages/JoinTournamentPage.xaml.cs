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
    /// Логика взаимодействия для JoinTournamentPage.xaml
    /// </summary>
    public partial class JoinTournamentPage : Page
    {
        public JoinTournamentPage()
        {
            InitializeComponent();
            ListUsers.ItemsSource = DBConnection.entities.Tournament.ToList();
        }


       

        private void ListUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new EditTournamentPage());
            MessageBox.Show("Вы успешно записались");
            NavigationService.GoBack();
        }
        
    }
}
