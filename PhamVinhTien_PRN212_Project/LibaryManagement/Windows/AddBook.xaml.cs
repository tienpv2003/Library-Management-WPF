using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Repository;
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
using System.Windows.Shapes;

namespace LibaryManagement.Windows
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        LibraryManagementContext myLibrary;
        IBookRepository bookRepository;
        public AddBook()
        {
            InitializeComponent();
            myLibrary = new LibraryManagementContext();
            bookRepository = new BookRepository();

            IQueryable<BookCategory> categories = from s in myLibrary.BookCategories select s;
            IQueryable<Author> authors = from a in myLibrary.Authors select a;
            IQueryable<Publisher> publishers = from p in myLibrary.Publishers select p;

            //cb author
            cbAuthor.ItemsSource = authors.ToList();
            cbAuthor.DisplayMemberPath = "AuthorName";
            cbAuthor.SelectedValuePath = "AuthorID";
            //cb category
            cbCat.ItemsSource = categories.ToList();
            cbCat.DisplayMemberPath = "CategoryName";
            cbCat.SelectedValuePath = "CategoryId";
            //cb publisher
            cbPublisher.ItemsSource = publishers.ToList();
            cbPublisher.DisplayMemberPath = "PublisherName";
            cbPublisher.SelectedValuePath = "PublisherID";
        }

        private void btn_AddBook(object sender, RoutedEventArgs e)
        {
            if (txtBookID.Text.Length == 0 || txtBookName.Text.Length == 0 || txtBookAmount.Text.Length == 0 || cbAuthor.SelectedIndex == -1 || cbCat.SelectedIndex == -1 || cbPublisher.SelectedIndex == -1)
            {
                MessageBox.Show("Fill all the text box!", "Add failed!");
            }
            else
            {
                try
                {
                    int bookAmnout = Int32.Parse(txtBookAmount.Text);
                    Book book = new Book();
                    book.BookId = txtBookID.Text;
                    book.BookName = txtBookName.Text;
                    book.Amount = bookAmnout;
                    book.AuthorId = ((Author)cbAuthor.SelectedItem).AuthorId;
                    book.PublisherId = ((Publisher)cbPublisher.SelectedItem).PublisherId;
                    book.CategoryId = ((BookCategory)cbCat.SelectedItem).CategoryId;

                    bookRepository.InsertBook(book);

                    MessageBox.Show("Insert successful!");
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add failed!");
                }
            }
        }

        private void btn_Refresh(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        void Refresh()
        {
            txtBookID.Text = "";
            txtBookName.Text = "";
            txtBookAmount.Text = "";
            cbAuthor.SelectedIndex = -1;
            cbPublisher.SelectedIndex = -1;
            cbCat.SelectedIndex = -1;
        }

        private void btn_Cancel(object sender, RoutedEventArgs e)
        {
            AddBook addBook = new AddBook();
            this.Close();
        }
    }
}
