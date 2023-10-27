using StoreHardware.Components;
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
using static StoreHardware.Components.Navigation;

namespace StoreHardware.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizatePage.xaml
    /// </summary>
    public partial class AuthorizatePage : Page
    {
        public AuthorizatePage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.RemoveBackEntry();
            App.IsAdmin = false;
            if (PasswordPb.Password == "admin" && LoginTb.Text == "admin")
            {
                App.IsAdmin = true;
                MessageBox.Show("Вы вошли как администратор!");
            }

            else if (PasswordPb.Password != "Kirill" && LoginTb.Text != "Kirill")
            {
                MessageBox.Show("Вы вошли как юзер");
                Navigation.ClearHistory();
                Navigation.NextPage(new PageComponent
                    ("Авторизация", new AuthorizatePage()));
            }
            Navigation.NextPage(new PageComponent("Список товара", new ServiceListPage()));
        }
    }
}
