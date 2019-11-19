using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PLibrary
{
    public partial class Transactions : Form
    {
        public SqlConnection DBConnection;

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            tDate.Enabled = false;
            dDate.Enabled = false;
            BookTitle.Enabled = false;
            BookAuthor.Enabled = false;
            Returned.Enabled = false;

            LoadAccounts();
        }

        void LoadAccounts()
        {
            SqlCommand cmdLoadAcc = DBConnection.CreateCommand();
            cmdLoadAcc.CommandText = "Select Student_ID FROM  STUDENT";
            SqlDataReader reader = cmdLoadAcc.ExecuteReader();

            while (reader.Read())
            {
                SelectAcc.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        void LoadTransactions(int acc)
        {
            SqlCommand cmdLoadT = DBConnection.CreateCommand();
            cmdLoadT.CommandText = "SELECT Transaction_ID FROM  [TRANSACTION]" +
                " WHERE S_ID = @S_ID";
            cmdLoadT.Parameters.AddWithValue("@S_ID", acc);
            SqlDataReader reader = cmdLoadT.ExecuteReader();

            while (reader.Read())
            {
                SelectTrans.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        void LoadTDates(int t)
        {
            SqlCommand cmdLoadT = DBConnection.CreateCommand();
            cmdLoadT.CommandText = "SELECT Date, DueDate FROM  [TRANSACTION]" +
                " WHERE Transaction_ID = @T_ID";
            cmdLoadT.Parameters.AddWithValue("@T_ID", t);
            SqlDataReader reader = cmdLoadT.ExecuteReader();

            while (reader.Read())
            {
                tDate.Text = reader[0].ToString();
                dDate.Text = reader[1].ToString();
            }
            reader.Close();
        }

        void LoadBooks(int t)
        {
            SqlCommand cmdLoadB = DBConnection.CreateCommand();
            cmdLoadB.CommandText = "SELECT Title, Name, Returned" +
                " FROM CONTAINS_BOOK JOIN BOOK ON CONTAINS_BOOK.B_ID = BOOK.Book_ID" +
                " JOIN BOOK_AUTHOR ON BOOK.Book_ID = BOOK_AUTHOR.B_ID" +
                " JOIN AUTHOR ON Author_ID = A_ID" +
                " WHERE T_ID = @T_ID";
            cmdLoadB.Parameters.AddWithValue("@T_ID", t);
            SqlDataReader reader = cmdLoadB.ExecuteReader();


            while (reader.Read())
            {
                BookTitle.AppendText(reader[0].ToString() + Environment.NewLine);
                BookAuthor.AppendText(reader[1].ToString() + Environment.NewLine);
                Returned.AppendText(reader[2].ToString() + Environment.NewLine);
            }
            reader.Close();
        }


        private void SelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTrans.Items.Clear();
            SelectTrans.ResetText();
            tDate.Text = "";
            dDate.Text = "";

            LoadTransactions(Int32.Parse(SelectAcc.Text));
        }

        private void SelectTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            tDate.Text = "";
            dDate.Text = "";
            BookTitle.Text = "";
            BookAuthor.Text = "";
            Returned.Text = "";
            LoadTDates(Int32.Parse(SelectTrans.Text));
            LoadBooks(Int32.Parse(SelectTrans.Text));
        }


    }
}
