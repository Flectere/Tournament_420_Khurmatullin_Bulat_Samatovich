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
    /// Логика взаимодействия для MemberAuthPage.xaml
    /// </summary>
    public partial class MemberAuthPage : Page
    {
        public MemberAuthPage()
        {
            InitializeComponent();
        }

        private void EnterBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = LoginTb.Text.Trim();
                string password = PasswordPb.Password.Trim();
                Member user = DBConnection.entities.Member.FirstOrDefault(o => o.Login == login && o.Password == password);
                NavigationService.Navigate(new OrganizatorMainPage());
            }
            catch
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
