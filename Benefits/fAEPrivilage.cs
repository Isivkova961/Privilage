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
        bool bNewEdit;
        int iId;
        fMainBenefits f1 = new fMainBenefits();

        public fAEPrivilage()
        {
            InitializeComponent();


        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //Создаем подключение к БД
            OleDbConnection conn = new OleDbConnection(connstr);

            //Запрос на добавление данных
            OleDbCommand cmdAddPrivilage = new OleDbCommand();

            
            if (bNewEdit == true)
            {
                //Добавление новых данных
                cmdAddPrivilage.CommandText = "INSERT INTO data (fio, date_birth, gender, adres, privilage) VALUES (@fio, @date_birth, @gender, @adres, @privilage)";
                cmdAddPrivilage.Connection = conn;
            }
            else
            {
                //Изменение данных
                cmdAddPrivilage.CommandText = "UPDATE data SET fio = @fio, date_birth = @date_birth, gender = @gender, adres = @adres, privilage = @privilage WHERE id = @id";
               // cmdAddPrivilage.CommandText = "UPDATE data SET fio = @fio, date_birth = @date_birth, gender = @gender, adres = @adres, privilage = @privilage WHERE id = 1";
                cmdAddPrivilage.Connection = conn;
                cmdAddPrivilage.Parameters.AddWithValue("@id", iId);
            }

            cmdAddPrivilage.Parameters.AddWithValue("@fio", tbFIO.Text);
            cmdAddPrivilage.Parameters.AddWithValue("@date_birth", Convert.ToDateTime(mtbDateBirth.Text));
            cmdAddPrivilage.Parameters.AddWithValue("@gender", cobGender.Text);
            cmdAddPrivilage.Parameters.AddWithValue("@adres", tbAdres.Text);
            cmdAddPrivilage.Parameters.AddWithValue("@privilage", cebPrivilage.Checked);

            try
            {
                //Открываем подключение
                conn.Open();
                //Выполняем запрос
                cmdAddPrivilage.ExecuteNonQuery();

            }
            finally
            {
                //Закрываем подключение
                conn.Close();
            }


           // f1.LoadData();




            this.Close();

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Процедура очистки полей данных
        public void NewData(bool bNewEdit1, int iId1)
        {
            bNewEdit = bNewEdit1;
            iId = iId1;

            if (bNewEdit1 == true)
            {
                tbFIO.Text = "";
                mtbDateBirth.Text = "";
                cobGender.Text = "";
                tbAdres.Text = "";
                cebPrivilage.Checked = false;
            }
        }
    }
}
