using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLibrary
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            //this.Close();
            BookSearch bookSearch = new BookSearch();

            bookSearch.Show();
        }

        private void btnProcessBook_Click(object sender, EventArgs e)
        {
            ProcessBooks procBooks = new ProcessBooks();

            procBooks.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transactions trans = new Transactions();

            trans.Show();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            BookManagement bookMan = new BookManagement();

            bookMan.Show();
        }
    }
}
