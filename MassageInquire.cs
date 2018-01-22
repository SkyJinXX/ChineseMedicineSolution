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
    public partial class MassageInquire : Form
    {
        public MassageInquire()
        {
            InitializeComponent();
        }

        private void 确认信息_Click(object sender, EventArgs e)
        {
            this.Close();
            Form MainFunction = new MainFunction();
            MainFunction.Show();
        }
    }
}
