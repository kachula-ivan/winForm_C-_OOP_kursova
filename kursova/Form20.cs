using System;
using System.Data;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 main = Owner as Form10;
            if (main != null)
            {
                DataRow nRow = main.bdDataSet7.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                main.bdDataSet7.Tables[0].Rows.Add(nRow);
                main.звіт_продажTableAdapter.Update(main.bdDataSet7.Звіт_продаж);
                main.bdDataSet7.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
