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
    public partial class VerifikasiPembayaran : Form
    {
        string saldosaatini;
        public VerifikasiPembayaran()
        {
            InitializeComponent();
        }

        private void VerifikasiPembayaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'showRoomPulungDataSet3.akun' table. You can move, or remove it, as needed.
           // this.akunTableAdapter.Fill(this.showRoomPulungDataSet3.akun);
            DataTable dt = (DataTable)conn.getQuery("SELECT        dbo.Topup.nama, dbo.Topup.jumlahTopup , dbo.Topup.MetodePembayaran, dbo.akun.saldo as SaldoSaatIni \r\nFROM            dbo.Topup INNER JOIN\r\n                         dbo.akun ON dbo.Topup.nama = dbo.akun.nama");
            dataGridView2.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
//DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtNama.Text = row.Cells["nama"].Value.ToString();
            txtTopup.Text = row.Cells["jumlahTopup"].Value.ToString();
            txtMetodePembayaran.Text = row.Cells["MetodePembayaran"].Value.ToString();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //MessageBox.Show(total.ToString());
            if(txtNama.Text == "" && txtTopup.Text  == "" && txtMetodePembayaran.Text == "")
            {
                MessageBox.Show("PILIH AKUN YANG INGIN DI VERIFIKASI");
                return;
            }
            int total = int.Parse(txtTopup.Text) + int.Parse(saldosaatini);
            conn.exQuery("update akun set saldo = '"+total+"' where nama = '"+txtNama.Text+"'");
            conn.exQuery("delete from topup where nama = '"+txtNama.Text+"'");
            MessageBox.Show("berhasil melakukan verifikasi Topup  \n\nUser: " + txtNama.Text);
            DataTable dt = (DataTable)conn.getQuery("SELECT        dbo.Topup.nama, dbo.Topup.jumlahTopup , dbo.Topup.MetodePembayaran, dbo.akun.saldo as SaldoSaatIni \r\nFROM            dbo.Topup INNER JOIN\r\n                         dbo.akun ON dbo.Topup.nama = dbo.akun.nama");
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            txtNama.Text = row.Cells["nama"].Value.ToString();
            txtTopup.Text = row.Cells["jumlahTopup"].Value.ToString();
            txtMetodePembayaran.Text = row.Cells["MetodePembayaran"].Value.ToString();
             saldosaatini = row.Cells["SaldoSaatIni"].Value.ToString();
        }
    }
}
