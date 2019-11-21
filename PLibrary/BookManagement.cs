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

        private class CustomException : Exception
        {
            public string ExceptionMessage;

            public CustomException(string Input)
            {
                ExceptionMessage = Input;
            }
        }

        public BookManagement()
        {
            InitializeComponent();
        }

        private void DisableControls()
        {
            txtTitle.Enabled = false;
            txtAuthor.Enabled = false;
            txtYear.Enabled = false;
            comboCategory.Enabled = false;
            txtCopies.Enabled = false;
            txtAvailable.Enabled = false;
        }

        private void EnableControls()
        {
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtYear.Enabled = true;
            comboCategory.Enabled = true;
            txtCopies.Enabled = true;
            txtAvailable.Enabled = true;
        }

        private void ClearControls()
        {
            txtID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            comboCategory.ResetText();
            txtCopies.Clear();
            txtAvailable.Clear();
        }
        private bool CheckControls()
        {
            if (string.IsNullOrEmpty(txtTitle.Text)  ||
               string.IsNullOrEmpty(txtAuthor.Text)  ||
               string.IsNullOrEmpty(txtYear.Text)    ||
               string.IsNullOrEmpty(comboCategory.Text)||
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
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    throw new CustomException("Need ID Value");
                }

                SqlCommand cmdLoadControls = DBConnection.CreateCommand();

                cmdLoadControls.CommandText = "SELECT Title, Name , PYear, Cname, Copies, Available " +
                        "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.Book_ID = BOOK_AUTHOR.B_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                        "WHERE Book_ID = @bookID";

                cmdLoadControls.Parameters.AddWithValue("@bookID", int.Parse(txtID.Text));

                SqlDataReader reader = cmdLoadControls.ExecuteReader();

                if (reader.Read())
                {
                    txtTitle.Text = reader[0].ToString().Trim();
                    txtAuthor.Text = reader[1].ToString().Trim();
                    txtYear.Text = reader[2].ToString().Trim();
                    comboCategory.Text = reader[3].ToString().Trim();
                    txtCopies.Text = reader[4].ToString().Trim();
                    txtAvailable.Text = reader[5].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Book NOT found");
                }

                DisableControls();

                reader.Close();
            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BookManagement_Load(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            EnableControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int year = 0, numC = 0, numA = 0;
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
                else if (txtCopies.Text != txtAvailable.Text)
                {
                    MessageBox.Show("# of copies and available must be the same");
                }
                else if (!(Int32.TryParse(txtYear.Text, out year)))
                {
                    MessageBox.Show("Invalid year value");
                }
                else if (!(Int32.TryParse(txtCopies.Text, out numC)))
                {
                    MessageBox.Show("Invalid copies value");
                }
                else if (!(Int32.TryParse(txtAvailable.Text, out numA)))
                {
                    MessageBox.Show("Invalid available value");
                }
                else
                {
                    
                    SqlCommand cmdGetCID = DBConnection.CreateCommand();

                    cmdGetCID.CommandText = "SELECT Category_ID FROM CATEGORY WHERE Cname = @category";
                    cmdGetCID.Parameters.AddWithValue("@category", comboCategory.Text);

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
                    cmdAddBook.Parameters.AddWithValue("@year", year);
                    cmdAddBook.Parameters.AddWithValue("@cID", cID);
                    cmdAddBook.Parameters.AddWithValue("@copies", numC);
                    cmdAddBook.Parameters.AddWithValue("@available", numA);

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
                    
                    
                    MessageBox.Show("Book Added, ID is " + bID.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompleteEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                return;
            }


            if (Int32.Parse(txtAvailable.Text) > Int32.Parse(txtCopies.Text)) 
            {
                MessageBox.Show("# availabe can't be greater then " +
                    "3 of copies");
                return;
            }
            SqlCommand cmdEditBook = DBConnection.CreateCommand();
            cmdEditBook.CommandText = "UPDATE BOOK SET Title = @title, PYear = @year, " +
                                      "C_ID = (SELECT Category_ID FROM CATEGORY WHERE Cname = @category) ,Copies = @copies, Available = @available WHERE Book_ID = @bID";
            cmdEditBook.Parameters.AddWithValue("@title", txtTitle.Text);
            cmdEditBook.Parameters.AddWithValue("@year", txtYear.Text);
            cmdEditBook.Parameters.AddWithValue("@category", comboCategory.Text);
            cmdEditBook.Parameters.AddWithValue("@copies", txtCopies.Text);
            cmdEditBook.Parameters.AddWithValue("@available", txtAvailable.Text);
            cmdEditBook.Parameters.AddWithValue("@bID", txtID.Text);


            cmdEditBook.ExecuteNonQuery();

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

            SqlCommand cmdUpdateBookAuthor = DBConnection.CreateCommand();

            cmdUpdateBookAuthor.CommandText = "UPDATE BOOK_AUTHOR SET A_ID = @aID WHERE B_ID = @bID";

            cmdUpdateBookAuthor.Parameters.AddWithValue("@aID", aID);
            cmdUpdateBookAuthor.Parameters.AddWithValue("@bID", int.Parse(txtID.Text));

            cmdUpdateBookAuthor.ExecuteNonQuery();

            MessageBox.Show("1 Book Updated");

            btnCompleteEdit.Hide();
            btnEdit.Show();

            txtID.Enabled = true;

            DisableControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Hide();
            btnCompleteEdit.Show();

            txtID.Enabled = false;

            EnableControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckControls())
                    throw new CustomException("Need to populate fields");

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand cmdDeletBookAuthor = DBConnection.CreateCommand();
                    cmdDeletBookAuthor.CommandText = "DELETE FROM BOOK_AUTHOR WHERE B_ID = @bID";
                    cmdDeletBookAuthor.Parameters.AddWithValue("@bID", txtID.Text);

                    cmdDeletBookAuthor.ExecuteNonQuery();

                    SqlCommand cmdDeleteBook = DBConnection.CreateCommand();
                    cmdDeleteBook.CommandText = "DELETE FROM BOOK WHERE Book_id = @bID";
                    cmdDeleteBook.Parameters.AddWithValue("@bID", txtID.Text);

                    cmdDeleteBook.ExecuteNonQuery();


                    MessageBox.Show("1 book deleted");
                    ClearControls();
                }
                
            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.ExceptionMessage);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

