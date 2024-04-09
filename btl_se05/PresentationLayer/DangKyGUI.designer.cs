namespace btl_se05.PresentationLayer
{
    partial class DangKyGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyGUI));
            this.llbDangNhap = new System.Windows.Forms.LinkLabel();
            this.txtTenTaiKhoan = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbMaQuyen = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new btl_se05.PresentationLayer.Custom.VBButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbStage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // llbDangNhap
            // 
            this.llbDangNhap.AutoSize = true;
            this.llbDangNhap.Location = new System.Drawing.Point(201, 498);
            this.llbDangNhap.Name = "llbDangNhap";
            this.llbDangNhap.Size = new System.Drawing.Size(88, 20);
            this.llbDangNhap.TabIndex = 17;
            this.llbDangNhap.TabStop = true;
            this.llbDangNhap.Text = "Đăng nhập";
            this.llbDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDangNhap_LinkClicked);
            // 
            // txtTenTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTenTaiKhoan.CustomButton.Image = null;
            this.txtTenTaiKhoan.CustomButton.Location = new System.Drawing.Point(353, 2);
            this.txtTenTaiKhoan.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTaiKhoan.CustomButton.Name = "";
            this.txtTenTaiKhoan.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtTenTaiKhoan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenTaiKhoan.CustomButton.TabIndex = 1;
            this.txtTenTaiKhoan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenTaiKhoan.CustomButton.UseSelectable = true;
            this.txtTenTaiKhoan.CustomButton.Visible = false;
            this.txtTenTaiKhoan.DisplayIcon = true;
            this.txtTenTaiKhoan.Icon = ((System.Drawing.Image)(resources.GetObject("txtTenTaiKhoan.Icon")));
            this.txtTenTaiKhoan.Lines = new string[0];
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(43, 222);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTaiKhoan.MaxLength = 32767;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.PromptText = "Tên tài khoản";
            this.txtTenTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.SelectionLength = 0;
            this.txtTenTaiKhoan.SelectionStart = 0;
            this.txtTenTaiKhoan.ShortcutsEnabled = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(397, 46);
            this.txtTenTaiKhoan.TabIndex = 15;
            this.txtTenTaiKhoan.UseSelectable = true;
            this.txtTenTaiKhoan.WaterMark = "Tên tài khoản";
            this.txtTenTaiKhoan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenTaiKhoan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(69, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 61);
            this.label1.TabIndex = 12;
            this.label1.Text = "ĐĂNG KÝ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(587, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 692);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(353, 2);
            this.txtMatKhau.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.DisplayIcon = true;
            this.txtMatKhau.Icon = ((System.Drawing.Image)(resources.GetObject("txtMatKhau.Icon")));
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(43, 293);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PromptText = "Mật khẩu";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(397, 46);
            this.txtMatKhau.TabIndex = 16;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.WaterMark = "Mật khẩu";
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(44, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chào mừng bạn đến với  phần mền quản lý nhà thuốc";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbMaQuyen
            // 
            this.cbMaQuyen.FormattingEnabled = true;
            this.cbMaQuyen.Location = new System.Drawing.Point(43, 367);
            this.cbMaQuyen.Name = "cbMaQuyen";
            this.cbMaQuyen.Size = new System.Drawing.Size(397, 28);
            this.cbMaQuyen.TabIndex = 18;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnDangKy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnDangKy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangKy.BorderRadius = 5;
            this.btnDangKy.BorderSize = 0;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(43, 420);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(397, 46);
            this.btnDangKy.TabIndex = 14;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.TextColor = System.Drawing.Color.White;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lbStage
            // 
            this.lbStage.AutoSize = true;
            this.lbStage.ForeColor = System.Drawing.Color.Red;
            this.lbStage.Location = new System.Drawing.Point(210, 471);
            this.lbStage.Name = "lbStage";
            this.lbStage.Size = new System.Drawing.Size(0, 20);
            this.lbStage.TabIndex = 19;
            // 
            // DangKyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lbStage);
            this.Controls.Add(this.cbMaQuyen);
            this.Controls.Add(this.llbDangNhap);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Name = "DangKyGUI";
            this.Text = "DangKyGUI";
            this.Load += new System.EventHandler(this.DangKyGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbDangNhap;
        private MetroFramework.Controls.MetroTextBox txtTenTaiKhoan;
        private Custom.VBButton btnDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbMaQuyen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbStage;
    }
}