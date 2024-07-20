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
    /// Interaction logic for EditBook.xaml
    /// </summary>
    public partial class EditBook : Window
    {
        public Book book { get; set; }
        LibraryManagementContext myLibrary;
        IBookRepository bookRepository;
        public EditBook()
        {
            InitializeComponent();
            book = new Book();

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

        private void btn_EditBook(object sender, RoutedEventArgs e)
        {
            if (txtBookID.Text.Length == 0 || txtBookName.Text.Length == 0 || txtBookAmount.Text.Length == 0 || cbAuthor.SelectedIndex == -1 || cbCat.SelectedIndex == -1 || cbPublisher.SelectedIndex == -1)
            {
                MessageBox.Show("Fill all the text box!", "Edit failed!");
            }
            else
            {
                try
                {
                    int bookAmnout = Int32.Parse(txtBookAmount.Text);
                    book.BookName = txtBookName.Text;
                    book.Amount = bookAmnout;
                    book.AuthorId = ((Author)cbAuthor.SelectedItem).AuthorId;
                    book.PublisherId = ((Publisher)cbPublisher.SelectedItem).PublisherId;
                    book.CategoryId = ((BookCategory)cbCat.SelectedItem).CategoryId;

                    bookRepository.UpdateBook(book);

                    MessageBox.Show("Update successful!");
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit failed!");
                }
            }
        }

        private void btn_Refresh(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        void Refresh()
        {
            txtBookName.Text = book.BookName;
            txtBookAmount.Text = book.Amount.ToString();
            List<Author> a = (List<Author>)cbAuthor.ItemsSource;
            List<Publisher> p = (List<Publisher>)cbPublisher.ItemsSource;
            List<BookCategory> c = (List<BookCategory>)cbCat.ItemsSource;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].AuthorId.Equals(book.AuthorId))
                {
                    cbAuthor.SelectedIndex = i;
                }
            }

            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].PublisherId.Equals(book.PublisherId))
                {
                    cbPublisher.SelectedIndex = i;
                }
            }

            for (int i = 0; i < c.Count; i++)
            {
                if (c[i].CategoryId.Equals(book.CategoryId))
                {
                    cbCat.SelectedIndex = i;
                }
            }
        }

        private void editBook_Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtBookID.Text = book.BookId;
            Refresh();
        }
    }
}
