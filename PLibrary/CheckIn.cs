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
    public partial class CheckIn : Form
    {
        public SqlConnection DBConnection2;

        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            SelectBook.Enabled = false;
            TransactionView.Enabled = false;
            btn_Process.Enabled = false;

            LoadAccounts();
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

        void LoadBooks(int acc)
        {
            SqlCommand cmdLoadBook = DBConnection2.CreateCommand();
            cmdLoadBook.CommandText = "Select Book_ID, T_ID " +
                "FROM BOOK JOIN CONTAINS_BOOK ON Book_ID = B_ID" +
                " JOIN [TRANSACTION] ON T_ID = Transaction_ID" +
                " WHERE (S_ID = @S_ID) AND (Returned = @r)";
            cmdLoadBook.Parameters.AddWithValue("@S_ID", acc);
            cmdLoadBook.Parameters.AddWithValue("@r", 'n'); // nonreturned book
            SqlDataReader reader = cmdLoadBook.ExecuteReader();

            while (reader.Read())
            {
                SelectBook.Items.Add(reader[0].ToString());
                TransactionView.Items.Add(reader[1].ToString());
            }
            reader.Close();
        }

        void BookReturn(int tno, int bno)
        {
            SqlCommand cmdReturn = DBConnection2.CreateCommand();
            cmdReturn.CommandText = "UPDATE CONTAINS_BOOK SET Returned = @r" +
                " WHERE T_ID = @T_ID AND B_ID = @B_ID";
            cmdReturn.Parameters.AddWithValue("@T_ID", tno);
            cmdReturn.Parameters.AddWithValue("@B_ID", bno);
            cmdReturn.Parameters.AddWithValue("@r", 'y');
            cmdReturn.ExecuteNonQuery();
        }

        private void SelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear combo boxes first 
            SelectBook.Items.Clear();
            SelectBook.ResetText();
            TransactionView.Items.Clear();
            TransactionView.ResetText();

            LoadBooks(Int32.Parse(SelectAcc.Text));

            SelectBook.Enabled = true;
            btn_Process.Enabled = false;
        }

        private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Process.Enabled = true;
            if (SelectBook.Text != "")
            { //edit this code, whe4n last book is checked in, this part fails
                TransactionView.SelectedIndex = SelectBook.SelectedIndex;
            } /*
            else
            {
                SelectBook.Text = "";
                TransactionView.Text = "";
                btn_Process.Enabled = false;
            } */
        }

        private void Btn_Process_Click(object sender, EventArgs e)
        {
            BookReturn(Int32.Parse(TransactionView.Text), Int32.Parse(SelectBook.Text));
            // remove book id and trans id that coresspond to returned book from combo boxes
            TransactionView.Text = "";
            TransactionView.Items.RemoveAt(TransactionView.SelectedIndex);
            SelectBook.Text = "";
            SelectBook.Items.RemoveAt(SelectBook.SelectedIndex);
            btn_Process.Enabled = false;
            
        }

        
    }
}
