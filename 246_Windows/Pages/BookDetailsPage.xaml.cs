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

namespace _246_Windows.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookDetailsPage.xaml
    /// </summary>
    public partial class BookDetailsPage : Page
    {
        Book _b;

        public BookDetailsPage(Book b)
        {
            InitializeComponent();

            AuthorBlock.Text = b.Author;
            TitleBlock.Text = b.Title;
            YearBlock.Text = b.Year.ToString();
            _b = b;

            
        }

        private void Bye_Click(object sender, RoutedEventArgs e)
        {
            _b.Year -= 1;
            MessageBox.Show($"Продано {_b.Title}");
        }
    }
}
