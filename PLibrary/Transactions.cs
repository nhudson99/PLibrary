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

    }
}
