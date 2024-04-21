using BUS;
using DTO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DoAnC_
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            RoundedPanel(panel1, 40);
            RoundedButton(btnLogin, 20);
            RoundedButton(btnRegister, 20);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUser.Text;
            String password = txtPass.Text;
            if (UserBUS.isExist(username, password))
            {
                User user = UserBUS.getUser(username, password);
                frmMain formMain = new frmMain(user.isAdmin);
                this.Hide();
                formMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnLogin_Click(sender, e);
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }
    }
}