using System;
using System.Data;
using System.Windows.Forms;

namespace kursova
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form4 main = Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main.bdDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = tbKodTovaru.Text;
                nRow[1] = tbNameTovaru.Text;
                nRow[2] = tbPostachalnyck.Text;
                nRow[3] = tbTypTovaru.Text;
                nRow[4] = tbKodAuto.Text;
                nRow[5] = tbPrice.Text;
                nRow[6] = cb1.Checked;
                main.bdDataSet.Tables[0].Rows.Add(nRow);
                main.товарTableAdapter.Update(main.bdDataSet.Товар);
                main.bdDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbKodTovaru.Text = "";
                tbNameTovaru.Text = "";
                tbPostachalnyck.Text = "";
                tbTypTovaru.Text = "";
                tbKodAuto.Text = "";
                tbPrice.Text = "";
                cb1.Text = "";
                Hide();
            }
        }
    }
}
