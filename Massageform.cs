using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace ChineseMedicine
{
    public partial class Massageform : Form
    {
        StringReader lineReader = null;
        PaperSize ps = new PaperSize("A5", 148, 210);
        public Massageform()
        {
            InitializeComponent();
            Massageform_Load();
        }

        //页面加载
        public void Massageform_Load()
        {
            printDocument1 = new PrintDocument();
            printDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.DefaultPageSettings.Landscape = true;
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            //日期
            String s = "";
            SqlCommand cmd = new SqlCommand(s, conn);
            cmd.CommandText = "select date from Information where IDnum = '" + All.Id + "'";
            DateTime dt = Convert.ToDateTime(cmd.ExecuteScalar());
            year.Text = dt.Year.ToString();
            month.Text = dt.Month.ToString();
            day.Text = dt.Day.ToString();

            //编号
            cmd.CommandText = "select IDp from Information where IDnum = '" + All.Id + "'";
            number.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "select Name from Patient where IDp = '" + number.Text + "'";
            name.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "select Addres from Information where IDnum = '" + All.Id + "'";
            String ad = cmd.ExecuteScalar().ToString();
            String ss = "", sq = "", sj = "", sde = "";
            int si = ad.IndexOf("市");
            int qi = ad.IndexOf("区");
            int ji = ad.IndexOf("街");
            int di = ji + 4;
            int l = ad.Length;
            //MessageBox.Show(si + " " + qi + " " + ji + " " + di);

            ss = ad.Substring(0, si);
            sq = ad.Substring(si + 1, qi - si - 1);
            sj = ad.Substring(qi + 1, ji - qi -1);
            sde = ad.Substring(di + 1, l - di - 1);
            //MessageBox.Show(ss + " " + sq + " " + sj + " " + sde);

            city.Text = ss;
            area.Text = sq;
            Street.Text = sj;
            detail.Text = sde;

            cmd.CommandText = "select Phone from Patient where IDp = '" + number.Text + "'";
            phone.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "select Phone from Patient where IDp = '" + number.Text + "'";
            label25.Text = cmd.ExecuteScalar().ToString();
            
            conn.Close();

            //MessageBox.Show(All.Lei);
            way.Text = All.Yao;
            type.Text = All.Lei;
            s = All.Num;
            //MessageBox.Show(s);
            int j = s.IndexOf("t");
            int k = s.IndexOf("x");
            count1.Text = s.Substring(0, j);
            count2.Text = s.Substring(j + 1, k - j - 1);
            count3.Text = s.Substring(k + 1, s.Length - 1 - k);
            note.Text = All.Bei;
            
        }
        
        //打印设置
        private void button4_Click(object sender, EventArgs e)
        {
            //printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        //页面设置
        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }


        //打印预览
        protected void FileMenuItem_PrintView_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            //lineReader = new StringReader(textBox.Text);
            try
            {
                this.printPreviewDialog1.ShowDialog();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //打印
        protected void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printDialog1.Document = printDocument1;
            
            if (true)
            {
                try
                {
                    Graphics g = e.Graphics;   //先建立画布   
                    int x = 20;
                    int y = 50;
                    TextBox tb = new TextBox();
                    //g.DrawImage(this.BackgroundImage, 1018, 555);
                    foreach (Control item in this.Controls)
                    {
                        if (item is Label)
                        {
                            Control tx = (item as Control);
                            g.DrawString(tx.Text, tx.Font, Brushes.Black, tx.Left + x, tx.Top + y);
                            tb.Text += tx.Text;
                        }
                    }
                    //MessageBox.Show("kaikai");
                }
                catch(Exception excep)
                {
                    MessageBox.Show(excep.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    printDocument1.PrintController.OnEndPrint(printDocument1,new PrintEventArgs());
                }
                //throw new NotImplementedException();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 1;
            //MessageBox.Show(i.ToString());
            //i++;

            //printDialog1.ShowDialog();

            PrintDialog MySettings = new PrintDialog();
            MySettings.Document = this.printDocument1;

            PaperSize p = null;
            foreach (PaperSize ps in MySettings.Document.PrinterSettings.PaperSizes)
            {
                if (ps.PaperName.Equals("A5"))//这里设置纸张大小,但必须是定义好的     
                    p = ps;
            }
            MySettings.Document.DefaultPageSettings.PaperSize = p;

            this.printDocument1.Print(); 

        }

        private void Massageform_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
        
    }
}
