using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLibrary
{
    public partial class BookManagement : Form
    {

        public SqlConnection DBConnection;


        public BookManagement()
        {
            InitializeComponent();
        }

        private void DisableControls()
        {
            txtTitle.Enabled = false;
            txtAuthor.Enabled = false;
            txtYear.Enabled = false;
            txtCategory.Enabled = false;
        }

        private void EnableControls()
        {
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtYear.Enabled = true;
            txtCategory.Enabled = true;
        }

        private void ClearControls()
        {
            txtID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtCategory.Clear();
        }
        private bool CheckControls()
        {
            if (string.IsNullOrEmpty(txtTitle.Text) ||
               string.IsNullOrEmpty(txtAuthor.Text) ||
               string.IsNullOrEmpty(txtYear.Text) ||
               string.IsNullOrEmpty(txtCategory.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            SqlCommand cmdLoadControls = DBConnection.CreateCommand();

            cmdLoadControls.CommandText = "SELECT Title, Name , PYear, Cname " +
                    "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.Book_ID = BOOK_AUTHOR.B_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                    "WHERE Book_ID = @bookID";

            cmdLoadControls.Parameters.AddWithValue("@bookID", int.Parse(txtID.Text));

            SqlDataReader reader = cmdLoadControls.ExecuteReader();

            if (reader.Read())
            {
                txtTitle.Text = reader[0].ToString();
                txtAuthor.Text = reader[1].ToString();
                txtYear.Text = reader[2].ToString();
                txtCategory.Text = reader[3].ToString();
            }
            else
            {
                MessageBox.Show("Book NOT found");
            }

            DisableControls();

            reader.Close();

        }

        private void BookManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            EnableControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("ID field must be empty");
            }
            else if (CheckControls())
            {
                MessageBox.Show("All fields except for ID must have a value");
            }
        }
    }


}
