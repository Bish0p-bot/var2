using System.Windows;

namespace Student_Variant6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new Pages.MenuPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrmMain.CanGoBack)
            {
                FrmMain.GoBack();
            }
        }

        private void FrmMain_ContentRendered(object sender, System.EventArgs e)
        {
            // Кнопка «Назад» видна только если есть куда возвращаться
            btnBack.Visibility = FrmMain.CanGoBack ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
