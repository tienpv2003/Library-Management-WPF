using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Repository;
using LibaryManagement.Windows;
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
    /// Interaction logic for BorrowBookPage.xaml
    /// </summary>
    public partial class BorrowBookPage : Page
    {
        IBorrowBookRepository borrowBookRepository;
        IBookRepository bookRepository;
        ExtendBorrow extendBorrow;
        AddBorrow addBorrow;
        public BorrowBookPage()
        {
            borrowBookRepository = new BorrowBookRepository();
            InitializeComponent();
            lvBorrows.ItemsSource = borrowBookRepository.GetBorrowList();
            bookRepository = new BookRepository();
        }

        private void btn_SearchClicked(object sender, RoutedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<BorrowBook> books = from s in myLibrary.BorrowBooks.Include(s => s.Student).Include(s => s.Book) select s;

            if (rd_bookid.IsChecked == true)
            {
                books = books.Where(s => s.BookId
                    .Contains(searchText.Text));
            }
            if (rd_studentid.IsChecked == true)
            {
                books = books.Where(s => s.StudentId
                    .Contains(searchText.Text));
            }
            lvBorrows.ItemsSource = books.ToList();
        }

        private void btn_RefreshClick(object sender, RoutedEventArgs e)
        {
            rd_bookid.IsChecked = false;
            rd_studentid.IsChecked = false;
            searchText.Text = "";
            lvBorrows.ItemsSource = borrowBookRepository.GetBorrowList();
        }

        private void btn_BorrowClicked(object sender, RoutedEventArgs e)
        {
            addBorrow = new AddBorrow();
            addBorrow.Show();
        }
        private void btn_ExtendClicked(object sender, RoutedEventArgs e)
        {
            if (lvBorrows.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose first!");
            }
            else
            {
                extendBorrow = new ExtendBorrow();
                extendBorrow.borrowBook = (BorrowBook)lvBorrows.SelectedItem;
                extendBorrow.Show();
            }
        }
        private void btn_ReturnClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lvBorrows.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose first!");
                }
                else
                {
                    borrowBookRepository.DeleteBorrowBook((BorrowBook)lvBorrows.SelectedItem);
                    Book book = bookRepository.GetBookByID(tbBookId.Text.Trim());
                    book.Amount++;
                    bookRepository.UpdateBook(book);
                    MessageBox.Show("Return book successfull!");
                    lvBorrows.ItemsSource = borrowBookRepository.GetBorrowList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Return book");
            }
        }
    }
}
