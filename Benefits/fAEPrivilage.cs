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
        //переменная для обозначения для чего открываем форму (добаление или редактирование данных)
        bool bNewEdit;
        //переменная индетификатора строки для редактирования
        int iId;
        fMainBenefits f1 = new fMainBenefits();

        public fAEPrivilage()
        {
            InitializeComponent();
            //Курсор на ФИО
            this.ActiveControl = tbFIO;


        }

        //Кнопка сохранения данных
        private void bSave_Click(object sender, EventArgs e)
        {
            //Проверка введенных данных
            if (mtbDateBirth.Text.Length < 10)
            {
                MessageBox.Show("Неверно введена дата рождения", "Сообщение");
                //Возвращаем курсор на дату рождения
                mtbDateBirth.Focus();
            }
            else
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
                    cmdAddPrivilage.CommandText = "UPDATE data SET fio = @fio, date_birth = @date_birth, gender = @gender, adres = @adres, privilage = @privilage WHERE id = " + Convert.ToString(iId);
                    cmdAddPrivilage.Connection = conn;
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
                this.Close();             
            }
        }

        //Кнопка отмены
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Процедура очистки полей данных
        public void NewData(bool bNewEdit1, int iId1)
        {
            bNewEdit = bNewEdit1;
            iId = iId1;

            //Если мы открыли форму для добавления данных
            if (bNewEdit1 == true)
            {
                tbFIO.Text = "";
                mtbDateBirth.Text = "";
                cobGender.TabIndex = 0;
                tbAdres.Text = "";
                cebPrivilage.Checked = false;
            }
        }

        //Закрытие окна по нажатию кнопки ESC
        private void fAEPrivilage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
