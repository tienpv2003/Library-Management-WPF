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
    /// Interaction logic for ReaderManagementPage.xaml
    /// </summary>
    public partial class ReaderManagementPage : Page
    {
        IStudentRepository studentRepository;
        public ReaderManagementPage()
        {
            InitializeComponent();
            studentRepository = new StudentRepository();
            load();
        }
        private void load()
        {
            lvStudents.ItemsSource = studentRepository.GetStudents();
        }

        private void btn_RefreshClicked(object sender, RoutedEventArgs e)
        {
            rd_studentid.IsChecked = false;
            rd_studentname.IsChecked = false;
            sortName.IsChecked = false;
            sortDOB.IsChecked = false;
            sortDes.IsChecked = false;
            sortAcs.IsChecked = false;
            sortDes.IsChecked = false;
            search_id.Text = "";
            search_name.Text = "";
            lvStudents.ItemsSource = studentRepository.GetStudents();
            lvBorrow.ItemsSource = "";

        }

        private void btn_SearchClicked(object sender, RoutedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<Student> studentsIQ = from s in myLibrary.Students select s;
            if (rd_studentid.IsChecked == true)
            {
                if (!String.IsNullOrEmpty(search_id.Text))
                {
                    studentsIQ = studentsIQ.Where(s => s.StudentId
                    .Contains(search_id.Text));
                }
            }
            if (rd_studentname.IsChecked == true)
            {
                if (!String.IsNullOrEmpty(search_name.Text))
                {
                    studentsIQ = studentsIQ.Where(s => s.StudentName
                    .Contains(search_name.Text));
                }
            }
            if (sortName.IsChecked == true)
            {
                if (sortAcs.IsChecked == true)
                {
                    studentsIQ = studentsIQ.OrderBy(s => s.StudentName);
                }
                if (sortDes.IsChecked == true)
                {
                    studentsIQ = studentsIQ.OrderByDescending(s => s.StudentName);
                }
            }
            if (sortDOB.IsChecked == true)
            {
                if (sortAcs.IsChecked == true)
                {
                    studentsIQ = studentsIQ.OrderBy(s => s.Dob);
                }
                if (sortDes.IsChecked == true)
                {
                    studentsIQ = studentsIQ.OrderByDescending(s => s.Dob);
                }
            }
            lvStudents.ItemsSource = studentsIQ.ToList();
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<BorrowBook> borrows = from s in myLibrary.BorrowBooks.Include(s => s.Book) select s;
            borrows = borrows.Where(s => s.StudentId
                    .Contains(tbStudentId.Text));
            lvBorrow.ItemsSource = borrows.ToList();
        }

        private void btn_AddClicked(object sender, RoutedEventArgs e)
        {
            AddReader addReader = new AddReader();
            addReader.Show();
        }

        private void btn_EditClicked(object sender, RoutedEventArgs e)
        {
            if (lvStudents.SelectedItem is Student selectedStudent)
            {
                EditReader editReader = new EditReader(selectedStudent);
                if (editReader.ShowDialog() == true)
                {
                    studentRepository.UpdateStudent(editReader.Student);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to edit.", "Edit Student", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_DeleteClicked(object sender, RoutedEventArgs e)
        {
            if (lvStudents.SelectedItem is Student selectedStudent)
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete {selectedStudent.StudentName}?", "Delete Student", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    studentRepository.DeleteStudent(selectedStudent.StudentId);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Delete Student", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
