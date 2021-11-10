using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WSR_Tort.Util
{
    public static class ShowMessage
    {
        public static void ErrorMessageBox(string message)
        {
            MessageBox.Show($"{message}", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void WarningMessageBox(string message)
        {
            MessageBox.Show($"{message}", "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public static void SuccessMessageBox(string message)
        {
            MessageBox.Show($"{message}", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
