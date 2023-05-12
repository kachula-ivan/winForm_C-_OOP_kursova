using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 form23 = new Form23();
            form23.ShowDialog();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void завданняКурсовоїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 form23 = new Form23();
            form23.ShowDialog();
        }

        private void Form27_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet11.Види_товару". При необходимости она может быть перемещена или удалена.
            this.види_товаруTableAdapter.Fill(this.bdDataSet11.Види_товару);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Rows[i].Cells[j].Value.ToString() == textBox1.Text)
                        dataGridView1.Rows[i].Cells[j].Selected = true;
        }
    }
}
