using LibaryManagement.Models;
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
    /// Interaction logic for EditReader.xaml
    /// </summary>
    public partial class EditReader : Window
    {
        public Student Student { get; set; }

        public EditReader(Student student)
        {
            InitializeComponent();
            Student = student;
            txtStudentID.Text = student.StudentId;
            txtStudentName.Text = student.StudentName;
            txtPhone.Text = student.Phone;
            dpDob.SelectedDate = student.Dob;
            txtAddress.Text = student.Address;
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            Student.StudentName = txtStudentName.Text;
            Student.Phone = txtPhone.Text;
            Student.Dob = dpDob.SelectedDate.Value;
            Student.Address = txtAddress.Text;
            DialogResult = true;
        }

        private void btn_Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
