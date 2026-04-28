namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Show();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPelanggan formPelanggan = new FormPelanggan();
            formPelanggan.Show();
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
        }

        private void DesainMenu()
        {
            this.Text = "Aplikasi Data Barang";
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            menuStrip1.Padding = new Padding(10, 5, 0, 5);

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.White;
                item.BackColor = Color.FromArgb(30, 30, 30);

                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    subItem.ForeColor = Color.White;
                    subItem.BackColor = Color.FromArgb(45, 45, 48);
                    subItem.Font = new Font("Segoe UI", 10);
                }
            }
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }

        }
}
