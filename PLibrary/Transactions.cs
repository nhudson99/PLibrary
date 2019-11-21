using System;
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

        private void SelectAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions();
        }
    }
}
