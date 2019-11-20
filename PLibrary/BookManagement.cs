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
            txtCopies.Enabled = false;
            txtAvailable.Enabled = false;
        }

        private void EnableControls()
        {
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtYear.Enabled = true;
            txtCategory.Enabled = true;
            txtCopies.Enabled = true;
            txtAvailable.Enabled = true;
        }

        private void ClearControls()
        {
            txtID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtCategory.Clear();
            txtCopies.Clear();
            txtAvailable.Clear();
        }
        private bool CheckControls()
        {
            if (string.IsNullOrEmpty(txtTitle.Text)  ||
               string.IsNullOrEmpty(txtAuthor.Text)  ||
               string.IsNullOrEmpty(txtYear.Text)    ||
               string.IsNullOrEmpty(txtCategory.Text)||
               string.IsNullOrEmpty(txtCopies.Text)  ||
               string.IsNullOrEmpty(txtAvailable.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            SqlCommand cmdLoadControls = DBConnection.CreateCommand();

            cmdLoadControls.CommandText = "SELECT Title, Name , PYear, Cname, Copies, Available " +
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
                txtCopies.Text = reader[4].ToString();
                txtAvailable.Text = reader[5].ToString();
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
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("ID field must be empty");
                }
                else if (CheckControls())
                {
                    MessageBox.Show("All fields except for ID must have a value");
                }
                else
                {
                    
                    SqlCommand cmdGetCID = DBConnection.CreateCommand();

                    cmdGetCID.CommandText = "SELECT Category_ID FROM CATEGORY WHERE Cname = @category";
                    cmdGetCID.Parameters.AddWithValue("@category", txtCategory.Text);

                    SqlDataReader reader = cmdGetCID.ExecuteReader();

                    int cID = 1;

                    if (reader.Read())
                        cID = int.Parse(reader[0].ToString());

                    //Console.WriteLine("************  Category ID '{0}'", cID);

                    //Console.WriteLine("************  reader close ******************");

                    reader.Close();
                    
                    SqlCommand cmdAddBook = DBConnection.CreateCommand();

                    cmdAddBook.CommandText = "INSERT INTO BOOK VALUES (@title,@year,@cID,@copies,@available)";
                    cmdAddBook.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmdAddBook.Parameters.AddWithValue("@year", txtYear.Text);
                    cmdAddBook.Parameters.AddWithValue("@cID", cID);
                    cmdAddBook.Parameters.AddWithValue("@copies", txtCopies.Text);
                    cmdAddBook.Parameters.AddWithValue("@available", txtAvailable.Text);

                    cmdAddBook.ExecuteNonQuery();

                    
                    //Console.WriteLine("************  execute book insert ******************");

                    SqlCommand cmdGetAID = DBConnection.CreateCommand();

                    cmdGetAID.CommandText = "SELECT Author_ID FROM AUTHOR WHERE Name = @author";
                    cmdGetAID.Parameters.AddWithValue("@author", txtAuthor.Text);

                    SqlDataReader reader2 = cmdGetAID.ExecuteReader();
                    
                    int aID = 0;


                    if (reader2.Read())
                    {
                        aID = int.Parse(reader2[0].ToString());

                        //Console.WriteLine("************  reader2 has rows ******************");

                        reader2.Close();
                        //Console.WriteLine("************  reader2 close ******************");

                        //Console.WriteLine("************  Author ID '{0}'", aID);
                    }
                    else
                    {
                        reader2.Close();
                        //Console.WriteLine("************  reader2 close ******************");
                        
                        SqlCommand cmdAddAuthor = DBConnection.CreateCommand();

                        cmdAddAuthor.CommandText = "INSERT INTO AUTHOR VALUES (@author)";
                        cmdAddAuthor.Parameters.AddWithValue("@author", txtAuthor.Text);

                        cmdAddAuthor.ExecuteNonQuery();
                        
                        SqlDataReader reader3 = cmdGetAID.ExecuteReader();
                    
                        if (reader3.Read())
                            aID = int.Parse(reader3[0].ToString());
                            
                        reader3.Close();
                        
                        //Console.WriteLine("************  Author ID '{0}'", aID);
                    }

                    SqlCommand cmdGetBID = DBConnection.CreateCommand();
                    cmdGetBID.CommandText = "SELECT Book_ID FROM BOOK WHERE Title = @title";
                    cmdGetBID.Parameters.AddWithValue("@title", txtTitle.Text);

                    SqlDataReader reader4 = cmdGetBID.ExecuteReader();

                    int bID = 0;
                    if (reader4.Read())
                        bID = int.Parse(reader4[0].ToString());

                    //Console.WriteLine("************  Book ID '{0}'", bID);
                    reader4.Close();

                    SqlCommand cmdAddBookAuthor = DBConnection.CreateCommand();
                    cmdAddBookAuthor.CommandText = "INSERT INTO BOOK_AUTHOR VALUES (@authorID,@bookID)";

                    cmdAddBookAuthor.Parameters.AddWithValue("@authorID", aID);
                    cmdAddBookAuthor.Parameters.AddWithValue("@bookID", bID);

                    cmdAddBookAuthor.ExecuteNonQuery();
                    
                    
                    MessageBox.Show("Book Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

