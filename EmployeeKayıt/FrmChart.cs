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
    public partial class FrmChart : Form
    {
        public FrmChart()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6UVRS5K\\SQLEXPRESS;Initial Catalog=EmployeeInformation;Integrated Security=True");
        private void FrmChart_Load(object sender, EventArgs e)
        {
            //aynı şehirde bulunan çalışan sayısı
            baglanti.Open();
            SqlCommand komutc1 = new SqlCommand("Select Empcity, Count(*) from Tbl_Employee group by Empcity",baglanti);
            SqlDataReader dr1 = komutc1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            //mesleklere göre maaş ortalamaları
            baglanti.Open();
            SqlCommand komutc2 = new SqlCommand("Select Empjob, AVG(Empsalary) from Tbl_Employee group by Empjob",baglanti);
            SqlDataReader dr2 = komutc2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Job-SalaryAvg"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();


        }
    }
}
