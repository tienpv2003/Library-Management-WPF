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
    /// Interaction logic for EditAuthor.xaml
    /// </summary>
    public partial class EditAuthor : Window
    {
        public Author Author { get; set; }
        public EditAuthor(Author author)
        {
            InitializeComponent();
            Author = author;
            txtAuthorID.Text = author.AuthorId;
            txtAuthorName.Text = author.AuthorName;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            Author.AuthorId = txtAuthorID.Text;
            Author.AuthorName = txtAuthorName.Text;
            DialogResult = true;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
