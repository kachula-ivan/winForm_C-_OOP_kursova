using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void завданняКурсовоїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form24 form24 = new Form24();
            form24.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 form23 = new Form23();
            form23.ShowDialog();
        }
    }
}
