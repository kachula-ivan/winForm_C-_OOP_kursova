using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kursova
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection oleDbConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Magazin_avtozapchastey.mdb");
                oleDbConn.Open();
                string sql = "INSERT INTO Data (login, pass) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "');";
                OleDbCommand oleComm = new OleDbCommand(sql, oleDbConn);
                oleComm.ExecuteNonQuery();
                MessageBox.Show("Користувач успішно зареєстрований");
                this.Hide();
                Form22 form22 = new Form22();
                form22.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
