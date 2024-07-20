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
    /// Interaction logic for OTPWindow.xaml
    /// </summary>
    public partial class OTPWindow : Window
    {
        private string expectedOtp;

        public OTPWindow(string otp)
        {
            InitializeComponent();
            expectedOtp = otp;
        }

        private void VerifyOtpButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredOtp = OtpTextBox.Text;

            if (enteredOtp == expectedOtp)
            {
                MessageBoxResult result = MessageBox.Show(
                    "OTP verified successfully. You can now reset your password.",
                    "Success",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );
                if (result == MessageBoxResult.OK)
                {
                    ChangePasswordStaff changePasswordStaff = new ChangePasswordStaff();
                    changePasswordStaff.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
