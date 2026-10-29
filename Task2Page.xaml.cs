using System.Windows;
using System.Windows.Controls;

namespace Student_Variant6.Pages
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            string text = txtInput.Text;

            // Проверка: строка не пустая
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Введите строку.", "Ошибка ввода",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtResult.Clear();
                return;
            }

            // Проверка: в строке есть хотя бы одна круглая скобка
            if (text.IndexOf('(') < 0 && text.IndexOf(')') < 0)
            {
                MessageBox.Show("В строке должны быть круглые скобки.", "Ошибка ввода",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtResult.Clear();
                return;
            }

            txtResult.Text = CheckBrackets(text).ToString();
        }

        // 0  — скобки расставлены правильно;
        // >0 — позиция (с 1) первой лишней закрывающей скобки;
        // -1 — закрывающих скобок не хватает.
        public static int CheckBrackets(string text)
        {
            int balance = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    balance++;
                }
                else if (text[i] == ')')
                {
                    if (balance == 0)
                    {
                        return i + 1;
                    }
                    balance--;
                }
            }

            return balance > 0 ? -1 : 0;
        }
    }
}
