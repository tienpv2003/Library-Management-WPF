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
    /// Interaction logic for ProfileStaffWindow.xaml
    /// </summary>
    public partial class ProfileStaffWindow : Window
    {
        IUserRespository userRespository;
        public ProfileStaffWindow()
        {
            InitializeComponent();
            userRespository = new UserRepository();
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            var currentUser = userRespository.getAccountLogin();
            txtUsername.Text = currentUser.UserName;
            txtRole.Text = currentUser.RoleId == 1 ? "Admin" : "Staff";
        }
        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            StaffWindow staffWindow = new StaffWindow();
            staffWindow.Show();
            this.Close();
        }
    }
}
