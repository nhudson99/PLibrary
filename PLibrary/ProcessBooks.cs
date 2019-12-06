using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PLibrary
{
    public partial class ProcessBooks : Form
    {
        public SqlConnection DBConnection;

        public ProcessBooks()
        {
            InitializeComponent();

        }
  
        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            CheckOut frm = new CheckOut();
            frm.DBConnection2 = DBConnection;
            frm.Show();

            this.Close();
        }

        private void Btn_CheckIn_Click(object sender, EventArgs e)
        {
            CheckIn frm = new CheckIn();
            frm.DBConnection2 = DBConnection;
            frm.Show();

            this.Close();
        }

        private void Btn_PlaceHold_Click(object sender, EventArgs e)
        {
            PlaceHold frm = new PlaceHold();
            frm.DBConnection2 = DBConnection;
            frm.Show();

            this.Close();
        }

        
    }
}
