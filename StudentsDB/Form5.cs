using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDB
{
    public partial class Form5 : Form
    {
 
        public Form5()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zakharovDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zakharovDataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.zakharovDataSet.Оценки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(оценка1TextBox.Text);
            decimal b = Convert.ToDecimal(оценка2TextBox.Text);
            decimal c = Convert.ToDecimal(оценка3TextBox.Text);
            decimal d = (a + b + c) / 3;
            среднийБаллTextBox.Text = d.ToString("0.00");


        }
    }
}
