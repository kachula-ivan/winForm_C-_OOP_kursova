﻿using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void Clear(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 1)
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet6.Постачальники". При необходимости она может быть перемещена или удалена.
            this.постачальникиTableAdapter.Fill(this.bdDataSet6.Постачальники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form111 form1 = new Form111();
            form1.ShowDialog();
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

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            постачальникиTableAdapter.Update(bdDataSet6.Постачальники);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 af = new Form19();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = false;
            MessageBox.Show("Редагувати дані можна прямо в таблиці. \nНе забудьте зберегти зміни!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear(dataGridView1);
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
