using System;
using System.Data.OleDb;
using System.Windows.Forms;


namespace kursova
{
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;DataWorker Source=G:\Magazin_avtozapchastey.mdb");

            try
            {
                if ((textBox1.Text == "Admin") && (textBox2.Text == "admin"))
                {
                    Hide();
                    Form111 form1 = new Form111();
                    form1.Show();
                }
                if ((textBox1.Text == "123") && (textBox2.Text == "123"))
                {
                    Hide();
                    Form111 form1 = new Form111();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пороль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
