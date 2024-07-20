using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Pages;
using LibaryManagement.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Linq;
using System.Windows;

namespace LibaryManagement.Windows
{
    /// <summary>
    /// Interaction logic for EditRoleWindow.xaml
    /// </summary>
    public partial class EditRoleWindow : Window
    {
        public User user { get; set; }
        IUserRespository userRespository;

        public EditRoleWindow(User user)
        {
            InitializeComponent();
            userRespository = new UserRepository();
            this.user = user;
            txtName.Text = user.UserName;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (AdminRadioButton.IsChecked == true)
            {
                user.RoleId = 1; // admin
            }
            else if (StaffRadioButton.IsChecked == true)
            {
                user.RoleId = 2; // staff
            }
            userRespository.UpdadeUser(user);  
            MessageBox.Show($"User role updated to: {user.RoleId}");
            this.DialogResult = true;
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
