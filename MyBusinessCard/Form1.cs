using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        // [수정] 현재 어떤 사진인지 기억할 상태 변수 (bool은 절대 틀리지 않습니다)
        private bool isImageR = true;
        private Random rd = new Random();

        public Form1()
        {
            InitializeComponent();

            // 앱 시작 시 기본 설정
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // 1. 배경 색상 변경 (잘 된다고 하신 부분)
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        // 2. 인스타그램(링크) 연결 수정
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 인스타그램 링크
                string url = "https://www.instagram.com/chae__hyunnnnn";

                // [개선] 최신 VS 환경에서도 실행되도록 설정
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 브라우저 실행을 위한 필수 옵션
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("브라우저를 열 수 없습니다: " + ex.Message);
            }
        }

        // 3. 사진 변경 수정 (R <-> B 교체)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (isImageR)
                {
                    // 현재 R이면 B로 변경
                    pictureBox1.Image = Properties.Resources.B;
                    isImageR = false; // 상태 저장
                }
                else
                {
                    // 현재 B면 R로 변경
                    pictureBox1.Image = Properties.Resources.R;
                    isImageR = true; // 상태 저장
                }
            }
            catch (Exception)
            {
                MessageBox.Show("리소스에 R 또는 B 사진이 있는지 확인해주세요!");
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}