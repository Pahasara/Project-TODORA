using System;
using System.Drawing.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

        int showTime = 10, hideTime = 12, time = 0;

        private void Splash_Load(object sender, EventArgs e)
        {
            timerProgress.Enabled = true;
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (time == hideTime)
            {
                Hide();
                timerProgress.Stop();
            }
            else if (time == showTime)
            {
                mui.Show();
            }
            time++;
        }
    }
}
