using btl_se05.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_se05.PresentationLayer
{
    public partial class DangKyGUI : Form
    {
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        public DangKyGUI()
        {
            InitializeComponent();
        }

        private void DangKyGUI_Load(object sender, EventArgs e)
        {
            QuyenBLL quyenBLL = new QuyenBLL();

            cbMaQuyen.Items.Clear();
            cbMaQuyen.DataSource = quyenBLL.findAll();
            cbMaQuyen.DisplayMember = "sTenQuyen";
            cbMaQuyen.ValueMember = "PK_sMaQuyen";
        }

        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DangNhapGUI().Show();
        }

        public bool checkValidDangKy(string tenTK, string matKhau)
        {
            if (tenTK.Equals("") || matKhau.Equals(""))
                return false;

            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!checkValidDangKy(txtTenTaiKhoan.Text, txtMatKhau.Text))
            {
                errorProvider1.SetError(txtTenTaiKhoan, "Vui lòng nhập tài khoản");
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
            }
            else
            {
                if (TaiKhoanBLL.createUser(txtTenTaiKhoan.Text, txtMatKhau.Text, cbMaQuyen.SelectedValue.ToString()))
                {
                    lbStage.Text = "Đăng ký thành công";
                }
                else
                {
                    lbStage.Text = "Đăng ký không thành công";
                }
            }
        }
    }
}
