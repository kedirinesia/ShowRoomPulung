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
    public partial class Form1 : Form
    {
        public string username {  get; set; }
        public string saldo {  get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Registrasi reg = new Registrasi();
            reg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string usr= "";
            //string pwd = "";
            //if(usrtxt.Text==usr && pwtxt.Text == pwd)
            //{

            //}

            SqlConnection connection = conn.Getconn();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from akun where nama ='" + usrtxt.Text + "' and password= '" + pwtxt.Text + "' ", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                username = rd["nama"].ToString();
                saldo = rd["saldo"].ToString() ;
                string role = rd["role"].ToString();
                if (role == "admin")
                {
                    ADMINMENU adm = new ADMINMENU();    
                    adm.Show();
                    this.Hide();
                    return;
                }

                MainForm mainForm = new MainForm(); 
                mainForm.username= username;
                mainForm.saldo= saldo;
                mainForm.Show();    
                this.Hide();
            }
            else
            {
                MessageBox.Show("password atau username salah", "WARNING!!");
            }
        }
    }
}
