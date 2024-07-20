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
    /// Interaction logic for AddBorrow.xaml
    /// </summary>
    public partial class AddBorrow : Window
    {
        IStudentRepository studentRepository;
        IBookRepository bookRepository;
        IBorrowBookRepository borrowBookRepository;
        public AddBorrow()
        {
            InitializeComponent();
            borrowDate.SelectedDate = DateTime.Now;
            studentRepository = new StudentRepository();
            bookRepository = new BookRepository();
            borrowBookRepository = new BorrowBookRepository();
        }

        private void btn_AddBorrow(object sender, RoutedEventArgs e)
        {
            try
            {
                //check student
                Student student = studentRepository.GetStudenByID(txtStudentID.Text.Trim());
                //check book
                Book book = bookRepository.GetBookByID(txtBookID.Text.Trim());
                //check return date
                if (returnDate.SelectedDate <= DateTime.Now)
                {
                    throw new Exception("Invalid return date!!");
                }
                if (student == null || book == null)
                {
                    throw new Exception("Please input valid student and book!!");
                }
                else
                {
                    BorrowBook borrowBook = new BorrowBook();
                    borrowBook.StudentId = student.StudentId;
                    borrowBook.BookId = book.BookId;
                    borrowBook.BorrowedDate = borrowDate.SelectedDate;
                    borrowBook.ReturnDate = returnDate.SelectedDate;
                    borrowBookRepository.InsertBorrowBook(borrowBook);
                    book.Amount--;
                    bookRepository.UpdateBook(book);
                    MessageBox.Show("Borrow successful!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Borrow");
            }

        }

        private void btn_Refresh(object sender, RoutedEventArgs e)
        {
            txtBookID.Text = "";
            txtStudentID.Text = "";
            returnDate.Text = "";
        }
    }
}
