using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Captcha
{
    public partial class CaptchaWindow : Form
    {
        public CaptchaWindow()
        {
            InitializeComponent();
            RefreshCaptcha();
        }

        void RefreshCaptcha()
        {
            Bitmap image = new Bitmap(Width, Height);
            Random rnd = new Random();
            CaptchaText.Text = "";
            for (int i = 0; i < rnd.Next(1, 15); i++)
            {
                CaptchaText.Text += (char)rnd.Next('A', 'z');
                
            }
            Graphics g = Graphics.FromImage(image);
            for (int i = 0; i < 3; i++)
            {
                //g.DrawString(CaptchaText.Text);
                g.DrawLine(new Pen(Brushes.Black, 2), new Point(rnd.Next(1, 5), rnd.Next(0, CaptchaBackground.Height - 1)), new Point(rnd.Next(150, 200), rnd.Next(0, 150)));
            }
            CaptchaBackground.Image = image;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (CaptchaChecker.Text == CaptchaText.Text)
                MessageBox.Show("Правильно");
            else
                CaptchaChecker.Clear();
            RefreshCaptcha();
        }
    }
}
