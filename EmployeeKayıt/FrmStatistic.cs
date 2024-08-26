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
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6UVRS5K\\SQLEXPRESS;Initial Catalog=EmployeeInformation;Integrated Security=True");

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            //Toplam çalışan sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Employee",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                labelsumEmp.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //evli personel sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Employee where Empsituation = 1",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                labelmarried.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar personel sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Employee where Empsituation = 0",baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                labelsingle.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //farklı şehir sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct (Empcity)) from Tbl_Employee",baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                labelcitynumber.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //toplam maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Empsalary) from Tbl_Employee",baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                labelsumsalary.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //ortalama maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(Empsalary) from Tbl_Employee",baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                labelavgsalary.Text = dr6[0].ToString();
            }
            baglanti.Close();


        }
    }
}
