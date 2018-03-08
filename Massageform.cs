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

namespace ChineseMedicine
{
    public partial class Massageform : Form
    {
        public Massageform()
        {
            InitializeComponent();
            Massageform_Load();
        }
        
        public void Massageform_Load()
        {
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
    }
}
