namespace MenuStrip
{
    partial class FormBarang
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
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtIdbarang = new TextBox();
            txtNamaBarang = new TextBox();
            label2 = new Label();
            txtHarga = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnBatal = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(882, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(12, 12);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(167, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Data Barang";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(340, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 450);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 80);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 2;
            label1.Text = "ID Barang";
            // 
            // txtIdbarang
            // 
            txtIdbarang.BackColor = Color.FromArgb(236, 240, 241);
            txtIdbarang.BorderStyle = BorderStyle.FixedSingle;
            txtIdbarang.Location = new Point(20, 106);
            txtIdbarang.Name = "txtIdbarang";
            txtIdbarang.ReadOnly = true;
            txtIdbarang.Size = new Size(300, 27);
            txtIdbarang.TabIndex = 3;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.BorderStyle = BorderStyle.FixedSingle;
            txtNamaBarang.Location = new Point(20, 166);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(300, 27);
            txtNamaBarang.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 140);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 4;
            label2.Text = "Nama Barang";
            // 
            // txtHarga
            // 
            txtHarga.BorderStyle = BorderStyle.FixedSingle;
            txtHarga.Location = new Point(20, 226);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(300, 27);
            txtHarga.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 200);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 6;
            label3.Text = "Harga";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(20, 286);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(300, 27);
            txtStock.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 260);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 8;
            label4.Text = "Stock";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(46, 204, 113);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI Semibold", 10F);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(20, 340);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(300, 40);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan Data";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 10F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(20, 386);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 40);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(231, 76, 60);
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI Semibold", 10F);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(175, 386);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(145, 40);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnDelete_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(149, 165, 166);
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI Semibold", 10F);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(20, 432);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(300, 40);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal / Clear";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnTutup_Click;
            // 
            // FormBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(btnBatal);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtHarga);
            Controls.Add(label3);
            Controls.Add(txtNamaBarang);
            Controls.Add(label2);
            Controls.Add(txtIdbarang);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pnlHeader);
            Name = "FormBarang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manajemen Barang";
            Load += FormBarang_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtIdbarang;
        private TextBox txtNamaBarang;
        private Label label2;
        private TextBox txtHarga;
        private Label label3;
        private TextBox txtStock;
        private Label label4;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnBatal;
    }
}