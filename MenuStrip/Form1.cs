namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Activated += Form1_Activated;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            UpdateDashboardStats();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
            lblStatus.Text = "Membuka Form Barang...";
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPelanggan formPelanggan = new FormPelanggan();
            formPelanggan.Show();
            lblStatus.Text = "Membuka Form Pelanggan...";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?",
                                                   "Konfirmasi Keluar",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesainMenu();
            UpdateDashboardStats();
            lblStatus.Text = "Dashboard Siap - " + DateTime.Now.ToLongDateString();
        }

        private void UpdateDashboardStats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=cobasqlserver;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // Count Barang
                    SqlCommand cmdBarang = new SqlCommand("SELECT COUNT(*) FROM Barang", conn);
                    int countBarang = (int)cmdBarang.ExecuteScalar();
                    lblCountBarang.Text = countBarang.ToString();

                    // Count Pelanggan
                    SqlCommand cmdPelanggan = new SqlCommand("SELECT COUNT(*) FROM Pelanggan", conn);
                    int countPelanggan = (int)cmdPelanggan.ExecuteScalar();
                    lblCountPelanggan.Text = countPelanggan.ToString();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // Jika database belum siap, tampilkan 0
                lblCountBarang.Text = "0";
                lblCountPelanggan.Text = "0";
                lblStatus.Text = "Gagal memuat statistik: " + ex.Message;
            }
            
            pnlCardBarang.Cursor = Cursors.Hand;
            pnlCardPelanggan.Cursor = Cursors.Hand;
        }

        private void DesainMenu()
        {
            // Form Setup
            this.Text = "Inventory Pro - Dashboard";
            this.BackColor = Color.FromArgb(240, 243, 247);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9.5f);

            // MenuStrip Styling
            menuStrip1.Renderer = new CustomRenderer();
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10);
            menuStrip1.Padding = new Padding(10, 2, 0, 2);

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.White;
                // Sub-menu styling
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    subItem.ForeColor = Color.White;
                    subItem.Font = new Font("Segoe UI", 10);
                }
            }

            // StatusStrip Styling
            statusStrip1.BackColor = Color.FromArgb(230, 233, 237);
            lblStatus.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
