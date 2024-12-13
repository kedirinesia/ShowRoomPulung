using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRoomPulung.PHOTO
{
    public partial class BeliMobil : Form
    {
        public BeliMobil()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox2.Text == "A-Z")
            {
                DataTable dts = (DataTable)conn.getQuery("select * from BeliMobil where tipe = '" + comboBox1.Text + "'order by nama asc");
                dataGridView1.DataSource = dts;

            }
            else if(comboBox2.Text == "Z-A")
            {
                DataTable dtss = (DataTable)conn.getQuery("select * from BeliMobil where tipe = '" + comboBox1.Text + "' order by nama desc");
                dataGridView1.DataSource = dtss;
            }
            DataTable dt = (DataTable)conn.getQuery("select * from BeliMobil where tipe = '" + comboBox1.Text+"'");
            dataGridView1.DataSource = dt;






            if(comboBox1.Text == "all" )
            {
                DataTable dts = (DataTable)conn.getQuery("select * from BeliMobil");
                dataGridView1.DataSource = dts;
            }
            if (comboBox1.Text == "all" && comboBox2.Text == "A-Z")
            {
                DataTable dts = (DataTable)conn.getQuery("select * from BeliMobil order by nama asc");
                dataGridView1.DataSource = dts;
            }
            if (comboBox1.Text == "all" && comboBox2.Text == "Z-A")
            {
                DataTable dts = (DataTable)conn.getQuery("select * from BeliMobil order by nama desc");
                dataGridView1.DataSource = dts;
            }
 
        }

        private void BeliMobil_Load(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)conn.getQuery("select * from belimobil");
            dataGridView1.DataSource = dt;
            // TODO: This line of code loads data into the 'showRoomPulungDataSet1.BeliMobil' table. You can move, or remove it, as needed.
            this.beliMobilTableAdapter.Fill(this.showRoomPulungDataSet1.BeliMobil);

            SqlConnection con = conn.Getconn();
            con.Open();
            SqlCommand cmd = new SqlCommand("select DISTINCT tipe from BeliMobil", con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["tipe"].ToString());
            }
            rd.Close(); 
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Visible = true;
            //string nama = txtNama.Text;
            //string harga = txtHarga.Text;
            //string tipe = txtTipe.Text;
            //string release = txtRelease.Text;
            //string dokumen = txtDokumen.Text;
            //string kilometer = txtKilometer.Text;
  
         //   DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; 
         DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtNama.Text = row.Cells["Nama"].Value.ToString();
            txtHarga.Text = row.Cells["Harga"].Value.ToString();
            txtTipe.Text = row.Cells["tipe"].Value.ToString();
            txtRelease.Text = row.Cells["Release"].Value.ToString();
            txtDokumen.Text = row.Cells["Dokumen"].Value.ToString();
            txtKilometer.Text = row.Cells["Kilometer"].Value.ToString();
           // var imageData = row.Cells["Gambar"].Value;
           btnBeli.Visible= true;
           


            pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])row.Cells["gambar"].Value));
          



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "all")
            {



                if (comboBox2.Text == "A-Z")
                {
                    DataTable dt = (DataTable)conn.getQuery("SELECT * FROM BeliMobil where tipe = '" + comboBox1.Text + "'   ORDER BY Nama ASC");
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox2.Text == "Z-A")
                {

                    DataTable dt = (DataTable)conn.getQuery("SELECT * FROM BeliMobil where tipe = '" + comboBox1.Text + "'   ORDER BY Nama DESC");
                    dataGridView1.DataSource = dt;
                }

            }
            else if (comboBox2.Text == "A-Z")
            {
                DataTable dt = (DataTable)conn.getQuery("SELECT * FROM BeliMobil order by nama asc  ");
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.Text == "Z-A")
            {
                DataTable dt = (DataTable)conn.getQuery("SELECT * FROM BeliMobil order by nama desc  ");
                dataGridView1.DataSource = dt;
            }
            else {
                MessageBox.Show("ERROR");
                this.Close();
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.Show();
        }
    }
}
