using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _246_Windows.Pages;


namespace _246_Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainPage mainPage = new MainPage();
        CatalogPage catalogPage = new CatalogPage();



        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(mainPage);

        }

        private void ShowMain_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(mainPage);
        }

        private void ShowCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(catalogPage);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if(MainFrame.CanGoForward)
                MainFrame.GoForward();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
                MainFrame.GoBack();
        }
    }
}