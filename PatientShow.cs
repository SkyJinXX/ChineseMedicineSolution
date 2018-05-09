using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;


namespace ChineseMedicine
{
    public partial class PatientShow : Form
    {
        public PatientShow()
        {
            InitializeComponent();
        }

        private void PatientShow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“menzhenDataSet2.Patient”中。您可以根据需要移动或删除它。
            this.patientTableAdapter1.Fill(this.menzhenDataSet2.Patient);
            // TODO: 这行代码将数据加载到表“menzhenDataSet1.Patient”中。您可以根据需要移动或删除它。
            this.patientTableAdapter.Fill(this.menzhenDataSet1.Patient);
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = "select Patient.IDp, Name, Gender, birthdate, Phone, Addres from Address,Patient where Address.IDp " +
                " = Patient.IDp order by Patient.IDp asc; ";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;

            //gridview单元格内容居中
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“menzhenDataSet2.Patient”中。您可以根据需要移动或删除它。
            this.patientTableAdapter1.Fill(this.menzhenDataSet2.Patient);
            // TODO: 这行代码将数据加载到表“menzhenDataSet1.Patient”中。您可以根据需要移动或删除它。
            this.patientTableAdapter.Fill(this.menzhenDataSet1.Patient);
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = SqlFlush();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteScalar() == null)
            {
                MessageBox.Show("查无此纪录！", "错误提示:");
                sql = "select Patient.IDp, Name, Gender, birthdate, Phone, Addres from Address,Patient where Address.IDp " +
                " = Patient.IDp order by Patient.IDp asc; ";
            }
            else
            {
                MessageBox.Show("查询成功！", "友情提示:");
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;

            //gridview单元格内容居中
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            conn.Close();
        }

        protected String SqlFlush()
        {
            String s = "select Patient.IDp, Name, Gender, birthdate, Phone, Addres from Address,Patient where Address.IDp = Patient.IDp";

            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    s += " and Patient.IDp like '%" + textBox1.Text + "%' and Patient.Name like '%" + textBox2.Text + "%'";
                }
                else
                {
                    s += " and Patient.IDp like '%" + textBox1.Text + "%'";
                }
            }
            else
            {
                if (textBox2.Text != "")
                {
                    s += "and Patient.Name like '%" + textBox2.Text + "%'";
                }
            }

            s += " order by Patient.IDp asc; ";
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
