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
    /// Логика взаимодействия для EditAddEquipment.xaml
    /// </summary>
    public partial class EditAddEquipment : Page
    {

        Equipment equipData;

        public EditAddEquipment(Equipment equipment)
        {
            InitializeComponent();
            equipData = equipment;
            MainGrid.DataContext = equipData;
            OveruserRateCB.ItemsSource = Context._con.OveruseRate.ToList();
            SupplierCB.ItemsSource = Context._con.Supplier.ToList();
            EquipTypeCB.ItemsSource = Context._con.EquipmentType.ToList();
        }

        private void SaveEquipment(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTB.Text) && !string.IsNullOrWhiteSpace(AmountTB.Text) &&
                !string.IsNullOrWhiteSpace(DescTB.Text) && DateTB.SelectedDate != null && EquipTypeCB.SelectedItem != null &&
                OveruserRateCB.SelectedItem != null && SupplierCB.SelectedItem != null && !string.IsNullOrWhiteSpace(AmountTB.Text))
            {
                Context._con.SaveChanges();
                NavigationService.Navigate(new EquipmentListing());
            }
            else
            {
                ShowMessage.WarningMessageBox("Сначала заполните все поля!");
            }
        }

        private void AmountTB_PreviewTextInput(object sender, TextCompositionEventArgs e) // Ввод только цифры
        {
            if(!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
