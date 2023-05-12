using System;
using System.Data;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form9 main = Owner as Form9;
            if (main != null)
            {
                DataRow nRow = main.bdDataSet6.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                nRow[4] = textBox5.Text;
                nRow[5] = textBox6.Text;
                nRow[6] = textBox7.Text;
                nRow[6] = textBox8.Text;
                main.bdDataSet6.Tables[0].Rows.Add(nRow);
                main.постачальникиTableAdapter.Update(main.bdDataSet6.Постачальники);
                main.bdDataSet6.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                Hide();
            }
        }

        private void tbNameTovaru_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
