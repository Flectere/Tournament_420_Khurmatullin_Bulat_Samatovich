using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для RegistrationMemberPage.xaml
    /// </summary>
    public partial class RegistrationMemberPage : Page
    {
        public RegistrationMemberPage()
        {
            InitializeComponent();
            RoleCb.ItemsSource = DB.DBConnection.entities.Team.ToList();
        }

        private void AddEmployeeBt_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member();
            MemberTeam memberTeam = new MemberTeam();

            member.Name = NameTb.Text;
            member.LastName = LastNameTb.Text;
            member.Patronymic = PatronymicTb.Text;
            member.Nickname = NicknameTb.Text;
            member.Number = NumberTb.Text;
            member.Role = РольTb.Text;
            member.Login = LoginTb.Text;
            member.Password = PasswordTb.Text;
            DBConnection.entities.Member.Add(member);
            DBConnection.entities.SaveChanges();

            if (RoleCb.SelectedItem != null )
            {
                memberTeam.IdMember = DBConnection.entities.Member.ToList().Last().ID;
                memberTeam.Team = RoleCb.SelectedItem as Team;
                DBConnection.entities.MemberTeam.Add(memberTeam);
                DBConnection.entities.SaveChanges();
            }
            MessageBox.Show("Вы зарегестрированы!");



            NavigationService.Navigate(new Pages.MemberAuthPage());
        }
    }
}
