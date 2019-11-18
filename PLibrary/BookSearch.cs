using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace PLibrary
{
    public partial class BookSearch : Form
    {
        public SqlConnection DBConnection;

        public BookSearch()
        {
            InitializeComponent();
            btnSearchBook.Enabled = false;
        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchBook.Enabled == false)
            {
                btnSearchBook.Enabled = true;
            }
        }

        private bool CheckControlsEmpty()
        {
            if (String.IsNullOrEmpty(txtBookTitle.Text)    &&
                String.IsNullOrEmpty(txtBookAuthor.Text)   &&
                String.IsNullOrEmpty(txtBookCategory.Text) &&
                String.IsNullOrEmpty(txtBookYear.Text)     &&
                String.IsNullOrEmpty(txtBookID.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtBookAuthor_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchBook.Enabled == false)
            {
                btnSearchBook.Enabled = true;
            }
        }

        private void txtBookCategory_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchBook.Enabled == false)
            {
                btnSearchBook.Enabled = true;
            }
        }

        private void txtBookYear_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchBook.Enabled == false)
            {
                btnSearchBook.Enabled = true;
            }
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (btnSearchBook.Enabled == false)
            {
                btnSearchBook.Enabled = true;
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if(CheckControlsEmpty())
            {
                MessageBox.Show("Please type in at least 1 field");
            }
            else
            {
                int year = 0, id = 0;

                if (!String.IsNullOrEmpty(txtBookYear.Text))
                    year = int.Parse(txtBookYear.Text);
                if (!String.IsNullOrEmpty(txtBookID.Text))
                    id = int.Parse(txtBookID.Text);

                SearchResult result = new SearchResult(txtBookTitle.Text, txtBookAuthor.Text, txtBookCategory.Text, year, id);
                result.DBConnection2 = DBConnection;
                result.Show();
            }
        }
    }
}
