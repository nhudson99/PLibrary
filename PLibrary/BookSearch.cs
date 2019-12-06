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
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            int year = 0, id = 0;

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

            SearchResult result = new SearchResult(txtBookTitle.Text, txtBookAuthor.Text, comboCategory.Text, year, id);
            result.DBConnection2 = DBConnection;
            result.Show();
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

    }
}
