namespace QuanLyHocSinh
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSignout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhSachSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.khoaLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHệĐàoTạoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem,
            this.khoaLớpToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSignout,
            this.menuChangePassword,
            this.menuAccount});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuSignout
            // 
            this.menuSignout.Name = "menuSignout";
            this.menuSignout.Size = new System.Drawing.Size(167, 22);
            this.menuSignout.Text = "Đăng xuất";
            this.menuSignout.Click += new System.EventHandler(this.menuSignout_Click);
            // 
            // menuChangePassword
            // 
            this.menuChangePassword.Name = "menuChangePassword";
            this.menuChangePassword.Size = new System.Drawing.Size(167, 22);
            this.menuChangePassword.Text = "Đổi mật khẩu";
            this.menuChangePassword.Click += new System.EventHandler(this.menuChangePassword_Click);
            // 
            // menuAccount
            // 
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(167, 22);
            this.menuAccount.Text = "Quản lý tài khoản";
            this.menuAccount.Click += new System.EventHandler(this.menuAccount_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhapSinhVien,
            this.menuDiem,
            this.menuDanhSachSinhVien});
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // menuNhapSinhVien
            // 
            this.menuNhapSinhVien.Name = "menuNhapSinhVien";
            this.menuNhapSinhVien.Size = new System.Drawing.Size(180, 22);
            this.menuNhapSinhVien.Text = "Thêm sinh viên";
            this.menuNhapSinhVien.Click += new System.EventHandler(this.menuNhapSinhVien_Click);
            // 
            // menuDiem
            // 
            this.menuDiem.Name = "menuDiem";
            this.menuDiem.Size = new System.Drawing.Size(180, 22);
            this.menuDiem.Text = "Điểm số";
            this.menuDiem.Click += new System.EventHandler(this.menuDiem_Click);
            // 
            // menuDanhSachSinhVien
            // 
            this.menuDanhSachSinhVien.Name = "menuDanhSachSinhVien";
            this.menuDanhSachSinhVien.Size = new System.Drawing.Size(179, 22);
            this.menuDanhSachSinhVien.Text = "Danh sách sinh viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuanLyHocSinh.Properties.Resources.HUTECH;
            this.pictureBox1.Location = new System.Drawing.Point(185, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // khoaLớpToolStripMenuItem
            // 
            this.khoaLớpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchKhoaToolStripMenuItem,
            this.danhSáchLớpToolStripMenuItem,
            this.danhSáchMônHọcToolStripMenuItem,
            this.danhSáchHệĐàoTạoToolStripMenuItem});
            this.khoaLớpToolStripMenuItem.Name = "khoaLớpToolStripMenuItem";
            this.khoaLớpToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.khoaLớpToolStripMenuItem.Text = "Quản lý hành chính";
            this.khoaLớpToolStripMenuItem.Click += new System.EventHandler(this.khoaLớpToolStripMenuItem_Click);
            // 
            // danhSáchKhoaToolStripMenuItem
            // 
            this.danhSáchKhoaToolStripMenuItem.Name = "danhSáchKhoaToolStripMenuItem";
            this.danhSáchKhoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhSáchKhoaToolStripMenuItem.Text = "Danh sách khoa";
            // 
            // danhSáchLớpToolStripMenuItem
            // 
            this.danhSáchLớpToolStripMenuItem.Name = "danhSáchLớpToolStripMenuItem";
            this.danhSáchLớpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhSáchLớpToolStripMenuItem.Text = "Danh sách lớp";
            // 
            // danhSáchMônHọcToolStripMenuItem
            // 
            this.danhSáchMônHọcToolStripMenuItem.Name = "danhSáchMônHọcToolStripMenuItem";
            this.danhSáchMônHọcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhSáchMônHọcToolStripMenuItem.Text = "Danh sách môn học";
            // 
            // danhSáchHệĐàoTạoToolStripMenuItem
            // 
            this.danhSáchHệĐàoTạoToolStripMenuItem.Name = "danhSáchHệĐàoTạoToolStripMenuItem";
            this.danhSáchHệĐàoTạoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.danhSáchHệĐàoTạoToolStripMenuItem.Text = "Danh sách hệ đào tạo";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.Drashboard_Test_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSignout;
        private System.Windows.Forms.ToolStripMenuItem menuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem menuAccount;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNhapSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuDiem;
        private System.Windows.Forms.ToolStripMenuItem menuDanhSachSinhVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem khoaLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHệĐàoTạoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}