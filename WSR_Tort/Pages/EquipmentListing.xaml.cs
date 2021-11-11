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
using WSR_Tort.Model;
using WSR_Tort.Util;

namespace WSR_Tort.Pages
{
    /// <summary>
    /// Логика взаимодействия для EquipmentListing.xaml
    /// </summary>
    public partial class EquipmentListing : Page
    {
        public EquipmentListing()
        {
            InitializeComponent();
            EquipList.ItemsSource = Context._con.Equipment.ToList();
        }

        private void EditEquipment(object sender, RoutedEventArgs e)
        {
            if(EquipList.SelectedItem != null)
            {
                var equip = (Equipment)EquipList.SelectedItem;
                NavigationService.Navigate(new EditAddEquipment(equip));
            }
            else
            {
                ShowMessage.WarningMessageBox("Сначала кликните по инструменту!");
            }
        }
    }
}
