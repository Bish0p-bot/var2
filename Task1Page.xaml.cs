using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Student_Variant6.Pages
{
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        // Разрешаем вводить только цифры
        private void txtYear_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.Text, "^[0-9]+$");
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string input = txtYear.Text.Trim();

            // Проверка: целое положительное число
            int year;
            if (!int.TryParse(input, NumberStyles.None, CultureInfo.InvariantCulture, out year) || year <= 0)
            {
                MessageBox.Show("Введите номер года — целое положительное число.",
                    "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtResult.Clear();
                return;
            }

            int century = GetCentury(year);
            txtResult.Text = "Номер столетия: " + century;
        }

        // 1–100 год — 1 столетие, 101–200 — 2 столетие и т.д. (1901 — начало 20 столетия)
        public static int GetCentury(int year)
        {
            return (year - 1) / 100 + 1;
        }
    }
}
