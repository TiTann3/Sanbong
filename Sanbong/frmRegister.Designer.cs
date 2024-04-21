namespace DoAnC_
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            panel1 = new Panel();
            cbxAdmin = new CheckBox();
            panel4 = new Panel();
            picXempass2 = new PictureBox();
            picAnpass2 = new PictureBox();
            txtPass2 = new TextBox();
            pictureBox6 = new PictureBox();
            btnRegister = new Button();
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
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXempass2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnpass2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            panel1.Controls.Add(cbxAdmin);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 357);
            panel1.TabIndex = 1;
            // 
            // cbxAdmin
            // 
            cbxAdmin.AutoSize = true;
            cbxAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cbxAdmin.Location = new Point(155, 266);
            cbxAdmin.Name = "cbxAdmin";
            cbxAdmin.Size = new Size(86, 23);
            cbxAdmin.TabIndex = 8;
            cbxAdmin.Text = "Is Admin";
            cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(picXempass2);
            panel4.Controls.Add(picAnpass2);
            panel4.Controls.Add(txtPass2);
            panel4.Controls.Add(pictureBox6);
            panel4.Location = new Point(40, 218);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 37);
            panel4.TabIndex = 7;
            // 
            // picXempass2
            // 
            picXempass2.Image = Properties.Resources.mo_mat;
            picXempass2.ImeMode = ImeMode.NoControl;
            picXempass2.Location = new Point(282, 8);
            picXempass2.Name = "picXempass2";
            picXempass2.Size = new Size(20, 20);
            picXempass2.SizeMode = PictureBoxSizeMode.CenterImage;
            picXempass2.TabIndex = 6;
            picXempass2.TabStop = false;
            picXempass2.Click += picXempass2_Click;
            // 
            // picAnpass2
            // 
            picAnpass2.Image = Properties.Resources.tat_mat;
            picAnpass2.ImeMode = ImeMode.NoControl;
            picAnpass2.Location = new Point(282, 8);
            picAnpass2.Name = "picAnpass2";
            picAnpass2.Size = new Size(20, 20);
            picAnpass2.SizeMode = PictureBoxSizeMode.CenterImage;
            picAnpass2.TabIndex = 5;
            picAnpass2.TabStop = false;
            picAnpass2.Click += picAnpass2_Click;
            // 
            // txtPass2
            // 
            txtPass2.Location = new Point(39, 7);
            txtPass2.Name = "txtPass2";
            txtPass2.PasswordChar = '*';
            txtPass2.PlaceholderText = "Confirm Password...";
            txtPass2.Size = new Size(273, 23);
            txtPass2.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.password_3;
            pictureBox6.ImeMode = ImeMode.NoControl;
            pictureBox6.Location = new Point(7, 7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 192, 0);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.ImeMode = ImeMode.NoControl;
            btnRegister.Location = new Point(135, 303);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(124, 42);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Sign up";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(picXempass);
            panel3.Controls.Add(picAnpass);
            panel3.Controls.Add(txtPass);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(40, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 37);
            panel3.TabIndex = 5;
            // 
            // picXempass
            // 
            picXempass.Image = Properties.Resources.mo_mat;
            picXempass.ImeMode = ImeMode.NoControl;
            picXempass.Location = new Point(282, 8);
            picXempass.Name = "picXempass";
            picXempass.Size = new Size(20, 20);
            picXempass.SizeMode = PictureBoxSizeMode.CenterImage;
            picXempass.TabIndex = 6;
            picXempass.TabStop = false;
            picXempass.Click += picXempass_Click;
            // 
            // picAnpass
            // 
            picAnpass.Image = Properties.Resources.tat_mat;
            picAnpass.ImeMode = ImeMode.NoControl;
            picAnpass.Location = new Point(282, 8);
            picAnpass.Name = "picAnpass";
            picAnpass.Size = new Size(20, 20);
            picAnpass.SizeMode = PictureBoxSizeMode.CenterImage;
            picAnpass.TabIndex = 5;
            picAnpass.TabStop = false;
            picAnpass.Click += picAnpass_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(39, 7);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Password...";
            txtPass.Size = new Size(273, 23);
            txtPass.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_3;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(7, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(40, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 37);
            panel2.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(39, 7);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username...";
            txtUser.Size = new Size(273, 23);
            txtUser.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_2;
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(7, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(155, 100);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 2;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(156, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 86);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(414, 381);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXempass2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnpass2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private Button btnRegister;
        private Panel panel3;
        private PictureBox picXempass;
        private PictureBox picAnpass;
        private TextBox txtPass;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox txtUser;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox picXempass2;
        private PictureBox picAnpass2;
        private TextBox txtPass2;
        private PictureBox pictureBox6;
        private CheckBox cbxAdmin;
    }
}