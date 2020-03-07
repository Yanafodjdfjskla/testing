using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingofpupils
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.pass.AutoSize = false;
            this.pass.Size = new Size(this.pass.Size.Width, 32);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string loginuser = login.Text;
            string passuser = pass.Text;

            DB db = new DB();

            DataTable tabel = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `students` WHERE `login`=@lu AND `password`=@pu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = passuser;
           

            adapter.SelectCommand = command;
            adapter.Fill(tabel);

            if(tabel.Rows.Count>0)
            {
                
                MainForm mf = new MainForm();
                mf.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            
           
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
