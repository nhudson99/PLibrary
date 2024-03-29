﻿using System;
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
            btn_End.Enabled = false;
            SelectBook.Enabled = false;
            btn_Process.Enabled = false;

            LoadAccounts();
            LoadBooks();
        }

        void LoadAccounts()
        {
            SqlCommand cmdLoadAcc = DBConnection2.CreateCommand();
            cmdLoadAcc.CommandText = "Select Student_ID, Fname FROM  STUDENT";
            SqlDataReader reader = cmdLoadAcc.ExecuteReader();

            while (reader.Read())
            {
                SelectAcc.Items.Add(reader[0].ToString() + "   " + reader[1].ToString());
            }
            reader.Close();
        }

        void LoadBooks()
        {
            SqlCommand cmdLoadBook = DBConnection2.CreateCommand();
            cmdLoadBook.CommandText = "Select Book_ID, Title FROM BOOK WHERE Available > 0";
            SqlDataReader reader = cmdLoadBook.ExecuteReader();

            while (reader.Read())
            {
                SelectBook.Items.Add(reader[0].ToString() + "    " + reader[1].ToString());
            }
            reader.Close();
        }

        int CreateTransaction()
        {
            DateTime Tdate = DateTime.Now;
            DateTime Ddate = Tdate.AddDays(14);

            SqlCommand cmdNewTrans = DBConnection2.CreateCommand();
            cmdNewTrans.CommandText = "INSERT INTO [TRANSACTION] (S_ID, Date, DueDate)";
            cmdNewTrans.CommandText += " OUTPUT INSERTED.Transaction_ID VALUES (@S_ID, @Date, @DueDate)";
            cmdNewTrans.Parameters.AddWithValue("@S_ID", SelectAcc.Text.Substring(0, 4));
            cmdNewTrans.Parameters.AddWithValue("@Date", Tdate);
            cmdNewTrans.Parameters.AddWithValue("@DueDate", Ddate);

            // t is Transaction_ID
            int t = (int)cmdNewTrans.ExecuteScalar(); 

            return t;
        }

        void NewContains_Book(int B_ID, int T_ID)
        {
            SqlCommand cmdNew = DBConnection2.CreateCommand();
            cmdNew.CommandText = "INSERT INTO CONTAINS_BOOK VALUES(@T_ID,@B_ID,@r)";
            cmdNew.Parameters.AddWithValue("@T_ID", T_ID);
            cmdNew.Parameters.AddWithValue("@B_ID", B_ID);
            cmdNew.Parameters.AddWithValue("@r", 'n');
            try
            {
                cmdNew.ExecuteNonQuery();

                MessageBox.Show("Book Checked Out, Due in 2 weeks");
                // Decrement 'Available'
                DecrementBookCount(B_ID);
                //reload book id's into combobox
                SelectBook.Items.Clear();
                SelectBook.ResetText();
                LoadBooks();
            }
            catch
            { // exception for trying to checkout 2 copies of same book in one transaction
                MessageBox.Show("Only 1 copy per transaction");
            }
        }

        void DecrementBookCount(int bno)
        {
            SqlCommand cmdDec = DBConnection2.CreateCommand();
            cmdDec.CommandText = "UPDATE BOOK SET Available = Available - 1 WHERE Book_ID = @B_ID";
            cmdDec.Parameters.AddWithValue("@B_ID", bno);
            cmdDec.ExecuteNonQuery();
        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (SelectAcc.SelectedItem != null)
            {
                SelectAcc.Enabled = false; //  prevent account change during transaction
                btn_Start.Enabled = false;
                btn_End.Enabled = true;
                SelectBook.Enabled = true;
                btn_Process.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a valid account");
            }
        }

        private void Btn_End_Click(object sender, EventArgs e)
        {
            // reset
            SelectAcc.Enabled = true;
            btn_Start.Enabled = true;
            btn_End.Enabled = false;
            SelectBook.Enabled = false;
            btn_Process.Enabled = false;
            books = 0;
        }

        private void Btn_Process_Click(object sender, EventArgs e)
        {
            if (SelectAcc.Enabled == false) // check that start button has been pressed
            {
                books++;
                if (books == 1)
                {   // CREATE new TRANSACTION for DB, get the auto-generated id
                    trans_ID = CreateTransaction();
                }
                // CREATE new CONTAINS_BOOK
                NewContains_Book(Int32.Parse(SelectBook.Text.Substring(0, 4)), trans_ID);
            }
        }
    }
}
