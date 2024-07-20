using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Repository;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for StatisticPage.xaml
    /// </summary>
    public partial class StatisticPage : Page
    {
        private readonly LibraryManagementContext myLibrary;
        IBorrowBookRepository borrowBookRepository;
        public StatisticPage()
        {
            myLibrary = new LibraryManagementContext();
            borrowBookRepository = new BorrowBookRepository();
            InitializeComponent();
            lvBorrows.ItemsSource = borrowBookRepository.GetBorrowList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            IQueryable<Book> books = from s in myLibrary.Books select s;
            IQueryable<BookCategory> c = from s in myLibrary.BookCategories select s;
            IQueryable<BorrowBook> borrowingBooks = myLibrary.BorrowBooks
                            .Where(b => b.ReturnDate >= DateTime.Today);
            IQueryable<BorrowBook> expiredBooks = myLibrary.BorrowBooks
                            .Where(b => b.ReturnDate < DateTime.Today);

            countBorrowBooks.Text = borrowingBooks.Count().ToString();
            countExpiredBooks.Text = expiredBooks.Count().ToString();
            countBook.Text = books.ToList().Count.ToString();
            countCategory.Text = c.ToList().Count.ToString();

        }
        private void btnBorrowingClick(object sender, RoutedEventArgs e)
        {
            IQueryable<BorrowBook> books = from s in myLibrary.BorrowBooks.Include(s => s.Student).Include(s => s.Book) select s;

            books = books.Where(s => s.ReturnDate >= DateTime.Today);

            lvBorrows.ItemsSource = books.ToList();
        }

        private void btnExpiredClick(object sender, RoutedEventArgs e)
        {
            IQueryable<BorrowBook> books = from s in myLibrary.BorrowBooks.Include(s => s.Student).Include(s => s.Book) select s;

            books = books.Where(s => s.ReturnDate < DateTime.Today);

            lvBorrows.ItemsSource = books.ToList();
        }
    }
}
