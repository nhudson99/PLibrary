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
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            SqlCommand cmdLoadControls = connection.CreateCommand();

            cmdLoadControls.CommandText = "SELECT Book_ID as ID, Title, Name as Author, PYear, Cname, Copies " +
                    "FROM BOOK JOIN BOOK_AUTHOR ON BOOK.A_ID = BOOK_AUTHOR.A_ID JOIN AUTHOR ON Author_ID = BOOK_AUTHOR.A_ID JOIN CATEGORY ON C_ID = Category_ID " +
                    "WHERE Book_ID = @bookID";

            cmdLoadControls.Parameters.AddWithValue("@bookID", int.Parse(txtID.Text));

            SqlDataReader reader = cmdLoadControls.ExecuteReader();


        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            try
            {
                connection.ConnectionString =
                    "Data Source=NATE-SURFACE;" +
                    "Initial Catalog=PLibrary;" +
                    "Integrated Security=True";
                connection.Open();

                //MessageBox.Show("Db Connection Successful");


            }
            catch (Exception connectionError)
            {
                MessageBox.Show(connectionError.Message);
            }
        }
    }
}
