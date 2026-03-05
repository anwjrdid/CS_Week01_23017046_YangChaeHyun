namespace MyBusinessCard
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(43, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(216, 37);
            label1.Name = "label1";
            label1.Size = new Size(119, 45);
            label1.TabIndex = 1;
            label1.Text = "양채현";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 17F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(234, 82);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터Sw";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 17F);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(234, 113);
            label3.Name = "label3";
            label3.Size = new Size(234, 31);
            label3.TabIndex = 3;
            label3.Text = "2423978@naver.com";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(302, 243);
            button1.Name = "button1";
            button1.Size = new Size(175, 39);
            button1.TabIndex = 4;
            button1.Text = "배경색상 변경";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 17F);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(234, 154);
            label4.Name = "label4";
            label4.Size = new Size(175, 31);
            label4.TabIndex = 5;
            label4.Text = "010-4827-9391";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(234, 197);
            button2.Name = "button2";
            button2.Size = new Size(101, 28);
            button2.TabIndex = 6;
            button2.Text = "GitHub";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.FromArgb(255, 128, 255);
            button3.Location = new Point(76, 243);
            button3.Name = "button3";
            button3.Size = new Size(108, 39);
            button3.TabIndex = 7;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 294);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}
