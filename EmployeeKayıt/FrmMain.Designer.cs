namespace EmployeeKayıt
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxEmpSaları = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEmpCity = new System.Windows.Forms.ComboBox();
            this.textBoxEmpJob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmpLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmpid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGrafikler = new System.Windows.Forms.Button();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empsituationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empjobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeInformationDataSet = new EmployeeKayıt.EmployeeInformationDataSet();
            this.tbl_EmployeeTableAdapter = new EmployeeKayıt.EmployeeInformationDataSetTableAdapters.Tbl_EmployeeTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxEmpSaları);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxEmpCity);
            this.groupBox1.Controls.Add(this.textBoxEmpJob);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEmpLastname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmpName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEmpid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Record";
            // 
            // maskedTextBoxEmpSaları
            // 
            this.maskedTextBoxEmpSaları.Location = new System.Drawing.Point(136, 133);
            this.maskedTextBoxEmpSaları.Mask = "00000";
            this.maskedTextBoxEmpSaları.Name = "maskedTextBoxEmpSaları";
            this.maskedTextBoxEmpSaları.Size = new System.Drawing.Size(52, 24);
            this.maskedTextBoxEmpSaları.TabIndex = 5;
            this.maskedTextBoxEmpSaları.ValidatingType = typeof(int);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(231, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 22);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Employee job:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(149, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Married";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee situation:";
            // 
            // comboBoxEmpCity
            // 
            this.comboBoxEmpCity.FormattingEnabled = true;
            this.comboBoxEmpCity.Location = new System.Drawing.Point(119, 104);
            this.comboBoxEmpCity.Name = "comboBoxEmpCity";
            this.comboBoxEmpCity.Size = new System.Drawing.Size(121, 26);
            this.comboBoxEmpCity.TabIndex = 4;
            // 
            // textBoxEmpJob
            // 
            this.textBoxEmpJob.Location = new System.Drawing.Point(142, 190);
            this.textBoxEmpJob.Name = "textBoxEmpJob";
            this.textBoxEmpJob.Size = new System.Drawing.Size(100, 24);
            this.textBoxEmpJob.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee city:";
            // 
            // textBoxEmpLastname
            // 
            this.textBoxEmpLastname.Location = new System.Drawing.Point(149, 76);
            this.textBoxEmpLastname.Name = "textBoxEmpLastname";
            this.textBoxEmpLastname.Size = new System.Drawing.Size(100, 24);
            this.textBoxEmpLastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee lastname:";
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(125, 49);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(100, 24);
            this.textBoxEmpName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee name:";
            // 
            // textBoxEmpid
            // 
            this.textBoxEmpid.Location = new System.Drawing.Point(108, 19);
            this.textBoxEmpid.Name = "textBoxEmpid";
            this.textBoxEmpid.Size = new System.Drawing.Size(100, 24);
            this.textBoxEmpid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGrafikler);
            this.groupBox2.Controls.Add(this.buttonIstatistik);
            this.groupBox2.Controls.Add(this.buttonTemizle);
            this.groupBox2.Controls.Add(this.buttonGuncelle);
            this.groupBox2.Controls.Add(this.buttonSil);
            this.groupBox2.Controls.Add(this.buttonKaydet);
            this.groupBox2.Controls.Add(this.buttonListele);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // buttonGrafikler
            // 
            this.buttonGrafikler.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGrafikler.Location = new System.Drawing.Point(190, 102);
            this.buttonGrafikler.Name = "buttonGrafikler";
            this.buttonGrafikler.Size = new System.Drawing.Size(120, 34);
            this.buttonGrafikler.TabIndex = 6;
            this.buttonGrafikler.Text = "Charts";
            this.buttonGrafikler.UseVisualStyleBackColor = true;
            this.buttonGrafikler.Click += new System.EventHandler(this.buttonGrafikler_Click);
            // 
            // buttonIstatistik
            // 
            this.buttonIstatistik.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIstatistik.Location = new System.Drawing.Point(190, 63);
            this.buttonIstatistik.Name = "buttonIstatistik";
            this.buttonIstatistik.Size = new System.Drawing.Size(120, 34);
            this.buttonIstatistik.TabIndex = 5;
            this.buttonIstatistik.Text = "Statistics";
            this.buttonIstatistik.UseVisualStyleBackColor = true;
            this.buttonIstatistik.Click += new System.EventHandler(this.buttonIstatistik_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.Location = new System.Drawing.Point(36, 178);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(99, 30);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Clear";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(36, 142);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(99, 30);
            this.buttonGuncelle.TabIndex = 3;
            this.buttonGuncelle.Text = "Update";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(36, 103);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(99, 33);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Delete";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(36, 63);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(99, 34);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = "Save";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(36, 23);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(99, 34);
            this.buttonListele.TabIndex = 0;
            this.buttonListele.Text = "List";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(3, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(749, 282);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.emplastnameDataGridViewTextBoxColumn,
            this.empcityDataGridViewTextBoxColumn,
            this.empsalaryDataGridViewTextBoxColumn,
            this.empsituationDataGridViewCheckBoxColumn,
            this.empjobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Empid";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Empid";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "Empname";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Empname";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            // 
            // emplastnameDataGridViewTextBoxColumn
            // 
            this.emplastnameDataGridViewTextBoxColumn.DataPropertyName = "Emplastname";
            this.emplastnameDataGridViewTextBoxColumn.HeaderText = "Emplastname";
            this.emplastnameDataGridViewTextBoxColumn.Name = "emplastnameDataGridViewTextBoxColumn";
            // 
            // empcityDataGridViewTextBoxColumn
            // 
            this.empcityDataGridViewTextBoxColumn.DataPropertyName = "Empcity";
            this.empcityDataGridViewTextBoxColumn.HeaderText = "Empcity";
            this.empcityDataGridViewTextBoxColumn.Name = "empcityDataGridViewTextBoxColumn";
            // 
            // empsalaryDataGridViewTextBoxColumn
            // 
            this.empsalaryDataGridViewTextBoxColumn.DataPropertyName = "Empsalary";
            this.empsalaryDataGridViewTextBoxColumn.HeaderText = "Empsalary";
            this.empsalaryDataGridViewTextBoxColumn.Name = "empsalaryDataGridViewTextBoxColumn";
            // 
            // empsituationDataGridViewCheckBoxColumn
            // 
            this.empsituationDataGridViewCheckBoxColumn.DataPropertyName = "Empsituation";
            this.empsituationDataGridViewCheckBoxColumn.HeaderText = "Empsituation";
            this.empsituationDataGridViewCheckBoxColumn.Name = "empsituationDataGridViewCheckBoxColumn";
            // 
            // empjobDataGridViewTextBoxColumn
            // 
            this.empjobDataGridViewTextBoxColumn.DataPropertyName = "Empjob";
            this.empjobDataGridViewTextBoxColumn.HeaderText = "Empjob";
            this.empjobDataGridViewTextBoxColumn.Name = "empjobDataGridViewTextBoxColumn";
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "Tbl_Employee";
            this.tblEmployeeBindingSource.DataSource = this.employeeInformationDataSet;
            // 
            // employeeInformationDataSet
            // 
            this.employeeInformationDataSet.DataSetName = "EmployeeInformationDataSet";
            this.employeeInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_EmployeeTableAdapter
            // 
            this.tbl_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "False\r\n";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(762, 528);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmpSaları;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEmpCity;
        private System.Windows.Forms.TextBox textBoxEmpJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmpLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGrafikler;
        private System.Windows.Forms.Button buttonIstatistik;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeeInformationDataSet employeeInformationDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private EmployeeInformationDataSetTableAdapters.Tbl_EmployeeTableAdapter tbl_EmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn empsituationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empjobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

