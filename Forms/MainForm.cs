using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UnixcornTweakingUtility.UserControls;

namespace UnixcornTweakingUtility.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.title.Text = "UnixcornTweakingUtility v" + Program.version;
            UserControl uc = new BasicTweaksUC();
            addUserControl(uc);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addUserControl(UserControl uc)
        {
            items.Controls.Clear();
            items.Controls.Add(uc);
            uc.BringToFront();
        }

        private void basicTweaks_Click(object sender, EventArgs e)
        {
            UserControl uc = new BasicTweaksUC();
            addUserControl(uc);
        }

        private void advancedTweaks_Click(object sender, EventArgs e)
        {
            UserControl uc = new AdvancedTweaksUC();
            addUserControl(uc);
        }

        private void installers_Click(object sender, EventArgs e)
        {
            UserControl uc = new InstallersUC();
            addUserControl(uc);
        }

        private void extra_Click(object sender, EventArgs e)
        {
            UserControl uc = new ExtraUC();
            addUserControl(uc);
        }
        
    }
}
