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
    public partial class CheckOut : Form
    {
        public SqlConnection DBConnection2;
        public int books = 0;
        public int trans_ID = -1;
       // private SqlConnection DBConnection2 = new SqlConnection();

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadBooks();
        }

        void LoadAccounts()
        {
            SqlCommand cmdLoadAcc = DBConnection2.CreateCommand();
            cmdLoadAcc.CommandText = "Select Student_ID FROM  STUDENT";
            SqlDataReader reader = cmdLoadAcc.ExecuteReader();

            while (reader.Read())
            {
                SelectAcc.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        void LoadBooks()
        {
            SqlCommand cmdLoadBook = DBConnection2.CreateCommand();
            cmdLoadBook.CommandText = "Select BOOK_ID FROM  BOOK";
            SqlDataReader reader = cmdLoadBook.ExecuteReader();

            while (reader.Read())
            {
                SelectBook.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        int CreateTransaction()
        {
            DateTime Tdate = DateTime.Now;
            DateTime Ddate = Tdate.AddDays(14);

            SqlCommand cmdNewTrans = DBConnection2.CreateCommand();
            cmdNewTrans.CommandText = "INSERT INTO [TRANSACTION] (S_ID, Date, DueDate)";
            cmdNewTrans.CommandText += "OUTPUT INSERTED.Transaction_ID VALUES (@S_ID, @Date, @DueDate)";
            cmdNewTrans.Parameters.AddWithValue("@S_ID", SelectAcc.Text);
            cmdNewTrans.Parameters.AddWithValue("@Date", Tdate);
            cmdNewTrans.Parameters.AddWithValue("@DueDate", Ddate);

             // t is Transaction_ID
            int t = (int)cmdNewTrans.ExecuteScalar(); 

            return t;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            SelectAcc.Enabled = false; //  prevent student change during transaction
        }

        private void Btn_End_Click(object sender, EventArgs e)
        {
            // reset
            SelectAcc.Enabled = true;
            books = 0;
        }

        private void Btn_Process_Click(object sender, EventArgs e)
        {
            if (SelectAcc.Enabled == false) // check that start button has been pressed
            {
                books++;
                if (books == 1)
                {   // check number of book copies available
                    if ()
                    {

                    }
                    // CREATE new TRANSACTION for DB, get the auto-generated id
                    trans_ID = CreateTransaction();
                    MessageBox.Show(trans_ID.ToString());
                }

                // CREATE new CONATINS_BOOK
            }
        }
    }
}
