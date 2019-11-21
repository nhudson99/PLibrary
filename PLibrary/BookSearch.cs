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
                String.IsNullOrEmpty(comboCategory.Text) &&
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
                Boolean tf;

                if (!String.IsNullOrEmpty(txtBookYear.Text) && !(Int32.TryParse(txtBookYear.Text,out year)))
                {
                    MessageBox.Show("Invalid year");
                    return;
                }
                    
                if (!String.IsNullOrEmpty(txtBookID.Text) && !(Int32.TryParse(txtBookID.Text, out id)))
                {
                    MessageBox.Show("Invalid id");
                    return;
                }


                //if (!String.IsNullOrEmpty(txtBookYear.Text))
                //   year = int.Parse(txtBookYear.Text);
                //   if (!String.IsNullOrEmpty(txtBookID.Text))
                //     id = int.Parse(txtBookID.Text);

                SearchResult result = new SearchResult(txtBookTitle.Text, txtBookAuthor.Text, comboCategory.Text, year, id);
                result.DBConnection2 = DBConnection;
                result.Show();
            }
        }

        private void BookSearch_Load(object sender, EventArgs e)
        {
            SqlCommand cmdLoadCategory = DBConnection.CreateCommand();

            cmdLoadCategory.CommandText = "SELECT * FROM CATEGORY";

            SqlDataReader reader = cmdLoadCategory.ExecuteReader();

            while (reader.Read())
            {
                comboCategory.Items.Add(reader[1].ToString());
            }
            reader.Close();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnSearchBook.Enabled == false)
            {
                btnSearchBook.Enabled = true;
            }
        }
    }
}
