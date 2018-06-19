using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;


namespace Benefits
{
    public partial class fMainBenefits : Form
    {
        string connstr = Benefits.Utility.GetConnectionString();
        public fMainBenefits()
        {
            InitializeComponent();
            OleDbConnection conn = new OleDbConnection(connstr);

            OleDbCommand cmdAddPrivilage = new OleDbCommand("SELECT * FROM data", conn);

            try
            {
                conn.Open();
                cmdAddPrivilage.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        private void fMainBenefits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.dataDataSet.data);

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fAEPrivilage newForm = new fAEPrivilage();
            newForm.Show();
        }
    }
}
