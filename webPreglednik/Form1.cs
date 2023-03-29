using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace webPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("www.google.com");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtSearch.Text);
        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void txtForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void txtHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void addBookmark_Click(object sender, EventArgs e)
        {
            bookmark.Items.Add(webBrowser1.Url.ToString());
        }

        private void bookmark_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(bookmark.SelectedItem.ToString());
        }





        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtTab_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
