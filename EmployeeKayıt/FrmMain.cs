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

namespace EmployeeKayıt
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6UVRS5K\\SQLEXPRESS;Initial Catalog=EmployeeInformation;Integrated Security=True");

        void temizle()
        {
            textBoxEmpid.Text = "";
            textBoxEmpName.Text = "";
            textBoxEmpLastname.Text = "";
            comboBoxEmpCity.Text = "";
            maskedTextBoxEmpSaları.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBoxEmpJob.Text = "";
            textBoxEmpName.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeInformationDataSet.Tbl_Employee' table. You can move, or remove it, as needed.
            this.tbl_EmployeeTableAdapter.Fill(this.employeeInformationDataSet.Tbl_Employee);

        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            this.tbl_EmployeeTableAdapter.Fill(this.employeeInformationDataSet.Tbl_Employee);
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Employee (Empname,Emplastname,Empcity,Empsalary,Empjob,Empsituation) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",textBoxEmpName.Text);
            komut.Parameters.AddWithValue("@p2",textBoxEmpLastname.Text);
            komut.Parameters.AddWithValue("@p3",comboBoxEmpCity.Text);
            komut.Parameters.AddWithValue("@p4",maskedTextBoxEmpSaları.Text);
            komut.Parameters.AddWithValue("@p5",textBoxEmpJob.Text);
            komut.Parameters.AddWithValue("@p6",label8.Text);
            komut.ExecuteNonQuery();// ekleme silme ve güncellemede sql komutunu çalıştırmak için kullanılır
            baglanti.Close();
            MessageBox.Show("Employee added");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            textBoxEmpid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();  
            textBoxEmpName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxEmpLastname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxEmpCity.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxEmpSaları.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBoxEmpJob.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Employee where Empid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", textBoxEmpid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Employee deleted!");
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Employee Set Empname=@a1, Emplastname=@a2, Empcity=@a3, Empsalary=@a4, Empsituation=@a5, Empjob=@a6 where Empid=@a7",baglanti);
            komutguncelle.Parameters.AddWithValue("@a1",textBoxEmpName.Text);
            komutguncelle.Parameters.AddWithValue("@a2",textBoxEmpLastname.Text);
            komutguncelle.Parameters.AddWithValue("@a3",comboBoxEmpCity.Text);
            komutguncelle.Parameters.AddWithValue("@a4",maskedTextBoxEmpSaları.Text);
            komutguncelle.Parameters.AddWithValue("@a5",label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6",textBoxEmpJob.Text);
            komutguncelle.Parameters.AddWithValue("@a7",textBoxEmpid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Employee uptaded");
        }

        private void buttonIstatistik_Click(object sender, EventArgs e)
        {
            FrmStatistic fr = new FrmStatistic();
            fr.Show();
        }

        private void buttonGrafikler_Click(object sender, EventArgs e)
        {
            FrmChart frc = new FrmChart();
            frc.Show();
        }
    }
}
