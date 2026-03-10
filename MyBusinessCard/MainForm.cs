using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyBusinessCard
{
    public partial class MainForm : Form
    {
        Image[] images =
        {
            Properties.Resources.leeyoseob,
            Properties.Resources.leeyoseob2,
            Properties.Resources.leeyoseob3
        };

        int index = 0;

        public MainForm()
        {
            InitializeComponent();
            pictureBoxProfile.Image = Properties.Resources.leeyoseob; // 명함 기본 이미지
            pictureBoxProfile.MouseEnter += pictureBoxProfile_MouseEnter;
            pictureBoxProfile.MouseLeave += pictureBoxProfile_MouseLeave;
        }

        // 배경 이미지 변경
        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            try
            { 
                Random rd = new Random();
                // 0~255 사이의R, G, B 값을 무작위로 생성하여 배경색에 적용
                panelInfoBox.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 명함 사진 변경
        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            try
            {
                index = (index + 1) % images.Length;
                pictureBoxProfile.Image = images[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //GitHub URL 링크 열기
        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/joseph0103-hub";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch
            {
                MessageBox.Show("GitHub 페이지를 열 수 없습니다.");
            }
        }

        // 마우스가 사진 위에 올라갔을 때
        private void pictureBoxProfile_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxProfile.BorderStyle = BorderStyle.FixedSingle;
        }

        // 마우스가 사진에서 벗어났을 때
        private void pictureBoxProfile_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxProfile.BorderStyle = BorderStyle.None;
        }
    }
}