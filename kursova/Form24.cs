using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form22 form22 = new Form22();
            form22.ShowDialog();
        }
    }
}
