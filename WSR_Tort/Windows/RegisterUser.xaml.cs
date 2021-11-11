using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : Window
    {
        User user;
        public RegisterUser()
        {
            InitializeComponent();
            user = new User();
            RegisterGrid.DataContext = user;
        }

        private void RegisterNewUser(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("(?=.*[A-Z])(?=.*[a-z]).*$"); // Хотя бы одна заглавная и строчная буквы!!
            try
            {
                if(PasswordTB.Text.Length > 5)
                {
                    if (!PasswordTB.Text.Contains(LoginTB.Text))
                    {
                        if (regex.IsMatch(PasswordTB.Text))
                        {
                            user.RoleId = 1;
                            Context._con.User.Add(user);
                            Context._con.SaveChanges();
                            ShowMessage.SuccessMessageBox("Вы успешно зарегестрировались!");
                            Auth auth = new Auth();
                            auth.Show();
                            this.Close();
                        }
                        else
                        {
                            ShowMessage.ErrorMessageBox("Пароль должен содержать минимум одну заглавную и строчную букву!");
                        }
                    }
                    else
                    {
                        ShowMessage.ErrorMessageBox("Пароль не может содержать логин!");
                    }
                    
                }
                else
                {
                    ShowMessage.ErrorMessageBox("Слишком короткий пароль!");
                }            
            }
            catch
            {
                ShowMessage.ErrorMessageBox("Что-то пошло не так :)");
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BackToAuth(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }
    }
}
