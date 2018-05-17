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
using System.Threading;

namespace ChineseMedicine
{
    public partial class PatientShow : Form
    {
        public PatientShow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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

            String sql = "select Patient.IDp, IDa, Name, Gender, birthdate, Phone, Addres from Address,Patient where Address.IDp " +
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
            dataGridView1.Columns["IDa"].Visible = false;
            dataGridView1.Columns["IDp"].DisplayIndex = 0;
            dataGridView1.Columns["PName"].DisplayIndex = 1;
            dataGridView1.Columns["Gender"].DisplayIndex = 2;
            dataGridView1.Columns["BirthDate"].DisplayIndex = 3;
            dataGridView1.Columns["PPhone"].DisplayIndex = 4;
            dataGridView1.Columns["PAddres"].DisplayIndex = 5;
            dataGridView1.Columns["DeleteRow"].DisplayIndex = 6;
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
                //MessageBox.Show("查询成功！", "友情提示:");
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.AutoGenerateColumns = true;

            //gridview单元格内容居中
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            conn.Close();
        }

        protected String SqlFlush()
        {
            String s = "select Patient.IDp, IDa, Name, Gender, birthdate, Phone, Addres from Address,Patient where Address.IDp = Patient.IDp";

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

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //MessageBox.Show("开始编辑");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String IDa = (String)dataGridView1.Rows[e.RowIndex].Cells["IDa"].Value;
            String IDp = (String)dataGridView1.Rows[e.RowIndex].Cells["IDp"].Value;
            String PName = (String)dataGridView1.Rows[e.RowIndex].Cells["PName"].Value;
            String Gender = (String)dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value;
            String BirthDate = ((DateTime)dataGridView1.Rows[e.RowIndex].Cells["BirthDate"].Value).ToString("yyyy-MM-dd");
            String PPhone = (String)dataGridView1.Rows[e.RowIndex].Cells["PPhone"].Value;
            String PAdress = (String)dataGridView1.Rows[e.RowIndex].Cells["PAddres"].Value;

            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = String.Format("update Patient set Name = '{1}', Gender = '{2}', Phone = '{3}', BirthDate = '{4}' where IDp = '{0}'", IDp, PName, Gender, PPhone, BirthDate);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = String.Format("update Address set Addres = '{0}' where IDa = '{1}'", PAdress, IDa);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            //重新加载GridView
            //sql = "select Patient.IDp, IDa, Name, Gender, birthdate, Phone, Addres from Address,Patient where Address.IDp " +
            //    " = Patient.IDp order by Patient.IDp asc; ";
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoGenerateColumns = true;

            ////gridview单元格内容居中
            //foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            //{
            //    item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}
            //dataGridView1.Columns["IDa"].Visible = false;
            //dataGridView1.Columns["IDp"].DisplayIndex = 0;
            //dataGridView1.Columns["PName"].DisplayIndex = 1;
            //dataGridView1.Columns["Gender"].DisplayIndex = 2;
            //dataGridView1.Columns["BirthDate"].DisplayIndex = 3;
            //dataGridView1.Columns["PPhone"].DisplayIndex = 4;
            //dataGridView1.Columns["PAddres"].DisplayIndex = 5;
            //dataGridView1.Columns["DeleteRow"].DisplayIndex = 6;

            conn.Close();
            MessageBox.Show("修改成功");
            Thread th = new Thread(ThreadSendKey);
            th.Start(this);
        }
        private int DeleteByIDp(String IDp)
        {
            String connstr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            String sql = "delete from Information where IDp ='" + IDp + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rst = cmd.ExecuteNonQuery();

            sql = "delete from Address where IDp ='" + IDp + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            sql = "delete from Patient where IDp ='" + IDp + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

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
                        String IDp = (String)dataGridView1.Rows[e.RowIndex].Cells["IDp"].Value;
                        //String msg = "删除的行数:" + DeleteByIDp(IDp);
                        DeleteByIDp(IDp);
                        MessageBox.Show("已删除", "友情提示:");
                        button2_Click(null, null);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
        private static void ThreadSendKey(object o)
        {
            Thread.Sleep(1000);
            PatientShow ps = (PatientShow)o;
            ps.button2_Click(null, null);
        }
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1_CellEndEdit(sender, e);
        }

        private void PatientShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dataGridView1_CellEndEdit(sender, e);
        }
    }
}
