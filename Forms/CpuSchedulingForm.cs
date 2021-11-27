using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnixcornTweakingUtility.Forms
{
    public partial class CpuSchedulingForm : Form
    {
        RegistryKey SystemResponsivenessKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", true);
        RegistryKey PriorityControlKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\PriorityControl", true);
        public CpuSchedulingForm()
        {
            InitializeComponent();
            this.systemResponsivenessBox.Text = SystemResponsivenessKey.GetValue("SystemResponsiveness").ToString();
            this.networkThrottlingIndexBox.Text = SystemResponsivenessKey.GetValue("NetworkThrottlingIndex").ToString();
            this.win32PrioritySeparationBox.Text = ((int)PriorityControlKey.GetValue("Win32PrioritySeparation")).ToString("x");
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

        private void loadDefaults_Click(object sender, EventArgs e)
        {
            this.systemResponsivenessBox.Text = "20";
            this.networkThrottlingIndexBox.Text = "10";
            this.win32PrioritySeparationBox.Text = "2";
        }

        private void loadRecommended_Click(object sender, EventArgs e)
        {
            this.systemResponsivenessBox.Text = "10";
            this.networkThrottlingIndexBox.Text = "10";
            this.win32PrioritySeparationBox.Text = "16";
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SystemResponsivenessKey.SetValue("SystemResponsiveness", this.systemResponsivenessBox.Text, RegistryValueKind.DWord);
                SystemResponsivenessKey.SetValue("NetworkThrottlingIndex", this.networkThrottlingIndexBox.Text, RegistryValueKind.DWord);

                PriorityControlKey.SetValue("Win32PrioritySeparation", Convert.ToInt32(this.win32PrioritySeparationBox.Text, 16), RegistryValueKind.DWord);

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
            catch
            {
                MessageBox.Show(
                "An error happened.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
        }
        
    }
}
