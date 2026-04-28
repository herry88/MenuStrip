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

        private void FormBarang_Load(object sender, EventArgs e)
        {
            TampilData();
            DesainUI();
            ClearForm();
        }

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

        private void DesainUI()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9.5f);
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            
            // Header Style - Blue matching Dashboard
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 35;

            // Cell Style
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
        }

        private void ClearForm()
        {
            txtIdbarang.Clear();
            txtNamaBarang.Clear();
            txtHarga.Clear();
            txtStock.Clear();
            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamaBarang.Text) || string.IsNullOrEmpty(txtHarga.Text))
            {
                MessageBox.Show("Nama Barang dan Harga harus diisi!");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Barang (NamaBarang, Harga, Stok) VALUES (@nama, @harga, @stok)",
                    conn
                );
                cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@stok", txtStock.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show("Data Barang berhasil disimpan");
                TampilData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Barang SET NamaBarang=@nama, Harga=@harga, Stok=@stok WHERE IdBarang=@id",
                    conn
                );
                cmd.Parameters.AddWithValue("@id", txtIdbarang.Text);
                cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@stok", txtStock.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Barang berhasil diupdate");
                TampilData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Barang WHERE IdBarang=@id", conn);
                    cmd.Parameters.AddWithValue("@id", txtIdbarang.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Barang berhasil dihapus");
                    TampilData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    conn.Close();
                }
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            ClearForm();
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

                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
            }
        }
    }
}
