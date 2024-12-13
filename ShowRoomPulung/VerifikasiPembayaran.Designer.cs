namespace ShowRoomPulung
{
    partial class VerifikasiPembayaran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMetodePembayaran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTopup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.showRoomPulungDataSet3 = new ShowRoomPulung.ShowRoomPulungDataSet3();
            this.showRoomPulungDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akunTableAdapter = new ShowRoomPulung.ShowRoomPulungDataSet3TableAdapters.akunTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomPulungDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomPulungDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.showRoomPulungDataSet3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(328, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "      Verifikasi Pembayaran     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(360, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "PULUNG SHOW ROOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InfoText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Daftar :";
            // 
            // txtMetodePembayaran
            // 
            this.txtMetodePembayaran.Enabled = false;
            this.txtMetodePembayaran.Location = new System.Drawing.Point(785, 205);
            this.txtMetodePembayaran.Name = "txtMetodePembayaran";
            this.txtMetodePembayaran.Size = new System.Drawing.Size(198, 20);
            this.txtMetodePembayaran.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Metode Pembayaran";
            // 
            // txtTopup
            // 
            this.txtTopup.Enabled = false;
            this.txtTopup.Location = new System.Drawing.Point(785, 179);
            this.txtTopup.Name = "txtTopup";
            this.txtTopup.Size = new System.Drawing.Size(198, 20);
            this.txtTopup.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Jumlah Topup";
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(785, 153);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(198, 20);
            this.txtNama.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "NAMA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 58);
            this.button1.TabIndex = 25;
            this.button1.Text = "Verifikasi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showRoomPulungDataSet3
            // 
            this.showRoomPulungDataSet3.DataSetName = "ShowRoomPulungDataSet3";
            this.showRoomPulungDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showRoomPulungDataSet3BindingSource
            // 
            this.showRoomPulungDataSet3BindingSource.DataSource = this.showRoomPulungDataSet3;
            this.showRoomPulungDataSet3BindingSource.Position = 0;
            // 
            // akunBindingSource
            // 
            this.akunBindingSource.DataMember = "akun";
            this.akunBindingSource.DataSource = this.showRoomPulungDataSet3BindingSource;
            // 
            // akunTableAdapter
            // 
            this.akunTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 139);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 228);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // VerifikasiPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 573);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMetodePembayaran);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTopup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerifikasiPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerifikasiPembayaran";
            this.Load += new System.EventHandler(this.VerifikasiPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomPulungDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showRoomPulungDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMetodePembayaran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTopup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource showRoomPulungDataSet3BindingSource;
        private ShowRoomPulungDataSet3 showRoomPulungDataSet3;
        private System.Windows.Forms.BindingSource akunBindingSource;
        private ShowRoomPulungDataSet3TableAdapters.akunTableAdapter akunTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}