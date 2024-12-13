using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRoomPulung
{
    public partial class Registrasi : Form
    {
        public Registrasi()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(pwtxt.Text == "" || usrtxt.Text== "")
            {
                MessageBox.Show("FIELD KOSONNGG!!!");
                return;
            }
            //SqlConnection con = conn.Getconn();
            //con.Open();
            //SqlCommand cmd = new SqlCommand("",con);
            //SqlDataReader rd = cmd.ExecuteReader();
            conn.exQuery("insert into akunCustomer (nama, password) values ('"+usrtxt.Text+"', '"+pwtxt.Text+"')");
            MessageBox.Show("berhasil melakukan Registrasi");
            MessageBox.Show("Silahkan melakukan login ulang");
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label5.Visible = false;
                btnLogin.Enabled = true;
               
            }
            else
            {
                btnLogin.Enabled=false;
                label5.Visible = true;

            }
        }

        private void Registrasi_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            SyaratDanKetentuan sk = new SyaratDanKetentuan();
            sk.Show();
        }
    }
}
