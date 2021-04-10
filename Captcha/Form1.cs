using System;
using System.Drawing;
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
        string text;
        private void RefreshCaptcha()
        {
            Bitmap image = new Bitmap(Width, Height);
            Random rnd = new Random();
            text = "";
            for (int i = 0; i < rnd.Next(1, 15); i++)
            {
                text += (char)rnd.Next('A', 'z');
                
            }
            Graphics g = Graphics.FromImage(image);
            Font font = new Font(Font.FontFamily, 25, RandomStyle());
            g.DrawString(text, font, RandomBrushes(), rnd.Next(0, 100), rnd.Next(10, 70));
            for (int i = 0; i < rnd.Next(10, 40); i++)
            {
                g.DrawLine(new Pen(RandomBrushes(), 2), new Point(rnd.Next(1, 5), rnd.Next(0, CaptchaBackground.Height - 1)), new Point(rnd.Next(150, 200), rnd.Next(0, 150)));
            }
            CaptchaBackground.Image = image;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (CaptchaChecker.Text == text)
                MessageBox.Show("Правильно");
            CaptchaChecker.Clear();
            RefreshCaptcha();
        }

        private FontStyle RandomStyle()
        {
            Random rnd = new Random();
            byte r = (byte)rnd.Next(1, 5);
            switch (r)
            {
                case 1:
                    return FontStyle.Bold;
                case 2:
                    return FontStyle.Italic;
                case 3:
                    return FontStyle.Regular;
                case 4:
                    return FontStyle.Strikeout;
                case 5:
                    return FontStyle.Underline;
                default:
                    return FontStyle.Regular;
            }
        }

        private Brush RandomBrushes()
        {
            Random rnd = new Random();
            byte r = (byte)rnd.Next(1, 5);
            switch (r)
            {
                case 1:
                    return Brushes.Black;
                case 2:
                    return Brushes.White;
                case 3:
                    return Brushes.DarkOrange;
                case 4:
                    return Brushes.Red;
                case 5:
                    return Brushes.Blue;
                default:
                    return Brushes.Green;
            }
        }
    }
}
