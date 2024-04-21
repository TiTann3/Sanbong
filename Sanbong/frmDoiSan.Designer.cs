namespace DoAnC_
{
    partial class frmDoiSan
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiSan));
            ListViewItem listViewItem1 = new ListViewItem("", 0);
            largelIcon = new ImageList(components);
            lvSanBong = new ListView();
            btnDoiSan = new Button();
            SuspendLayout();
            // 
            // largelIcon
            // 
            largelIcon.ColorDepth = ColorDepth.Depth8Bit;
            largelIcon.ImageStream = (ImageListStreamer)resources.GetObject("largelIcon.ImageStream");
            largelIcon.TransparentColor = Color.Transparent;
            largelIcon.Images.SetKeyName(0, "stadium.png");
            largelIcon.Images.SetKeyName(1, "stadium_full.png");
            // 
            // lvSanBong
            // 
            lvSanBong.BackColor = Color.Turquoise;
            lvSanBong.BorderStyle = BorderStyle.None;
            lvSanBong.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvSanBong.LargeImageList = largelIcon;
            lvSanBong.Location = new Point(12, 12);
            lvSanBong.Name = "lvSanBong";
            lvSanBong.Size = new Size(248, 379);
            lvSanBong.TabIndex = 0;
            lvSanBong.UseCompatibleStateImageBehavior = false;
            // 
            // btnDoiSan
            // 
            btnDoiSan.BackColor = Color.PapayaWhip;
            btnDoiSan.FlatAppearance.BorderSize = 0;
            btnDoiSan.FlatStyle = FlatStyle.Flat;
            btnDoiSan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDoiSan.Image = Properties.Resources.doi_san;
            btnDoiSan.ImageAlign = ContentAlignment.TopCenter;
            btnDoiSan.Location = new Point(107, 397);
            btnDoiSan.Name = "btnDoiSan";
            btnDoiSan.Size = new Size(60, 50);
            btnDoiSan.TabIndex = 1;
            btnDoiSan.Text = "Đổi Sân";
            btnDoiSan.TextAlign = ContentAlignment.BottomCenter;
            btnDoiSan.UseVisualStyleBackColor = false;
            btnDoiSan.Click += btnDoiSan_Click;
            // 
            // frmDoiSan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(272, 456);
            Controls.Add(btnDoiSan);
            Controls.Add(lvSanBong);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDoiSan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi Sân";
            Load += frmDoiSan_Load;
            ResumeLayout(false);
        }

        #endregion

        private ImageList largelIcon;
        private ListView lvSanBong;
        private Button btnDoiSan;
    }
}