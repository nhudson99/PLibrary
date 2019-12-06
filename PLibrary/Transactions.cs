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
            SelectMax.Value = DateTime.Now;
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            BookTitle.Enabled = false;
            BookAuthor.Enabled = false;
            Returned.Enabled = false;
            Account.Enabled = false;
            Transaction.Enabled = false;
            tDate.Enabled = false;
            dDate.Enabled = false;

            LoadAccounts();
            LoadBooks();
        }

        void LoadAccounts()
        {
            SqlCommand cmdLoadAcc = DBConnection.CreateCommand();
            cmdLoadAcc.CommandText = "Select Student_ID, Fname FROM  STUDENT";
            SqlDataReader reader = cmdLoadAcc.ExecuteReader();

            while (reader.Read())
            {
                SelectAcc.Items.Add(reader[0].ToString() + "    " + reader[1].ToString());
            }
            reader.Close();
        }

        void LoadBooks()
        {
            SqlCommand cmdLoadBook = DBConnection.CreateCommand();
            cmdLoadBook.CommandText = "Select Book_ID, Title FROM BOOK";
            SqlDataReader reader = cmdLoadBook.ExecuteReader();

            while (reader.Read())
            {
                SelectBook.Items.Add(reader[0].ToString() + "    " + reader[1].ToString());
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
              //  tDate.Text = reader[0].ToString().Substring(0, 10);
               // dDate.Text = reader[1].ToString().Substring(0, 10);
            } 
            reader.Close();
        }

        void LoadTransactionData()
        {
            DateTime minDate = SelectMin.Value;
            DateTime maxDate = SelectMax.Value;

            SqlCommand cmdLoadB = DBConnection.CreateCommand();
            cmdLoadB.CommandText = "SELECT Title, Name, Returned, Student_ID, Fname, Transaction_ID, Date, DueDate" +
                " FROM CONTAINS_BOOK JOIN BOOK ON CONTAINS_BOOK.B_ID = BOOK.Book_ID" +
                " JOIN BOOK_AUTHOR ON BOOK.Book_ID = BOOK_AUTHOR.B_ID" +
                " JOIN AUTHOR ON Author_ID = A_ID" +
                " JOIN [TRANSACTION] ON T_ID = Transaction_ID" +
                " JOIN STUDENT ON S_ID = Student_ID" +
                " WHERE (Date BETWEEN @MIN AND @MAX)";
            cmdLoadB.Parameters.AddWithValue("@MIN", minDate);
            cmdLoadB.Parameters.AddWithValue("@MAX", maxDate);

            if (!string.IsNullOrEmpty(SelectTrans.Text))
            {
                cmdLoadB.CommandText += " AND T_ID = @T_ID";
                cmdLoadB.Parameters.AddWithValue("@T_ID", Int32.Parse(SelectTrans.Text));
            }
            else if(!string.IsNullOrEmpty(SelectAcc.Text))
            {
                cmdLoadB.CommandText += " AND S_ID = @S_ID";
                cmdLoadB.Parameters.AddWithValue("@S_ID", Int32.Parse(SelectAcc.Text.Substring(0, 4)));
            }
            if (!string.IsNullOrEmpty(SelectBook.Text))
            {
                cmdLoadB.CommandText += " AND CONTAINS_BOOK.B_ID = @B_ID";
                cmdLoadB.Parameters.AddWithValue("@B_ID", Int32.Parse(SelectBook.Text.Substring(0, 4)));
            }

            cmdLoadB.CommandText += " ORDER BY Title";

            SqlDataReader reader = cmdLoadB.ExecuteReader();
            while (reader.Read())
            {
                BookTitle.AppendText(reader[0].ToString() + Environment.NewLine);
                BookAuthor.AppendText(reader[1].ToString() + Environment.NewLine);
                Returned.AppendText(reader[2].ToString() + Environment.NewLine);
                Account.AppendText(reader[3].ToString() + "    " + reader[4].ToString() + Environment.NewLine);
                Transaction.AppendText(reader[5].ToString() + Environment.NewLine);
                tDate.AppendText(reader[6].ToString().Substring(0, 10) + Environment.NewLine);
                dDate.AppendText(reader[7].ToString().Substring(0, 10) + Environment.NewLine);
            }
            reader.Close();
        }


        private void SelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTrans.Items.Clear();
            SelectTrans.ResetText();

            LoadTransactions(Int32.Parse(SelectAcc.Text.Substring(0, 4)));
        }

        private void ViewTrans_Click(object sender, EventArgs e)
        {
            BookTitle.Text = "";
            BookAuthor.Text = "";
            Returned.Text = "";
            Account.Text = "";
            Transaction.Text = "";
            tDate.Text = "";
            dDate.Text = "";

            LoadTransactionData();
        }

    }
}
