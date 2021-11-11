﻿using System;
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

namespace WSR_Tort.Pages
{
    /// <summary>
    /// Логика взаимодействия для DirectorMenu.xaml
    /// </summary>
    public partial class DirectorMenu : Page
    {
        public DirectorMenu()
        {
            InitializeComponent();
        }

        private void ToEquipmentList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EquipmentListing());
        }

        private void ToIngridientList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IngridientListing());
        }
    }
}
