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
    /// Interaction logic for ExtendBorrow.xaml
    /// </summary>
    public partial class ExtendBorrow : Window
    {
        public BorrowBook borrowBook;
        IBorrowBookRepository borrowBookRepository;
        public ExtendBorrow()
        {
            InitializeComponent();
            borrowBook = new BorrowBook();
            borrowBookRepository = new BorrowBookRepository();
        }

        private void btn_ExtendBorrow(object sender, RoutedEventArgs e)
        {
            try
            {
                if (returnDate.SelectedDate <= borrowDate.SelectedDate || returnDate.SelectedDate <= borrowBook.ReturnDate)
                {
                    throw new Exception("Invalid return date");
                }
                else
                {
                    borrowBook.ReturnDate = returnDate.SelectedDate;
                    borrowBookRepository.UpdateBorrowBook(borrowBook);
                    MessageBox.Show("Extend successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Extend borrow");
            }
        }

        private void btn_Refresh(object sender, RoutedEventArgs e)
        {
            returnDate.SelectedDate = borrowBook.ReturnDate;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtBookID.Text = borrowBook.BookId;
            txtStudentID.Text = borrowBook.StudentId;
            borrowDate.SelectedDate = borrowBook.BorrowedDate;
            returnDate.SelectedDate = borrowBook.ReturnDate;
        }
    }
}
