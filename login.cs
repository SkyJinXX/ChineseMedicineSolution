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
                this.Visible = false;
                Form MainFunction = new MainFunction();
                MainFunction.Show();
            }
            else
            {
                MessageBox.Show("用户名密码错误！");

            }
        }
    }
}
