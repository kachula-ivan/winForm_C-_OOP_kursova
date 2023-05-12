using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Form22 form22 = new Form22();
            form22.ShowDialog();
        }

        private void завданняКурсовоїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
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

        private void btnTovar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form25 form25 = new Form25();
            form25.ShowDialog();
        }

        private void btnVydTovaru_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form27 form27 = new Form27();
            form27.ShowDialog();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form26 form26 = new Form26();
            form26.ShowDialog();
        }
    }
}
