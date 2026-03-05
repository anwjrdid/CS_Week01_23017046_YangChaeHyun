namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();// 0~255 사이의R, G, B 값을무작위로생성하여배경색에적용
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.otherimage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://www.instagram.com/accounts/login/?next=%2Fchae__hyunnnnn&source=omni_redirect");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
