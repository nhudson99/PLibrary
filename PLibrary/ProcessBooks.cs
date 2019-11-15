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
        private void ProcessBooks_Load(object sender, EventArgs e)
        {

        }
        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            CheckOut frm = new CheckOut();
            frm.DBConnection2 = DBConnection;
            frm.Show();
        }

        private void Btn_CheckIn_Click(object sender, EventArgs e)
        {

        }

        private void Btn_PlaceHold_Click(object sender, EventArgs e)
        {

        }

        
    }
}
