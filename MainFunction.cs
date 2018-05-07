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
    public partial class MainFunction : Form
    {

        public MainFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MassageInquire = new MassageInquire();
            MassageInquire.ShowDialog();
            this.Show();
            //Application.ExitThread();
            //this.Close();
            //this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form selectMassage = new selectMassage();
            selectMassage.ShowDialog();
            this.Show();
            //Application.ExitThread();
            //this.Close();
            //this.Dispose();
        }

        private void Massageform_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }

    //全局变量
    public static class All
    {
        private static String id = "";
        private static String yao = "";
        private static String lei = "";
        private static String num = "";
        private static String bei = "";
        public static String Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public static String Yao
        {
            get
            {
                return yao;
            }
            set
            {
                yao = value;
            }
        }
        public static String Lei
        {
            get
            {
                return lei;
            }
            set
            {
                lei = value;
            }
        }
        public static String Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public static String Bei
        {
            get
            {
                return bei;
            }
            set
            {
                bei = value;
            }
        }
    }

    
}
