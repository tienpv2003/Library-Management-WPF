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
    /// Interaction logic for EditPublisher.xaml
    /// </summary>
    public partial class EditPublisher : Window
    {
        public Publisher Publisher { get; private set; }
        public EditPublisher(Publisher publisher)
        {
            InitializeComponent();
            Publisher = publisher;
            txtPublisherID.Text = publisher.PublisherId;
            txtPublisherName.Text = publisher.PublisherName;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            Publisher.PublisherId = txtPublisherID.Text;
            Publisher.PublisherName = txtPublisherName.Text;
            DialogResult = true;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
