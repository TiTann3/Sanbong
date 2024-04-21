using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnC_
{
    public partial class frmRegister : Form
    {
        private UserBUS bus = new UserBUS();
        public frmRegister()
        {
            InitializeComponent();
            RoundedPanel(panel1, 40);
            RoundedButton(btnRegister, 20);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string confirmPassword = txtPass2.Text;
            bool isAdmin = cbxAdmin.Checked;
            DateTime dateCreate = DateTime.Now;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký (tên đăng nhập và mật khẩu).");
                return;
            }
            if (bus.CheckUsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại.");
                return;
            }

            bool success = bus.RegisterUser(username, password, isAdmin, dateCreate);

            if (success)
            {
                MessageBox.Show("Tạo tài khoản thành công.");
                frmLogin login = new frmLogin();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi tạo tài khoản. Vui lòng thử lại.");
            }
        }


        private void picXempass_Click(object sender, EventArgs e)
        {
            picAnpass.Visible = true;
            picXempass.Visible = false;
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void picAnpass_Click(object sender, EventArgs e)
        {
            picAnpass.Visible = false;
            picXempass.Visible = true;
            if (txtPass.PasswordChar == '\0')
            {
                txtPass.PasswordChar = '*';
            }
            else
            {
                txtPass.PasswordChar = '\0';
            }
        }

        private void picXempass2_Click(object sender, EventArgs e)
        {
            picAnpass2.Visible = true;
            picXempass2.Visible = false;
            if (txtPass2.PasswordChar == '*')
            {
                txtPass2.PasswordChar = '\0';
            }
            else
            {
                txtPass2.PasswordChar = '*';
            }
        }

        private void picAnpass2_Click(object sender, EventArgs e)
        {
            picAnpass2.Visible = false;
            picXempass2.Visible = true;
            if (txtPass2.PasswordChar == '\0')
            {
                txtPass2.PasswordChar = '*';
            }
            else
            {
                txtPass2.PasswordChar = '\0';
            }
        }
        private void RoundedPanel(Panel panel, int radius)
        {
            GraphicsPath panelPath = new GraphicsPath();
            Rectangle panelRectangle = panel.ClientRectangle;
            panelRectangle.Inflate(-1, -1);
            panelPath.AddArc(panelRectangle.X, panelRectangle.Y, radius * 2, radius * 2, 180, 90);
            panelPath.AddArc(panelRectangle.X + panelRectangle.Width - radius * 2, panelRectangle.Y, radius * 2, radius * 2, 270, 90);
            panelPath.AddArc(panelRectangle.X + panelRectangle.Width - radius * 2, panelRectangle.Y + panelRectangle.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            panelPath.AddArc(panelRectangle.X, panelRectangle.Y + panelRectangle.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            panelPath.CloseFigure();
            panel.Region = new Region(panelPath);
        }

        private void RoundedButton(Button button, int radius)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle buttonRectangle = button.ClientRectangle;
            buttonRectangle.Inflate(-1, -1);
            buttonPath.AddArc(buttonRectangle.X, buttonRectangle.Y, radius * 2, radius * 2, 180, 90);
            buttonPath.AddArc(buttonRectangle.X + buttonRectangle.Width - radius * 2, buttonRectangle.Y, radius * 2, radius * 2, 270, 90);
            buttonPath.AddArc(buttonRectangle.X + buttonRectangle.Width - radius * 2, buttonRectangle.Y + buttonRectangle.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            buttonPath.AddArc(buttonRectangle.X, buttonRectangle.Y + buttonRectangle.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            buttonPath.CloseFigure();
            button.Region = new Region(buttonPath);
        }
    }
}
