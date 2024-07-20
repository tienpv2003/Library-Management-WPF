using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Repository;
using LibaryManagement.Windows;
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

namespace LibaryManagement.Pages
{
    /// <summary>
    /// Interaction logic for AuthorManagementPage.xaml
    /// </summary>
    public partial class AuthorManagementPage : Page
    {
        private readonly LibraryManagementContext _context;
        IAuthorRepository _authorRepository;
        public Author Author { get; set; }
        public AuthorManagementPage()
        {
            InitializeComponent();
            _context = new LibraryManagementContext();
            _authorRepository = new AuthorRepository();
            Loaded += Window_Load;
        }
        private void load()
        {
            lvAuthors.ItemsSource = _context.Authors.ToList();
        }
        private void Window_Load(object sender, RoutedEventArgs e)
        {
            load();
        }
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {


        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (lvAuthors.SelectedItem is Author selectedAuthor)
            {
                EditAuthor editAuthor = new EditAuthor(selectedAuthor);
                if (editAuthor.ShowDialog() == true)
                {
                    _authorRepository.UpdateAuthor(editAuthor.Author);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select a Author to edit.", "Edit Author", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvAuthors.SelectedItem is Author selectedAuthor)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete {selectedAuthor.AuthorName}?", "Delete Authors", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    _authorRepository.DeleteAuthor(selectedAuthor.AuthorId);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select a Authors to delete.", "Delete Authors", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            tbAuthorId.Text = "";
            tbAuthorName.Text = "";
        }
    }
}
