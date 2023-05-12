using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.ShowDialog();
            Hide();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.ShowDialog();
            Hide();
        }

        private void завданняКурсовоїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet10.Назва_авто". При необходимости она может быть перемещена или удалена.
            this.назва_автоTableAdapter.Fill(this.bdDataSet10.Назва_авто);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
