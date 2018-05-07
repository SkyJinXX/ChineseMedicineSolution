using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseMedicine
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();
            if (username == "admin" && password == "admin")
            {
                this.Hide();
                Form MainFunction = new MainFunction();
                MainFunction.ShowDialog();
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show("用户名密码错误！");

            }
        }

        private void Massageform_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_on(object sender, EventArgs e)
        {

        }
    }
}
