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
    public partial class MassageShow : Form
    {
        public MassageShow()
        {
            InitializeComponent();
        }

        private void MassageShow_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = false;
            // TODO: 这行代码将数据加载到表“menzhenDataSet.Patient”中。您可以根据需要移动或删除它。
            this.patientTableAdapter.Fill(this.menzhenDataSet.Patient);
            // TODO: 这行代码将数据加载到表“menzhenDataSet.Information”中。您可以根据需要移动或删除它。
            this.informationTableAdapter.Fill(this.menzhenDataSet.Information);
            // TODO: 这行代码将数据加载到表“menzhenDataSet.Address”中。您可以根据需要移动或删除它。
            this.addressTableAdapter.Fill(this.menzhenDataSet.Address);

            
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = "select Patient.IDp,Name,Phone,Addres,Date,IDnum from Information,Patient where Information.IDp = Patient.IDp" 
                + " order by Date desc; ";
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
            dataGridView1.Columns["IDnum"].Visible = false;
            dataGridView1.Columns["IDp"].DisplayIndex = 0;
            dataGridView1.Columns["PName"].DisplayIndex = 1;
            dataGridView1.Columns["PPhone"].DisplayIndex = 2;
            dataGridView1.Columns["PAddres"].DisplayIndex = 3;
            dataGridView1.Columns["PDate"].DisplayIndex = 4;

            conn.Close();
        }

        //查询满足条件下的记录
        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“menzhenDataSet.Patient”中。您可以根据需要移动或删除它。
            this.patientTableAdapter.Fill(this.menzhenDataSet.Patient);
            // TODO: 这行代码将数据加载到表“menzhenDataSet.Information”中。您可以根据需要移动或删除它。
            this.informationTableAdapter.Fill(this.menzhenDataSet.Information);
            // TODO: 这行代码将数据加载到表“menzhenDataSet.Address”中。您可以根据需要移动或删除它。
            this.addressTableAdapter.Fill(this.menzhenDataSet.Address);
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = SqlFlush();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if(cmd.ExecuteScalar() == null)
            {
                MessageBox.Show("查无此纪录！", "错误提示:");
                sql = "select Patient.IDp,Name,Phone,Addres,Date from Information,Patient where Information.IDp = Patient.IDp"
                    + " order by Date desc; ";
            }
            else
            {
                //MessageBox.Show("查询成功！", "友情提示:");
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
            String s = "select IDnum,Patient.IDp,Name,Phone,Addres,Date from Information,Patient where Information.IDp = Patient.IDp ";

            if(textBox1.Text != "")
            {
                if(textBox2.Text != "")
                {
                    s += " and Information.IDp like '%" + textBox1.Text + "%' and Patient.Name like '%" + textBox2.Text + "%'";
                }
                else
                {
                    s += " and Information.IDp like '%" + textBox1.Text + "%'";
                }
            }
            else
            {
                if (textBox2.Text != "")
                {
                    s += "and Patient.Name like '%" + textBox2.Text + "%'";
                }
            }
            
            s += " order by Date desc; ";
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillGridView1()
        {
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = SqlFlush();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteScalar() == null)
            {
                MessageBox.Show("查无此纪录！", "错误提示:");
                sql = "select Patient.IDp,Name,Phone,Addres,Date from Information,Patient where Information.IDp = Patient.IDp"
                    + " order by Date desc; ";
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

        private int DeleteByIDp(String IDnum)
        {
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = "delete from Information where IDnum ='" + IDnum + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int  rst = cmd.ExecuteNonQuery();

            conn.Close();
            return rst;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.Columns[e.ColumnIndex].GetType() == typeof(DataGridViewLinkColumn))
            {
                DialogResult RSS = MessageBox.Show(this, "确定要删除该行吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (RSS)
                {
                    case DialogResult.Yes:
                        String IDnum = (String)dataGridView1.Rows[e.RowIndex].Cells["IDnum"].Value;
                        String msg = "删除的行数:" + DeleteByIDp(IDnum);
                        MessageBox.Show(msg, "友情提示:");
                        FillGridView1();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
