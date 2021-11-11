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

namespace WSR_Tort.Pages
{
    /// <summary>
    /// Логика взаимодействия для IngridientListing.xaml
    /// </summary>
    public partial class IngridientListing : Page
    {
        public IngridientListing()
        {
            InitializeComponent();
            IngridientList.ItemsSource = Context._con.Ingridient.ToList();
        }
    }
}
