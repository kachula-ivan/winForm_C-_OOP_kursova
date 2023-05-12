using System;
using System.Data;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 main = Owner as Form11;
            if (main != null)
            {
                DataRow nRow = main.bdDataSet8.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                main.bdDataSet8.Tables[0].Rows.Add(nRow);
                main.накладнаTableAdapter.Update(main.bdDataSet8.Накладна);
                main.bdDataSet8.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
