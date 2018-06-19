using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Benefits
{
    public partial class fAEPrivilage : Form
    {
        //Присвоение стоки подключения к БД
        string connstr = Benefits.Utility.GetConnectionString();
        public fAEPrivilage()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connstr);

            OleDbCommand cmdAddPrivilage = new OleDbCommand("INSERT INTO data (fio, date_birth, gender, adres, privilage) VALUES (@fio, @date_birth, @gender, @adres, @privilage)", conn);
            cmdAddPrivilage.Parameters.AddWithValue("@fio", tbFIO.Text);
            cmdAddPrivilage.Parameters.AddWithValue("@date_birth", Convert.ToDateTime(dtpDateBirth.Text));
            cmdAddPrivilage.Parameters.AddWithValue("@gender", cobGender.Text);
            cmdAddPrivilage.Parameters.AddWithValue("@adres", tbAdres.Text);
            cmdAddPrivilage.Parameters.AddWithValue("@privilage", cebPrivilage.Checked);

            try
            {
                conn.Open();
                cmdAddPrivilage.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }

            

            this.Close();

        }
    }
}
