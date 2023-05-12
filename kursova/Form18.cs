using System;
using System.Data;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 main = Owner as Form8;
            if (main != null)
            {
                DataRow nRow = main.bdDataSet4.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                nRow[4] = textBox5.Text;
                main.bdDataSet4.Tables[0].Rows.Add(nRow);
                main.поставкаTableAdapter.Update(main.bdDataSet4.Поставка);
                main.bdDataSet4.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                Hide();
            }
        }
    }
}
