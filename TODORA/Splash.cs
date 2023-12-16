using System;
using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bishop_To_Do;

namespace TODORA
{
    public partial class Splash : Form
    {

        // Initialize custom fonts
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public Splash()
        {
            InitializeComponent();
        }

        MainWindow mui = new MainWindow();

        int showTime = 415, hideTime = 420;
        int height = 2, width = 4;

        private void Splash_Load(object sender, EventArgs e)
        {
            setProgress();
            timerProgress.Enabled = true;
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            int value = progressBar.Width;

            if (value == hideTime)
            {
                Hide();
                timerProgress.Stop();
            }
            else if (value == showTime)
            {
                progressPlus(hideTime - showTime);
                progressCorner.Width = 1;
                mui.Show();
            }
            else if (value >= 350)
            {
                progressPlus(1);
            }
            else if (value >= 250)
            {
                progressPlus(5);
            }
            else if (value >= 200)
            {
                progressPlus(2);
            }
            else if (value >= 40)
            {
                progressPlus(5);
            }
            else
            {
                progressPlus(4);
            }
        }

        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setProgress()
        {
            progressBar.Width = width;
            progressOutline.Height = height;
            progressBar.Height = height;
            progressCorner.Width = (width - 2);
            progressCorner.Height = height;
        }

        private void progressPlus(int i)
        {
            progressBar.Width += i;
            progressCorner.Left = (progressBar.Right - 1);
        }
    }
}
