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
        //Строка подключения
        string connstr = Benefits.Utility.GetConnectionString();
        //Переменная для проверки добавления или редактирования данных
        bool bNewEdit;

        public fMainBenefits()
        {
            InitializeComponent();
            LoadData();

        }

        private void fMainBenefits_Load(object sender, EventArgs e)
        {


        }

        public void LoadData()
        {
            //Создаем подключение
            using (OleDbConnection conn = new OleDbConnection(connstr))
            {
                //Запрос на вывод данных
                OleDbCommand cmdAddPrivilage = new OleDbCommand("SELECT * FROM data", conn);

                try
                {
                    //Создаем датасет
                    DataSet ds = new DataSet();
                    //Открываем подключение
                    conn.Open();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdAddPrivilage);
                    dataAdapter.Fill(ds, "LoadData");
                    //Выводим данные таблицы в датагрид
                    dgvPrivilage.DataSource = ds.Tables["LoadData"];

                }
                finally
                {
                    //Закрываем подключение
                    conn.Close();
                }
            }

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fAEPrivilage newForm = new fAEPrivilage();
            newForm.NewData(true, 0);
            newForm.Show();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            bNewEdit = false;
            fAEPrivilage newForm = new fAEPrivilage();
            //Запись данных из БД в компоненты для редактирования
            newForm.tbFIO.Text = dgvPrivilage.CurrentRow.Cells["fio"].Value.ToString();
            newForm.mtbDateBirth.Text = Convert.ToString(Convert.ToDateTime(dgvPrivilage.CurrentRow.Cells["date_birth"].Value));
            newForm.tbAdres.Text = dgvPrivilage.CurrentRow.Cells["adres"].Value.ToString();
            newForm.cobGender.Text = dgvPrivilage.CurrentRow.Cells["gender"].Value.ToString();
            newForm.cebPrivilage.Checked = Convert.ToBoolean(dgvPrivilage.CurrentRow.Cells["privilage"].Value);
            int iId = Convert.ToInt32(dgvPrivilage.CurrentRow.Cells["id"].Value);

            newForm.NewData(false, iId);
            newForm.Show();

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить данного льготника?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //Процедура удаления строки из БД
                DeleteData();
                //Обновление вывода таблицы
                LoadData();
            }
        }

        private void DeleteData()
        {
            int index = dgvPrivilage.CurrentRow.Index;
            //Создаем подключение
            using (OleDbConnection conn = new OleDbConnection(connstr))
            {
                //Запрос на удаление данных
                OleDbCommand cmdAddPrivilage = new OleDbCommand("DELETE FROM data WHERE id = @id", conn);
                cmdAddPrivilage.Parameters.AddWithValue("@id", dgvPrivilage.CurrentRow.Cells["id"].Value);

                try
                {
                    conn.Open();
                    cmdAddPrivilage.ExecuteNonQuery();

                }
                finally
                {
                    //Закрываем подключение
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
