using LibaryManagement.IRepository;
using LibaryManagement.Repository;
using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows;

namespace LibaryManagement.Windows
{
    public partial class ForgotPassword : Window
    {
        private string generatedOtp;
        private string recipientEmail;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void SendOtpButton_Click(object sender, RoutedEventArgs e)
        {

            recipientEmail = EmailTextBox.Text;

            if (!IsValidEmail(recipientEmail))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            generatedOtp = GenerateOtp();
            try
            {
                SendOtpEmail(recipientEmail, generatedOtp);
                MessageBox.Show("OTP has been sent to your email.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

                OTPWindow otpWindow = new OTPWindow(generatedOtp);
                otpWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send OTP: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
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

        private void SendOtpEmail(string email, string otp)
        {
            var fromAddress = new MailAddress("tienpvhe170709@fpt.edu.vn", "Library Management");
            var toAddress = new MailAddress(email);
            const string fromPassword = "wchv cwkp pgqc hghx";
            const string subject = "Your OTP Code";
            string body = $"Your OTP code is: {otp}";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
