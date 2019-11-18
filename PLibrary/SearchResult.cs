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
    public partial class SearchResult : Form
    {
        private String title, author, category;
        private int year, id;
        public SqlConnection DBConnection2;

        public SearchResult(String title, String author, String category, int year, int id)
        {
            InitializeComponent();

            this.title = title;
            this.author = author;
            this.category = category;
            this.year = year;
            this.id = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class SearchError : Exception
        {

        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;

            try
            {
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGrid()
        {
            SqlCommand cmdLoadBook = DBConnection2.CreateCommand();

            try
            {
                if (id != 0)
                {
                    cmdLoadBook.CommandText = "SELECT Distinct Book_ID as ID, Title, Name as Author, PYear, Section, Copies, Available " +
                    "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.A_ID = BOOK_AUTHOR.A_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                    "WHERE Book_ID = @bookID";

                    cmdLoadBook.Parameters.AddWithValue("@bookID", id);
                }
                else if (year != 0)
                {
                    cmdLoadBook.CommandText = "SELECT Distinct Book_ID as ID, Title, Name as Author, PYear, Section, Copies, Available " +
                    "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.A_ID = BOOK_AUTHOR.A_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                    "WHERE PYear = @year";

                    cmdLoadBook.Parameters.AddWithValue("@year", year);
                }
                else if (!String.IsNullOrEmpty(title))
                {
                    //MessageBox.Show(title);
                    cmdLoadBook.CommandText = "SELECT Distinct Book_ID as ID, Title, Name as Author, PYear, Section, Copies, Available " +
                    "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.A_ID = BOOK_AUTHOR.A_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                    "WHERE Title = @title";

                    cmdLoadBook.Parameters.AddWithValue("@title", title);
                    //MessageBox.Show(cmdLoadBook.CommandText);
                }
                else if (!String.IsNullOrEmpty(author))
                {
                    cmdLoadBook.CommandText = "SELECT Distinct Book_ID as ID, Title, Name as Author, PYear, Section, Copies, Available " +
                    "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.A_ID = BOOK_AUTHOR.A_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                    "WHERE Name = @author";

                    cmdLoadBook.Parameters.AddWithValue("@author", author);
                }
                else if (!String.IsNullOrEmpty(category))
                {
                    cmdLoadBook.CommandText = "SELECT Distinct Book_ID as ID, Title, Name as Author, PYear, Section, Copies, Available " +
                    "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.A_ID = BOOK_AUTHOR.A_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                    "WHERE Cname = @category";

                    cmdLoadBook.Parameters.AddWithValue("@category", category);
                }


                SqlDataReader reader = cmdLoadBook.ExecuteReader();

                DataTable tempTable = new DataTable();

                if (!reader.HasRows)
                {
                    throw new SearchError();
                }

                tempTable.Load(reader);

                dataGridSearchResults.DataSource = tempTable;
                reader.Close();
            }
            catch(SearchError error)
            {
                MessageBox.Show("No Book Found");
                dataGridSearchResults.ClearSelection();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

    }
}
