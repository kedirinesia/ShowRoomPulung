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
    public partial class TOPUP : Form
    {
      public  string usernames {  get; set; }
        string verif;
        public TOPUP()
        {
            InitializeComponent();
        }

        private void TOPUP_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(usernames);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = conn.Getconn();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from topup where nama = '"+usernames+"'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read()) {

                 verif = rd["nama"].ToString();
            
            }
            
            if(usernames == verif)
            {
                MessageBox.Show("masih ada transaksi pending", "!!!ERROR!!!");
                return;
            }


            conn.exQuery("insert into Topup values('"+usernames+"', '"+txttopup.Text+"', '"+comboBox1.Text+"')  ");
            MessageBox.Show("berhasil melakukan Topup, Silahkan Menunggu verifikasi dari admin");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
//            GOPAY
//DANA
//OVO
//SHOPEEPAY
//JAGO
            

            if (comboBox1.Text == "GOPAY") {

                txtNorek.Text = "08647182361";
            
            }
            if (comboBox1.Text == "DANA")
            {

                txtNorek.Text = "08187652142";

            }
            if (comboBox1.Text == "OVO")
            {

                txtNorek.Text = "088876516261";

            }
            if (comboBox1.Text == "SHOPEEPAY")
            {

                txtNorek.Text = "087827612342";

            }
            if (comboBox1.Text == "JAGO")
            {

                txtNorek.Text = "1109982734";

            }
        }
    }
}
