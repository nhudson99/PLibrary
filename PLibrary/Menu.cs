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
    public partial class Menu : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(); // Connection to DB

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.ConnectionString =
                    "Data Source=DESKTOP-AT9IVS9;" + // Change to your server name ------------
                    "Initial Catalog=PLibrary;" +
                    "Integrated Security=True";
                sqlConnection.Open();

                MessageBox.Show("Db Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            //this.Close();
            BookSearch frm = new BookSearch();
            frm.DBConnection = sqlConnection;
            frm.Show();
        }

        private void btnProcessBook_Click(object sender, EventArgs e)
        {
            ProcessBooks frm = new ProcessBooks();
            frm.DBConnection = sqlConnection;
            frm.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transactions frm = new Transactions();
            frm.DBConnection = sqlConnection;
            frm.Show();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            BookManagement frm = new BookManagement();
            frm.DBConnection = sqlConnection;
            frm.Show();
        }

       
    }
}
