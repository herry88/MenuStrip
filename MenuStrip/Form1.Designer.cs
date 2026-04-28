namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            masterToolStripMenuItem = new ToolStripMenuItem();
            dataPelangganToolStripMenuItem = new ToolStripMenuItem();
            dataToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panelHeader = new Panel();
            lblTitle = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            pnlMain = new Panel();
            flowDashboard = new FlowLayoutPanel();
            pnlCardBarang = new Panel();
            lblCountBarang = new Label();
            label1 = new Label();
            pnlCardPelanggan = new Panel();
            lblCountPelanggan = new Label();
            label2 = new Label();
            btnQuickBarang = new Button();
            btnQuickPelanggan = new Button();
            menuStrip1.SuspendLayout();
            panelHeader.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlMain.SuspendLayout();
            flowDashboard.SuspendLayout();
            pnlCardBarang.SuspendLayout();
            pnlCardPelanggan.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterToolStripMenuItem, dataPelangganToolStripMenuItem, dataToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 60);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            masterToolStripMenuItem.ForeColor = Color.White;
            masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            masterToolStripMenuItem.Size = new Size(68, 36);
            masterToolStripMenuItem.Text = "Master";
            // 
            // dataPelangganToolStripMenuItem
            // 
            dataPelangganToolStripMenuItem.ForeColor = Color.White;
            dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            dataPelangganToolStripMenuItem.Size = new Size(128, 36);
            dataPelangganToolStripMenuItem.Text = "Data Pelanggan";
            dataPelangganToolStripMenuItem.Click += dataPelangganToolStripMenuItem_Click;
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.ForeColor = Color.White;
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(106, 36);
            dataToolStripMenuItem.Text = "Data Barang";
            dataToolStripMenuItem.Click += dataToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.White;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 60);
            panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Dashboard";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.Text = "Ready";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(flowDashboard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 100);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.Size = new Size(800, 324);
            pnlMain.TabIndex = 4;
            // 
            // flowDashboard
            // 
            flowDashboard.Controls.Add(pnlCardBarang);
            flowDashboard.Controls.Add(pnlCardPelanggan);
            flowDashboard.Controls.Add(btnQuickBarang);
            flowDashboard.Controls.Add(btnQuickPelanggan);
            flowDashboard.Dock = DockStyle.Fill;
            flowDashboard.Location = new Point(20, 20);
            flowDashboard.Name = "flowDashboard";
            flowDashboard.Size = new Size(760, 284);
            flowDashboard.TabIndex = 0;
            // 
            // pnlCardBarang
            // 
            pnlCardBarang.BackColor = Color.FromArgb(46, 204, 113);
            pnlCardBarang.Controls.Add(lblCountBarang);
            pnlCardBarang.Controls.Add(label1);
            pnlCardBarang.Location = new Point(3, 3);
            pnlCardBarang.Name = "pnlCardBarang";
            pnlCardBarang.Size = new Size(200, 100);
            pnlCardBarang.TabIndex = 0;
            // 
            // lblCountBarang
            // 
            lblCountBarang.AutoSize = true;
            lblCountBarang.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCountBarang.ForeColor = Color.White;
            lblCountBarang.Location = new Point(14, 38);
            lblCountBarang.Name = "lblCountBarang";
            lblCountBarang.Size = new Size(60, 46);
            lblCountBarang.TabIndex = 1;
            lblCountBarang.Text = "24";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Total Barang";
            // 
            // pnlCardPelanggan
            // 
            pnlCardPelanggan.BackColor = Color.FromArgb(155, 89, 182);
            pnlCardPelanggan.Controls.Add(lblCountPelanggan);
            pnlCardPelanggan.Controls.Add(label2);
            pnlCardPelanggan.Location = new Point(209, 3);
            pnlCardPelanggan.Name = "pnlCardPelanggan";
            pnlCardPelanggan.Size = new Size(200, 100);
            pnlCardPelanggan.TabIndex = 1;
            // 
            // lblCountPelanggan
            // 
            lblCountPelanggan.AutoSize = true;
            lblCountPelanggan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCountPelanggan.ForeColor = Color.White;
            lblCountPelanggan.Location = new Point(14, 38);
            lblCountPelanggan.Name = "lblCountPelanggan";
            lblCountPelanggan.Size = new Size(60, 46);
            lblCountPelanggan.TabIndex = 1;
            lblCountPelanggan.Text = "12";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 0;
            label2.Text = "Total Pelanggan";
            // 
            // btnQuickBarang
            // 
            btnQuickBarang.BackColor = Color.White;
            btnQuickBarang.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnQuickBarang.FlatStyle = FlatStyle.Flat;
            btnQuickBarang.Font = new Font("Segoe UI Semibold", 10F);
            btnQuickBarang.ForeColor = Color.FromArgb(41, 128, 185);
            btnQuickBarang.Location = new Point(3, 109);
            btnQuickBarang.Name = "btnQuickBarang";
            btnQuickBarang.Size = new Size(200, 50);
            btnQuickBarang.TabIndex = 2;
            btnQuickBarang.Text = "Kelola Barang";
            btnQuickBarang.UseVisualStyleBackColor = false;
            btnQuickBarang.Click += dataToolStripMenuItem_Click;
            // 
            // btnQuickPelanggan
            // 
            btnQuickPelanggan.BackColor = Color.White;
            btnQuickPelanggan.FlatAppearance.BorderColor = Color.FromArgb(155, 89, 182);
            btnQuickPelanggan.FlatStyle = FlatStyle.Flat;
            btnQuickPelanggan.Font = new Font("Segoe UI Semibold", 10F);
            btnQuickPelanggan.ForeColor = Color.FromArgb(155, 89, 182);
            btnQuickPelanggan.Location = new Point(209, 109);
            btnQuickPelanggan.Name = "btnQuickPelanggan";
            btnQuickPelanggan.Size = new Size(200, 50);
            btnQuickPelanggan.TabIndex = 3;
            btnQuickPelanggan.Text = "Kelola Pelanggan";
            btnQuickPelanggan.UseVisualStyleBackColor = false;
            btnQuickPelanggan.Click += dataPelangganToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(panelHeader);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlMain.ResumeLayout(false);
            flowDashboard.ResumeLayout(false);
            pnlCardBarang.ResumeLayout(false);
            pnlCardBarang.PerformLayout();
            pnlCardPelanggan.ResumeLayout(false);
            pnlCardPelanggan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem dataPelangganToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panelHeader;
        private Label lblTitle;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Panel pnlMain;
        private FlowLayoutPanel flowDashboard;
        private Panel pnlCardBarang;
        private Label lblCountBarang;
        private Label label1;
        private Panel pnlCardPelanggan;
        private Label lblCountPelanggan;
        private Label label2;
        private Button btnQuickBarang;
        private Button btnQuickPelanggan;
    }
}
