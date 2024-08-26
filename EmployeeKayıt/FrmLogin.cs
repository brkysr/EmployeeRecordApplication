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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6UVRS5K\\SQLEXPRESS;Initial Catalog=EmployeeInformation;Integrated Security=True");
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Admin where Username = @p1 and Password = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1",textBox1username.Text);
            komut.Parameters.AddWithValue("@p2",textBox2password.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmMain frm = new FrmMain();
                frm.Show();
                this.Hide();//bu formu gizle
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            baglanti.Close();
        }
    }
}
