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
using WSR_Tort.Model;
using WSR_Tort.Util;

namespace WSR_Tort.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void AuthUser(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(LoginTB.Text) && !string.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                var user = Context._con.User.Where(p => p.Login == LoginTB.Text && p.Password == PasswordTB.Text).FirstOrDefault();
                if (user != null)
                {
                    switch (user.RoleId)
                    {
                        case 1:
                            ShowMessage.WarningMessageBox("Окно заказчика в разработке!");
                            break;
                        case 2:
                            ShowMessage.WarningMessageBox("Окно менеджера по закупкам в разработке!");
                            break;
                        case 3:
                            MainMenu mainMenu = new MainMenu(3);
                            mainMenu.Show();
                            this.Close();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    ShowMessage.ErrorMessageBox("Неправильный логин или пароль!");
                }
            }
            else
            {
                ShowMessage.WarningMessageBox("Не оставляйте поля пустыми!");
            }
        }

        private void ToRegisterUserWindow(object sender, RoutedEventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
