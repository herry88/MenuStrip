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
    public partial class FormPelanggan : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=cobasqlserver;Integrated Security=True;TrustServerCertificate=True"
        );

        public FormPelanggan()
        {
            InitializeComponent();
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            TampilData();
            DesainGrid();
            ClearForm();
        }

        private void TampilData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, nama, alamat, no_hp, created_at FROM Pelanggan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DesainGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            
            // Header Style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(142, 68, 173);
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
            txtId.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtNoHp.Clear();
            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || string.IsNullOrEmpty(txtNoHp.Text))
            {
                MessageBox.Show("Nama dan No HP harus diisi!");
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Pelanggan (nama, alamat, no_hp, created_at) VALUES (@nama, @alamat, @no_hp, @created_at)",
                    conn
                );
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("@no_hp", txtNoHp.Text);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show("Data Pelanggan berhasil disimpan");
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
                    "UPDATE Pelanggan SET nama=@nama, alamat=@alamat, no_hp=@no_hp WHERE id=@id",
                    conn
                );
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("@no_hp", txtNoHp.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Pelanggan berhasil diupdate");
                TampilData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Pelanggan WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Pelanggan berhasil dihapus");
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtNoHp.Text = row.Cells["no_hp"].Value.ToString();

                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
                btnHapus.Enabled = true;
            }
        }
    }
}
