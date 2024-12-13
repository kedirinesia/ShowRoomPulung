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
    public partial class ADMINMENU : Form
    {
        public ADMINMENU()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();  
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifikasiPembayaran vp = new VerifikasiPembayaran();
            vp.Show();
        }

        private void ADMINMENU_Load(object sender, EventArgs e)
        {
         
        }
    }
}
