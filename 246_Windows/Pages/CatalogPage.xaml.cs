using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _246_Windows.Windows;

namespace _246_Windows.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        ObservableCollection<Book> books = new ObservableCollection<Book>();

        public CatalogPage()
        {
            InitializeComponent();

            books.Add(new Book { Title = "Мастер и Маргарита", Author = "М. Булгаков", Year = 1967 });
            books.Add(new Book { Title = "Три товарища", Author = "Э.М. Ремарк", Year = 1936 });
            books.Add(new Book { Title = "Пикник на обочине", Author = "Стругацкие", Year = 1972 });


            listBooks.ItemsSource = books;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Book b = new Book();
            AddBookWindow w = new AddBookWindow();
            w.DataContext = b;
           
                
            if (w.ShowDialog() == true)
            {
                books.Add(b);
            }
            
            //
            //
        }

        private void listBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listBooks.SelectedItem is Book b)
            {
                DataContext = b;
            }
        }

        private void listBooks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listBooks.SelectedItem is Book b)
            {
                BookDetailsPage p = new BookDetailsPage(b);
                p.DataContext = b;
                NavigationService?.Navigate(p);
            }
        }
    }
}
