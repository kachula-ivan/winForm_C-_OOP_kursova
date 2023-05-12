using System;
using System.Data;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 main = Owner as Form5;
            if (main != null)
            {
                DataRow nRow = main.bdDataSet1.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                main.bdDataSet1.Tables[0].Rows.Add(nRow);
                main.види_товаруTableAdapter.Update(main.bdDataSet1.Види_товару);
                main.bdDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                Hide();
            }
        }
    }
}
