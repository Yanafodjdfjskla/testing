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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            teacherForm teacher = new teacherForm();
            teacher.Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Текст второго вопроса";
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {
            label2.Text = "Текст второго вопроса";
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = Color.FromArgb(106, 177, 135);
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = Color.FromArgb(0, 59, 70);
        }

        private void ПравкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void ToolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void ВыделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            добавитьЗаданиеToolStripMenuItem.Enabled = false;
        }
    }
}
