using LibaryManagement.IRepository;
using LibaryManagement.Models;
using LibaryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for RegisterStaffWindow.xaml
    /// </summary>
    public partial class RegisterStaffWindow : Window
    {
        IUserRespository userRespository;
        public RegisterStaffWindow()
        {
            InitializeComponent();
            userRespository = new UserRepository();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Password) ||
                    string.IsNullOrWhiteSpace(txtRePass.Password))
                {
                    throw new Exception("Not all space or empty");
                }

                if (IsValidEmail(txtUser.Text))
                {
                    MessageBox.Show("Invalid email address. Please enter a valid email.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!txtPass.Password.Equals(txtRePass.Password))
                {
                    throw new Exception("Re-Password not macth");
                }
                User user = new User();
                user.UserName = txtUser.Text;
                user.UserPassword = txtPass.Password;
                
                user.RoleId = 3;
                var existingUser = userRespository.getUserByUserName(txtUser.Text);
                if (existingUser != null)
                {
                    throw new Exception("Staff already exists!");
                }
                userRespository.AddUser(user);
                MessageBox.Show("Register Successful, Waiting for Admin accept");
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add User");
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private static bool IsValidEmail(string mail)
        {
            try
            {
                var kitMailAddress = new MimeKit.MailboxAddress(null, mail);
                return true;
            }
            catch
            { return false; }
        }
    }
}
