using LibaryManagement.BusinessObject;
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
    /// Interaction logic for ChangePasswordStaff.xaml
    /// </summary>
    public partial class ChangePasswordStaff : Window
    {
        private readonly LibraryManagementContext _libraryContext;
        IUserRespository userRespository;
        public ChangePasswordStaff()
        {
            InitializeComponent();
            _libraryContext = new LibraryManagementContext();
            userRespository = new UserRepository();
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            User currentUser = userRespository.getAccountLogin();
            string newPassword = txtNewPassword.Password;
            string confirmPassword = txtConfirmPassword.Password;

            if (newPassword != confirmPassword)
            {
                txtMessage.Text = "Re-passwords do not match.";
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
            {
                txtMessage.Text = "New password must be at least 6 characters long.";
                return;
            }

            try
            {
                currentUser.UserPassword = newPassword;
                UserObject.Instance.UpdateUser(currentUser);
                txtMessage.Text = "Password changed successfully.";
                txtMessage.Foreground = new SolidColorBrush(Colors.Green);
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                txtMessage.Text = "Error updating password: " + ex.Message;
                txtMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
