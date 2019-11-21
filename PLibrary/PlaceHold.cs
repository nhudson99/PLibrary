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
    public partial class PlaceHold : Form
    {
        public SqlConnection DBConnection2;

        public PlaceHold()
        {
            InitializeComponent();
        }

        private void PlaceHold_Load(object sender, EventArgs e)
        {
            SelectBook.Enabled = false;
            btn_Process.Enabled = false;

            LoadAccounts();
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
            cmdLoadBook.CommandText = "Select Book_ID, Title FROM BOOK" +
                " WHERE Available = 0";
            SqlDataReader reader = cmdLoadBook.ExecuteReader();

            while (reader.Read())
            {
                SelectBook.Items.Add(reader[0].ToString() + "   " + reader[1].ToString());
            }
            reader.Close();
        }

        void BookHold()
        {
            DateTime date = DateTime.Now;

            SqlCommand cmdNewHold = DBConnection2.CreateCommand();
            cmdNewHold.CommandText = "INSERT INTO HOLD (S_ID, B_ID, Date)";
            cmdNewHold.CommandText += "  VALUES (@S_ID, @B_ID, @Date)";
            cmdNewHold.Parameters.AddWithValue("@S_ID", SelectAcc.Text.Substring(0, 4));
            cmdNewHold.Parameters.AddWithValue("@B_ID", SelectBook.Text.Substring(0, 4));
            cmdNewHold.Parameters.AddWithValue("@Date", date);

            cmdNewHold.ExecuteScalar();
        }

        private void SelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBook.Items.Clear();
            SelectBook.ResetText();

            SelectBook.Enabled = true;
            btn_Process.Enabled = false;
            LoadBooks();
        }

        private void SelectBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Process.Enabled = true;
        }

        private void Btn_Process_Click(object sender, EventArgs e)
        {
            BookHold();

            SelectBook.Text = "";
            SelectBook.Items.RemoveAt(SelectBook.SelectedIndex);
            btn_Process.Enabled = false;
            MessageBox.Show("Hold Placed");
        }
    }
}
