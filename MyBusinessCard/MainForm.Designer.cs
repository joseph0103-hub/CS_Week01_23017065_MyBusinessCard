using static System.Net.WebRequestMethods;

namespace MyBusinessCard
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelCard = new Panel();
            btnChangePicture = new Button();
            panelInfoBox = new Panel();
            pictureBoxProfile = new PictureBox();
            lblName = new Label();
            lblTitle = new Label();
            lblEmailTitle = new Label();
            lblContact = new Label();
            lblSnsTitle = new Label();
            linkLabelGithub = new LinkLabel();
            btnChangeBackColor = new Button();
            panelCard.SuspendLayout();
            panelInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.Yellow;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(btnChangePicture);
            panelCard.Controls.Add(panelInfoBox);
            panelCard.Controls.Add(btnChangeBackColor);
            panelCard.Dock = DockStyle.Fill;
            panelCard.Location = new Point(0, 0);
            panelCard.Margin = new Padding(0);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(760, 420);
            panelCard.TabIndex = 0;
            // 
            // btnChangePicture
            // 
            btnChangePicture.Font = new Font("맑은 고딕", 10F);
            btnChangePicture.ForeColor = Color.RoyalBlue;
            btnChangePicture.Location = new Point(585, 351);
            btnChangePicture.Name = "btnChangePicture";
            btnChangePicture.Size = new Size(130, 30);
            btnChangePicture.TabIndex = 7;
            btnChangePicture.Text = "사진 바꾸기";
            btnChangePicture.UseVisualStyleBackColor = true;
            btnChangePicture.Click += btnChangePicture_Click;
            // 
            // panelInfoBox
            // 
            panelInfoBox.BackColor = Color.Orange;
            panelInfoBox.BorderStyle = BorderStyle.FixedSingle;
            panelInfoBox.Controls.Add(pictureBoxProfile);
            panelInfoBox.Controls.Add(lblName);
            panelInfoBox.Controls.Add(lblTitle);
            panelInfoBox.Controls.Add(lblEmailTitle);
            panelInfoBox.Controls.Add(lblContact);
            panelInfoBox.Controls.Add(lblSnsTitle);
            panelInfoBox.Controls.Add(linkLabelGithub);
            panelInfoBox.Location = new Point(38, 32);
            panelInfoBox.Name = "panelInfoBox";
            panelInfoBox.Size = new Size(477, 258);
            panelInfoBox.TabIndex = 6;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(28, 37);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(140, 184);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblName.Location = new Point(208, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(220, 45);
            lblName.TabIndex = 1;
            lblName.Text = "이요섭";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12.5F);
            lblTitle.Location = new Point(205, 88);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 56);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "수원대학교 지능형SW융합대학\r\n컴퓨터학부";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.Font = new Font("맑은 고딕", 11.5F);
            lblEmailTitle.Location = new Point(189, 146);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(66, 38);
            lblEmailTitle.TabIndex = 5;
            lblEmailTitle.Text = "Email";
            lblEmailTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblContact
            // 
            lblContact.Font = new Font("Segoe UI", 11.5F);
            lblContact.Location = new Point(264, 146);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(188, 38);
            lblContact.TabIndex = 3;
            lblContact.Text = "23017065@suwon.ac.kr";
            lblContact.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSnsTitle
            // 
            lblSnsTitle.Font = new Font("Segoe UI", 10F);
            lblSnsTitle.Location = new Point(203, 187);
            lblSnsTitle.Name = "lblSnsTitle";
            lblSnsTitle.Size = new Size(56, 23);
            lblSnsTitle.TabIndex = 6;
            lblSnsTitle.Text = "GitHub";
            lblSnsTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkLabelGithub
            // 
            linkLabelGithub.AutoSize = true;
            linkLabelGithub.Font = new Font("Segoe UI", 10F);
            linkLabelGithub.LinkColor = Color.Blue;
            linkLabelGithub.Location = new Point(267, 189);
            linkLabelGithub.Name = "linkLabelGithub";
            linkLabelGithub.Size = new Size(185, 19);
            linkLabelGithub.TabIndex = 5;
            linkLabelGithub.TabStop = true;
            linkLabelGithub.Text = "github.com/joseph0103-hub";
            linkLabelGithub.LinkClicked += linkLabelGithub_LinkClicked;
            // 
            // btnChangeBackColor
            // 
            btnChangeBackColor.Font = new Font("맑은 고딕", 10F);
            btnChangeBackColor.ForeColor = Color.RoyalBlue;
            btnChangeBackColor.Location = new Point(585, 315);
            btnChangeBackColor.Name = "btnChangeBackColor";
            btnChangeBackColor.Size = new Size(130, 30);
            btnChangeBackColor.TabIndex = 5;
            btnChangeBackColor.Text = "배경색 바꾸기";
            btnChangeBackColor.UseVisualStyleBackColor = true;
            btnChangeBackColor.Click += btnChangeBackColor_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(760, 420);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(0);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "나만의 디지털 명함";
            panelCard.ResumeLayout(false);
            panelInfoBox.ResumeLayout(false);
            panelInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel panelInfoBox;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.Label lblSnsTitle;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
    }
}