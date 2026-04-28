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
            lblNamaBarang = new Label();
            lblHarga = new Label();
            lblStock = new Label();
            txtNamaBarang = new TextBox();
            txtHarga = new TextBox();
            txtStock = new TextBox();
            btnSimpan = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnTutup = new Button();
            dataGridView1 = new DataGridView();
            lblid = new Label();
            txtIdbarang = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNamaBarang
            // 
            lblNamaBarang.AutoSize = true;
            lblNamaBarang.Location = new Point(12, 60);
            lblNamaBarang.Name = "lblNamaBarang";
            lblNamaBarang.Size = new Size(100, 20);
            lblNamaBarang.TabIndex = 2;
            lblNamaBarang.Text = "Nama Barang";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(12, 108);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(50, 20);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Harga";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 167);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(118, 57);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(125, 27);
            txtNamaBarang.TabIndex = 5;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(118, 101);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(125, 27);
            txtHarga.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(118, 160);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 7;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(344, 15);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "&Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(344, 60);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(344, 108);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(344, 154);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(94, 33);
            btnTutup.TabIndex = 11;
            btnTutup.Text = "Tutup";
            btnTutup.UseVisualStyleBackColor = true;
            btnTutup.Click += btnTutup_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 188);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(12, 19);
            lblid.Name = "lblid";
            lblid.Size = new Size(69, 20);
            lblid.TabIndex = 14;
            lblid.Text = "idBarang";
            // 
            // txtIdbarang
            // 
            txtIdbarang.Location = new Point(118, 12);
            txtIdbarang.Name = "txtIdbarang";
            txtIdbarang.Size = new Size(125, 27);
            txtIdbarang.TabIndex = 15;
            // 
            // FormBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdbarang);
            Controls.Add(lblid);
            Controls.Add(dataGridView1);
            Controls.Add(btnTutup);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSimpan);
            Controls.Add(txtStock);
            Controls.Add(txtHarga);
            Controls.Add(txtNamaBarang);
            Controls.Add(lblStock);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaBarang);
            Name = "FormBarang";
            Text = "Form Barang";
            Load += FormBarang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label LblIdBarang;
        private Label lblNamaBarang;
        private Label lblHarga;
        private Label lblStock;
        private TextBox txtNamaBarang;
        private TextBox txtHarga;
        private TextBox txtStock;
        private Button btnSimpan;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnTutup;
        private DataGridView dataGridView1;
        private Label lblid;
        private TextBox txtIdbarang;
    }
}