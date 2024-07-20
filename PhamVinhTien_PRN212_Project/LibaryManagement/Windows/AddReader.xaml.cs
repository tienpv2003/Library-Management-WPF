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
    /// Interaction logic for AddReader.xaml
    /// </summary>
    public partial class AddReader : Window
    {
        private readonly LibraryManagementContext _context;
        IStudentRepository studentRepository;
        public AddReader()
        {
            InitializeComponent();
            _context = new LibraryManagementContext();
            studentRepository = new StudentRepository();
        }
        private void btn_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) || dbDob.SelectedDate == null ||
                    string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    throw new Exception("All fields are required!");
                }
                Student newStudent = new Student
                {
                    StudentId = txtStudentID.Text,
                    StudentName = txtStudentName.Text,
                    Phone = txtPhone.Text,
                    Dob = dbDob.SelectedDate,
                    Address = txtAddress.Text
                };

                var existingStudent = studentRepository.GetStudenByID(txtStudentID.Text);
                if (existingStudent != null)
                {
                    throw new Exception("StudentID already exists!");
                }

                studentRepository.AddStudent(newStudent);
                MessageBox.Show("Add Reader successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reader");
            }
        }

        private void btn_Refresh(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
        void Refresh()
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtPhone.Text = "";
            dbDob.SelectedDate = null;
            txtAddress.Text = "";
        }
        private void btn_Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
