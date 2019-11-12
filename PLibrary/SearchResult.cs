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
        private SqlConnection connection = new SqlConnection();

        public SearchResult(String title, String author, String category, int year, int id)
        {
            InitializeComponent();

            this.title = title;
            this.author = author;
            this.category = category;
            this.year = year;
            this.id = id;
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            try
            {
                connection.ConnectionString =
                    "Data Source=NATE-SURFACE;" +
                    "Initial Catalog=PLibrary;" +
                    "Integrated Security=True";
                connection.Open();

                MessageBox.Show("Db Connection Successful");


            }
            catch (Exception connectionError)
            {
                MessageBox.Show(connectionError.Message);
            }

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
            SqlCommand cmdLoadBook = connection.CreateCommand();

            cmdLoadBook.CommandText = "SELECT Book_ID as ID, Title, Lname as Author, PYear, Section, Copies, Available " +
                "FROM BOOK JOIN AUTHOR ON A_ID = Author_ID JOIN CATEGORY ON C_ID = Category_ID " +
                "WHERE Title = @where";
            String whereClause = " ";

            if (!String.IsNullOrEmpty(title))
            {
                whereClause += "\'" + title + "\'";
            }
            else if(!String.IsNullOrEmpty(author))
            {
                whereClause += "Lname = \'" + author + "\'";
            }
            else if(!String.IsNullOrEmpty(category))
            {
                whereClause += "Cname = \'" + category + "\'";
            }
            else if(year != 0)
            {
                whereClause += "Pyear = " + year;
            }
            else if(id != 0)
            {
                whereClause += "Book_ID = " + id;
            }

            Console.WriteLine(whereClause);

            cmdLoadBook.Parameters.AddWithValue("@where", whereClause);

            SqlDataReader reader = cmdLoadBook.ExecuteReader();

            DataTable tempTable = new DataTable();
            tempTable.Load(reader);

            dataGridSearchResults.DataSource = tempTable;
        }

    }
}
