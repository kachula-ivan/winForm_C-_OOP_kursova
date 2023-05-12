using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Form111 form1 = new Form111();
            form1.ShowDialog();
        }

        private void btnTovar_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void btnVydTovaru_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void наГоловнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void magazinavtozapchasteyDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
