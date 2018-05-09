using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            //this.Hide();
            //Form MainFunction = new MainFunction();
            //MainFunction.ShowDialog();
            //Application.ExitThread();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            if(textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || 
                textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" ||
                textBox8.Text == "" || textBox11.Text == "" || textBox12.Text == "" ||
                comboBox1.SelectedItem.ToString()=="")
            {
                MessageBox.Show("信息请填写完整");

                return;
            }

            String sq = "select IDp from Patient where IDp = '" + textBox4.Text + "'";
            SqlCommand cq = new SqlCommand(sq, conn);
            if (cq.ExecuteScalar() != null)
            {
                MessageBox.Show("患者已存在，无需录入！");
            }
            else
            {
                //获取出生日期
                String birthday = Get_Data();
                
                //获取Gender（M/F）
                String gender = "";
                gender = comboBox1.SelectedItem.ToString();
                
                String str = "insert into Patient values('" + textBox4.Text + "', '" + textBox5.Text
                    + "', '" + gender + "','" + birthday + "','" + textBox11.Text + "', '" + textBox10.Text + "')";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteScalar();
                //MessageBox.Show("患者信息已录入！");

                String s = Address_Deal();
                cq.CommandText = "select IDp from Address where Addres = '" + s + "' and IDp = '" + textBox4.Text + "'";
                if (cq.ExecuteScalar() != null)
                {
                    MessageBox.Show("该地址已存在，无需录入！");
                }
                else
                {
                    cq.CommandText = "select Count(*) from Address";
                    int num = Convert.ToInt32(cq.ExecuteScalar()) + 1;
                    cmd.CommandText = "insert into Address values('" + num.ToString() + "','" + textBox4.Text
                        + "','" + s + "')";
                    cmd.ExecuteScalar();
                    MessageBox.Show("患者信息已录入！");
                }
            }
            conn.Close();
        }

        private string Address_Deal()
        {
            String s = "";

            String sp = textBox2.Text;
            if (!sp.EndsWith("省"))
            {
                sp += "省";
            }

            String ss = textBox6.Text;
            if (!ss.EndsWith("市"))
            {
                ss += "市";
            }

            String sq = textBox8.Text;
            if (!sq.EndsWith("区"))
            {
                sq += "区";
            }

            String sj = textBox7.Text;
            if (sj.EndsWith("街") || sj.EndsWith("乡"))
            {
                sj = sj.Substring(0, sj.Length - 1);
            }
            sj += "街道（乡）";

            s = sp + ss + sq + sj + textBox9.Text;

            return s;
            throw new NotImplementedException();
        }

        //获取出生日期
        private string Get_Data()
        {
            String s = textBox12.Text + "-";
            if (textBox1.Text.Length == 1)
                s += "0";
            s += textBox1.Text + "-";

            if (textBox3.Text.Length == 1)
                s += "0";
            s += textBox3.Text + " 00:00:00";

            //MessageBox.Show(s);
            return s;
        }

        private void MassageInquire_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MassageNewAddress = new MassageNewAddress();
            MassageNewAddress.ShowDialog();
            this.Show();
        }
    }
}