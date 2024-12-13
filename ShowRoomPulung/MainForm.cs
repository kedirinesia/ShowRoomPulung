using ShowRoomPulung.PHOTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRoomPulung
{
    public partial class MainForm : Form
    {
        public string username { get; set; }
        public string saldo { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show(username);
            lblUser.Text = username;
            lblSaldo.Text = saldo;
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            JAM.Text = "JAM : "+ DateTime.Now.ToString("HH:mm:ss" + " WIB");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BeliMobil beliMobil = new BeliMobil();  
            beliMobil.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            JualMobil jualMobil = new JualMobil();  
            jualMobil.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SewaMobil sewaMobil = new SewaMobil();  
            sewaMobil.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            RekomendasiMobil rekomendasiMobil = new RekomendasiMobil(); 
            rekomendasiMobil.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ServiceMobil serviceMobil = new ServiceMobil(); 
            serviceMobil.Show();    
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 a = new Form1();
            a.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            TOPUP t = new TOPUP();
            t.usernames = username;
            t.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TOPUP t = new TOPUP();
            t.usernames = username;
            t.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerService.Show();
        }
    }
}
