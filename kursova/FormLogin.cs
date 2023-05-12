using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading;

namespace kursova
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);

            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new FormD());
        }


        private void button1_Click(object sender, EventArgs e)
        {


            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Magazin_avtozapchastey.mdb");
            try
            {
                string comand = string.Format("Select * From Data WHERE login=\"" + textBox1.Text + "\""
                    + "AND pass=\"" + textBox2.Text + "\"");
                OleDbCommand check = new OleDbCommand(comand, con);
                con.Open();

                if (check.ExecuteScalar() != null)
                {
                    Hide();
                    Form22 form22 = new Form22();
                    form22.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Не правильний логін чи пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 form21 = new Form21();
            form21.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form28 form28 = new Form28();
            form28.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form22 form22 = new Form22();
            form22.ShowDialog();
        }
    }
}
