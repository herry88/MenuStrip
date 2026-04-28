namespace MenuStrip
{
    partial class FormPelanggan
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
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtNama = new TextBox();
            label2 = new Label();
            txtAlamat = new TextBox();
            label3 = new Label();
            txtNoHp = new TextBox();
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
            pnlHeader.BackColor = Color.FromArgb(142, 68, 173);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(882, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Data Pelanggan";
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
            label1.Size = new Size(27, 23);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(236, 240, 241);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(20, 106);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(300, 27);
            txtId.TabIndex = 3;
            // 
            // txtNama
            // 
            txtNama.BorderStyle = BorderStyle.FixedSingle;
            txtNama.Location = new Point(20, 166);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(300, 27);
            txtNama.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 140);
            label2.Name = "label2";
            label2.Size = new Size(141, 23);
            label2.TabIndex = 4;
            label2.Text = "Nama Pelanggan";
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.FixedSingle;
            txtAlamat.Location = new Point(20, 226);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(300, 60);
            txtAlamat.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 200);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 6;
            label3.Text = "Alamat";
            // 
            // txtNoHp
            // 
            txtNoHp.BorderStyle = BorderStyle.FixedSingle;
            txtNoHp.Location = new Point(20, 316);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(300, 27);
            txtNoHp.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 290);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 8;
            label4.Text = "No HP";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(46, 204, 113);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI Semibold", 10F);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(20, 360);
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
            btnEdit.Location = new Point(20, 406);
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
            btnHapus.Location = new Point(175, 406);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(145, 40);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(149, 165, 166);
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI Semibold", 10F);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(20, 452);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(300, 40);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal / Clear";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(btnBatal);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(txtNoHp);
            Controls.Add(label4);
            Controls.Add(txtAlamat);
            Controls.Add(label3);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pnlHeader);
            Name = "FormPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manajemen Pelanggan";
            Load += FormPelanggan_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNama;
        private Label label2;
        private TextBox txtAlamat;
        private Label label3;
        private TextBox txtNoHp;
        private Label label4;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnBatal;
    }
}