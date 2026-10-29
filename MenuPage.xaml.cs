using System.Windows;
using System.Windows.Controls;

namespace Student_Variant6.Pages
{
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Task1Page());
        }

        private void btnTask2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Task2Page());
        }
    }
}
