namespace ChineseMedicine
{
    partial class MassageShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassageShow));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menzhenDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menzhenDataSet = new ChineseMedicine.MenzhenDataSet2();
            this.addressBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menzhenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTableAdapter = new ChineseMedicine.MenzhenDataSet2TableAdapters.AddressTableAdapter();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter = new ChineseMedicine.MenzhenDataSet2TableAdapters.InformationTableAdapter();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new ChineseMedicine.MenzhenDataSet2TableAdapters.PatientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAddres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("宋体", 15F);
            this.label13.Location = new System.Drawing.Point(42, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 158;
            this.label13.Text = "医保卡号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(315, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 159;
            this.label1.Text = "姓名:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(528, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 179;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDnum,
            this.IDp,
            this.PName,
            this.PPhone,
            this.PAddres,
            this.PDate,
            this.Delete});
            this.dataGridView1.DataSource = this.menzhenDataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(893, 370);
            this.dataGridView1.TabIndex = 180;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menzhenDataSetBindingSource1
            // 
            this.menzhenDataSetBindingSource1.DataSource = this.menzhenDataSet;
            this.menzhenDataSetBindingSource1.Position = 0;
            // 
            // menzhenDataSet
            // 
            this.menzhenDataSet.DataSetName = "MenzhenDataSet";
            this.menzhenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingSource1
            // 
            this.addressBindingSource1.DataMember = "Address";
            this.addressBindingSource1.DataSource = this.menzhenDataSet;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.menzhenDataSetBindingSource;
            // 
            // menzhenDataSetBindingSource
            // 
            this.menzhenDataSetBindingSource.DataSource = this.menzhenDataSet;
            this.menzhenDataSetBindingSource.Position = 0;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.menzhenDataSetBindingSource;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.menzhenDataSetBindingSource;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.menzhenDataSetBindingSource;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(649, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 181;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(102, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 33);
            this.label2.TabIndex = 182;
            this.label2.Text = "杭州传承中医门诊部医药信息单管理";
            // 
            // IDnum
            // 
            this.IDnum.DataPropertyName = "IDnum";
            this.IDnum.HeaderText = "IDnum";
            this.IDnum.Name = "IDnum";
            // 
            // IDp
            // 
            this.IDp.DataPropertyName = "IDp";
            this.IDp.HeaderText = "医保卡号";
            this.IDp.Name = "IDp";
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "姓名";
            this.PName.Name = "PName";
            this.PName.Width = 80;
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
            this.PAddres.Width = 300;
            // 
            // PDate
            // 
            this.PDate.DataPropertyName = "Date";
            this.PDate.HeaderText = "日期";
            this.PDate.Name = "PDate";
            this.PDate.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "删除";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // MassageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MassageShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "医药信息单管理系统";
            this.Load += new System.EventHandler(this.MassageShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menzhenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource menzhenDataSetBindingSource;
        private MenzhenDataSet2 menzhenDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private MenzhenDataSet2TableAdapters.AddressTableAdapter addressTableAdapter;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private MenzhenDataSet2TableAdapters.InformationTableAdapter informationTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private MenzhenDataSet2TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource addressBindingSource1;
        private System.Windows.Forms.BindingSource menzhenDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAddres;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDate;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}