using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MenuStrip
{
    public partial class FormBarang : Form
    {
        //connection string database
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=cobasqlserver;Integrated Security=True;TrustServerCertificate=True"
        );

        public FormBarang()
        {
            InitializeComponent();
        }

        //tampil data 
        private void TampilData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Barang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtNamaBarang.Text = "";
            txtHarga.Text = "";
            txtStock.Text = "";
        }

        //setEnable
        private void SetEnable(bool status)
        {
            txtNamaBarang.Enabled = status;
            txtHarga.Enabled = status;
            txtStock.Enabled = status;
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            TampilData();
            ClearForm();
            DesainUI();
            txtIdbarang.ReadOnly = true;

        }
        private void DesainUI()
        {
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.RowTemplate.Height = 30;

            btnSimpan.BackColor = Color.SeaGreen;
            btnSimpan.ForeColor = Color.White;

            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.ForeColor = Color.White;

            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = Color.White;

            btnTutup.BackColor = Color.Gray;
            btnTutup.ForeColor = Color.White;

            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnTutup.FlatStyle = FlatStyle.Flat;
        }

        //tombol simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text == "" || txtHarga.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
                return;
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Barang (NamaBarang, Harga, Stok) VALUES (@namaBarang, @harga, @stock)",
                    conn
                );

                //deklarasi form 
                cmd.Parameters.AddWithValue("@namaBarang", txtNamaBarang.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@stock", txtStock.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Berhasil Disimpan");


                TampilData();//refresh data

                ClearForm(); //clear form

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menutup form?",
                                                  "Konfirmasi Tutup",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question
                                                  );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtIdbarang.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diupdate!");
                return;
            }

            if (txtNamaBarang.Text == "" || txtHarga.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Data belum lengkap!");
                return;
            }

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Barang SET NamaBarang=@namaBarang, Harga=@harga, Stok=@stock WHERE IdBarang=@idBarang",
                    conn
                );

                cmd.Parameters.AddWithValue("@idBarang", txtIdbarang.Text);
                cmd.Parameters.AddWithValue("@namaBarang", txtNamaBarang.Text);
                cmd.Parameters.AddWithValue("@harga", int.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diupdate");

                TampilData();
                ClearForm();
                SetEnable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIdbarang.Text = row.Cells["IdBarang"].Value.ToString();
                txtNamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
                txtHarga.Text = row.Cells["Harga"].Value.ToString();
                txtStock.Text = row.Cells["Stok"].Value.ToString();

                SetEnable(true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdbarang.Text == "")
            {
                MessageBox.Show("Pilih Data Yang Akan Di Hapus");
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                                  "Konfirmasi Hapus",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question
                                                  );
            if (result == DialogResult.No)
            {
                return;
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Barang WHERE IdBarang=@idBarang",
                    conn
                );

                cmd.Parameters.AddWithValue("@idBarang", txtIdbarang.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Berhasil Dihapus");
                TampilData();
                ClearForm();
                SetEnable(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }
    }
}
