using Safina_422.Components.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace Safina_422.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthoPage.xaml
    /// </summary>
    public partial class AuthoPage : Page
    {
        public AuthoPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Participant> participants = App.db.Participant.ToList();

            foreach (var participant in participants)
            {
                if (participant.Login == LoginTb.Text)
                {
                    if (participant.Password == PasswordBox.Password)
                    {
                        NavigationService.Navigate(new ParticipantsAreaPage(participant));
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль. Попробуйте снова!");
                    }
                }
            }
            IEnumerable<Organizer> organizers = App.db.Organizer.ToList();

            foreach (var organizer in organizers)
            {
                if (organizer.Login == LoginTb.Text)
                {
                    if (organizer.Password == PasswordBox.Password)
                    {
                        NavigationService.Navigate(new OrganizersAreaPage(organizer));
                        break;
                    }
                }
            }

        }
    }
}
