using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StroyModern
{
    public partial class CaptchaForm : Form
    {
        public int CountOfAttepts { get; set; } = 0;
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string Digits = "1234567890";
        private string captcha;

        public CaptchaForm()
        {
            InitializeComponent();
        }
        private void CaptchaForm_Load(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
        private void GenerateCaptcha()
        {
            Random random = new Random();
            List<char> captchaChars = new List<char>();


            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(0, Letters.Length);
                captchaChars.Add(Letters[index]);
            }

            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(0, Digits.Length);
                captchaChars.Add(Digits[index]);
            }

            for (int i = captchaChars.Count - 1; i > 0; i--)
            {
                int swapIndex = random.Next(0, i + 1);
                char temp = captchaChars[i];
                captchaChars[i] = captchaChars[swapIndex];
                captchaChars[swapIndex] = temp;
            }

            captcha = new string(captchaChars.ToArray());

            using (Bitmap bitmap = new Bitmap(150, 50))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                using (Font font = new Font("Arial", 15))
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    int spacing = 15;

                    for (int i = 0; i < captcha.Length; i++)
                    {
                        g.TranslateTransform(i * spacing, random.Next(10, 15));
                        g.RotateTransform(random.Next(-20, 20));
                        g.DrawString(captcha[i].ToString(), font, brush, 0, 0);
                        g.ResetTransform();
                    }

                    int y = random.Next(20, 30);
                    g.DrawLine(Pens.Black, 5, y, 145, y);
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    captchaBox.Image = Image.FromStream(ms);
                }
            }
        }

        private void CheckCaptcha()
        {
            if (captchaText.Text.Equals(captcha, StringComparison.OrdinalIgnoreCase))
            {
                AuthFrom authForm = new AuthFrom();
                authForm.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }

        private void captchaBtn_Click(object sender, EventArgs e)
        {

                CheckCaptcha();
            
        }
    }
}
