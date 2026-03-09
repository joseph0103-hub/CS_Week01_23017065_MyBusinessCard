using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyBusinessCard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pictureBoxProfile.Image = Properties.Resources.leeyoseob; // 명함 기본 이미지
        }

        // 배경 이미지 변경
        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = panelCard.BackColor;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    panelInfoBox.BackColor = dlg.Color;
                }
            }
        }

        // 명함 사진 변경
        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "사진 선택";
                dlg.Filter = "이미지 파일|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                        {
                            Image img = Image.FromStream(fs);
                            pictureBoxProfile.Image = new Bitmap(img);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "사진을 불러오지 못했습니다.\n" + ex.Message,
                            "오류",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
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

        // This is a test.
    }
}