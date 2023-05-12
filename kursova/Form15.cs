using System;
using System.Data;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 main = Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.bdDataSet2.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = tb1.Text;
                nRow[1] = tb2.Text;
                main.bdDataSet2.Tables[0].Rows.Add(nRow);
                main.назва_автоTableAdapter.Update(main.bdDataSet2.Назва_авто);
                main.bdDataSet2.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tb1.Text = "";
                tb2.Text = "";
                Hide();
            }
        }
    }
}
