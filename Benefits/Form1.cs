using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benefits
{
    public partial class fMainBenefits : Form
    {
        public fMainBenefits()
        {
            InitializeComponent();
        }

        private void fMainBenefits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.dataDataSet.data);

        }
    }
}
