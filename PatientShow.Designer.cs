namespace ChineseMedicine
{
    partial class PatientShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientShow));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRow = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAddres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menzhenDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menzhenDataSet2 = new ChineseMedicine.MenzhenDataSet2();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menzhenDataSet1 = new ChineseMedicine.MenzhenDataSet2();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new ChineseMedicine.MenzhenDataSet2TableAdapters.PatientTableAdapter();
            this.menzhenDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menzhenDataSet = new ChineseMedicine.MenzhenDataSet2();
            this.menzhenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter1 = new ChineseMedicine.MenzhenDataSet2TableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(92, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 33);
            this.label2.TabIndex = 183;
            this.label2.Text = "杭州传承中医门诊部患者信息管理系统";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(649, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 190;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDp,
            this.DeleteRow,
            this.IDa,
            this.PName,
            this.Gender,
            this.BirthDate,
            this.PPhone,
            this.PAddres});
            this.dataGridView1.DataSource = this.menzhenDataSet2BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(30, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(855, 367);
            this.dataGridView1.TabIndex = 189;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            // 
            // IDp
            // 
            this.IDp.DataPropertyName = "IDp";
            this.IDp.HeaderText = "医保卡号";
            this.IDp.Name = "IDp";
            // 
            // DeleteRow
            // 
            this.DeleteRow.HeaderText = "";
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Text = "删除";
            this.DeleteRow.UseColumnTextForLinkValue = true;
            // 
            // IDa
            // 
            this.IDa.DataPropertyName = "IDa";
            this.IDa.HeaderText = "IDa";
            this.IDa.Name = "IDa";
            this.IDa.Visible = false;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "姓名";
            this.PName.Name = "PName";
            this.PName.Width = 80;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.Width = 80;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "出生日期";
            this.BirthDate.Name = "BirthDate";
            // 
            // PPhone
            // 
            this.PPhone.DataPropertyName = "Phone";
            this.PPhone.HeaderText = "联系方式";
            this.PPhone.Name = "PPhone";
            // 
            // PAddres
            // 
            this.PAddres.DataPropertyName = "Addres";
            this.PAddres.HeaderText = "住址";
            this.PAddres.Name = "PAddres";
            this.PAddres.Width = 240;
            // 
            // menzhenDataSet2BindingSource1
            // 
            this.menzhenDataSet2BindingSource1.DataSource = this.menzhenDataSet2;
            this.menzhenDataSet2BindingSource1.Position = 0;
            // 
            // menzhenDataSet2
            // 
            this.menzhenDataSet2.DataSetName = "MenzhenDataSet2";
            this.menzhenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.menzhenDataSet2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(536, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 188;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(323, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 187;
            this.label1.Text = "姓名:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("宋体", 15F);
            this.label13.Location = new System.Drawing.Point(57, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 186;
            this.label13.Text = "医保卡号:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 185;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 21);
            this.textBox1.TabIndex = 184;
            // 
            // menzhenDataSet1
            // 
            this.menzhenDataSet1.DataSetName = "MenzhenDataSet2";
            this.menzhenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.menzhenDataSet1;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // menzhenDataSet2BindingSource
            // 
            this.menzhenDataSet2BindingSource.DataSource = this.menzhenDataSet2;
            this.menzhenDataSet2BindingSource.Position = 0;
            // 
            // menzhenDataSet
            // 
            this.menzhenDataSet.DataSetName = "MenzhenDataSet";
            this.menzhenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menzhenDataSetBindingSource
            // 
            this.menzhenDataSetBindingSource.DataSource = this.menzhenDataSet;
            this.menzhenDataSetBindingSource.Position = 0;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // PatientShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "杭州传承中医门诊部患者信息管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientShow_FormClosing);
            this.Load += new System.EventHandler(this.PatientShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MenzhenDataSet2 menzhenDataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private MenzhenDataSet2TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource menzhenDataSetBindingSource;
        private MenzhenDataSet2 menzhenDataSet;
        private MenzhenDataSet2 menzhenDataSet2;
        private System.Windows.Forms.BindingSource menzhenDataSet2BindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private MenzhenDataSet2TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource menzhenDataSet2BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDp;
        private System.Windows.Forms.DataGridViewLinkColumn DeleteRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAddres;
    }
}