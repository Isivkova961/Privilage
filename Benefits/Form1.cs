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

        public fMainBenefits()
        {
            //Инициализация формы
            InitializeComponent();
            //Загрузка данных из БД в таблицу
            LoadData();
            //Ставим курсор на поле с фильтром по ФИО
            this.ActiveControl = tbFIO;

        }

        //Загрузка данных из БД в таблицу
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

        //Кнопка на добаление данных в БД
        private void bAdd_Click(object sender, EventArgs e)
        {
            NewData();
        }

        //Кнопка на изменение данных в БД
        private void bEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        //Кнопка для удаления данных из БД
        private void bDelete_Click(object sender, EventArgs e)
        {
            DelData();
        }

        //Процедура удаления данных из БД
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
            }
        }


        //Процедура для записи фильтра в строку
        private string Filters()
        {
            string str = "";
            //Запись фильтра по ФИО
            if (cebFIO.Checked == true)
            {
                if (str == "")
                {
                    str = "fio LIKE '*" + tbFIO.Text + "*'";
                }
                else
                {
                    str = str + " and fio LIKE '*" + tbFIO.Text + "*'";
                }
            }
            //Запись фильтра по льготе
            if (cebPrivilage.Checked == true)
            {
                if (str == "")
                {
                    str = "privilage=" + Convert.ToString(cebYesPrivilage.Checked);
                }
                else
                {
                    str = str + " and privilage=" + Convert.ToString(cebYesPrivilage.Checked);
                }
            }
            //Запись фильтра по дате рождения
            if (cebDateBirth.Checked == true)
            {
                if (str == "")
                {
                    str = "date_birth >='" + dtpDateBirthS.Text + "' and date_birth <='" + dtpDateBirthPo.Text + "'";
                }
                else
                {
                    str = str + " and date_birth >='" + dtpDateBirthS.Text + "' and date_birth <='" + dtpDateBirthPo.Text + "'";
                }
            }
            return str;
        }

        //Изменение данных фильтра по ФИО
        private void tbFIO_TextChanged(object sender, EventArgs e)
        {
            if (tbFIO.Text != "")
            {
                //Устанавливаем флаг фильтра по ФИО
                cebFIO.Checked = true;
                string str = Filters();
                //Фильтруем
                (dgvPrivilage.DataSource as DataTable).DefaultView.RowFilter = str;
            }
        }
        
        //Изменение сострояние флага фильтра по ФИО
        private void cebFIO_CheckedChanged(object sender, EventArgs e)
        {
            if (cebFIO.Checked == false)
            {
                //Очищаем поле фильтра для ФИО
                tbFIO.Text = "";

                string str = Filters();
                //Фильтруем
                (dgvPrivilage.DataSource as DataTable).DefaultView.RowFilter = str;
            }
        }


        //Изменение состояние флага фильтра по льготе
        private void cebPrivilage_CheckedChanged(object sender, EventArgs e)
        {
            if (cebPrivilage.Checked == false)
            {
                //Сбрасываем фильт есть льгота
                cebYesPrivilage.Checked = false;
            }

            string str = Filters();
            //Фильтруем
            (dgvPrivilage.DataSource as DataTable).DefaultView.RowFilter = str;
        }

        //Изменение состояния флага фильтра по дате рождения
        private void cebDateBirth_CheckedChanged(object sender, EventArgs e)
        {
            string str = Filters();
            //Фильтруем
            (dgvPrivilage.DataSource as DataTable).DefaultView.RowFilter = str;
        }

        private void fMainBenefits_KeyDown(object sender, KeyEventArgs e)
        {
            //Добавление данных по нажатию Insert
            if (e.KeyCode == Keys.Insert)
            {
                NewData();
            }
            //Изменение данных по нажатию Home
            if (e.KeyCode == Keys.Home)
            {
                EditData();
            }
            //Удаление данных по нажатию delete
            if (e.KeyCode == Keys.Delete)
            {
                DelData();
            }
        }

        //процедура для редактирования данных
        private void EditData()
        {
            fAEPrivilage newForm = new fAEPrivilage();
            //Запись данных из БД в компоненты для редактирования
            newForm.tbFIO.Text = dgvPrivilage.CurrentRow.Cells["fio"].Value.ToString();
            newForm.mtbDateBirth.Text = Convert.ToString(Convert.ToDateTime(dgvPrivilage.CurrentRow.Cells["date_birth"].Value));
            newForm.tbAdres.Text = dgvPrivilage.CurrentRow.Cells["adres"].Value.ToString();
            newForm.cobGender.Text = dgvPrivilage.CurrentRow.Cells["gender"].Value.ToString();
            newForm.cebPrivilage.Checked = Convert.ToBoolean(dgvPrivilage.CurrentRow.Cells["privilage"].Value);
            int iId = Convert.ToInt32(dgvPrivilage.CurrentRow.Cells["id"].Value);

            //Вызываем процедуру загрузки формы с нужными параметрами
            newForm.NewData(false, iId);
            newForm.Text = "Изменение данных";
            newForm.ShowDialog();
            //Обновляем данные из БД
            LoadData();
        }

        //Процедура для добавления данных
        private void NewData()
        {
            fAEPrivilage newForm = new fAEPrivilage();
            //Вызываем процедуру загрузки формы с нужными параметрами
            newForm.NewData(true, 0);
            newForm.Text = "Добавление данных";
            newForm.ShowDialog();
            //Обновляем данные из БД
            LoadData();
        }

        //Процедура для удаления данных
        private void DelData()
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
    }

}
