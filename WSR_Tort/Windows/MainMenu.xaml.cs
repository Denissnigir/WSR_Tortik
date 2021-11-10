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
using WSR_Tort.Pages;

namespace WSR_Tort.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu(int num)
        {
            InitializeComponent();
            switch (num)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    MainFrame.Navigate(new DirectorMenu());
                    break;
                default:
                    break;
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }
    }
}
