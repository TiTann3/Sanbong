namespace DoAnC_
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            btnLogin = new Button();
            panel3 = new Panel();
            picXempass = new PictureBox();
            picAnpass = new PictureBox();
            txtPass = new TextBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            txtUser = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRegister = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXempass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 192, 0);
            btnLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(picXempass);
            panel3.Controls.Add(picAnpass);
            panel3.Controls.Add(txtPass);
            panel3.Controls.Add(pictureBox3);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // picXempass
            // 
            picXempass.Image = Properties.Resources.mo_mat;
            resources.ApplyResources(picXempass, "picXempass");
            picXempass.Name = "picXempass";
            picXempass.TabStop = false;
            picXempass.Click += picXempass_Click;
            // 
            // picAnpass
            // 
            picAnpass.Image = Properties.Resources.tat_mat;
            resources.ApplyResources(picAnpass, "picAnpass");
            picAnpass.Name = "picAnpass";
            picAnpass.TabStop = false;
            picAnpass.Click += picAnpass_Click;
            // 
            // txtPass
            // 
            resources.ApplyResources(txtPass, "txtPass");
            txtPass.Name = "txtPass";
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_3;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(pictureBox2);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // txtUser
            // 
            resources.ApplyResources(txtUser, "txtUser");
            txtUser.Name = "txtUser";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.user_2;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 192, 0);
            btnRegister.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRegister, "btnRegister");
            btnRegister.ForeColor = Color.White;
            btnRegister.Name = "btnRegister";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXempass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtUser;
        private Panel panel3;
        private TextBox txtPass;
        private PictureBox pictureBox3;
        private Button btnLogin;
        private PictureBox picXempass;
        private PictureBox picAnpass;
        private Button btnRegister;
    }
}