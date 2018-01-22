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
            this.Close();
            Form MassageInquire = new MassageInquire();
            MassageInquire.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form selectMassage = new selectMassage();
            selectMassage.Show();
        }
    }
}
