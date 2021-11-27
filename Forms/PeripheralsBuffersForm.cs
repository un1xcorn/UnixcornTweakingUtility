using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnixcornTweakingUtility.Forms
{
    public partial class PeripheralsBuffersForm : Form
    {
        RegistryKey KeyboardBufferSizeKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Kbdclass\Parameters", true);
        RegistryKey MouseBufferSizeKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Mouclass\Parameters", true);
        public PeripheralsBuffersForm()
        {
            InitializeComponent();
            if (KeyboardBufferSizeKey == null)
            {
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Kbdclass\Parameters");
            }
            if (MouseBufferSizeKey == null)
            {
                Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Mouclass\Parameters");
            }
            try
            {
                this.keyboardBufferSizeBox.Text = ((int)KeyboardBufferSizeKey.GetValue("KeyboardDataQueueSize")).ToString("x");
                this.mouseBufferSizeBox.Text = ((int)MouseBufferSizeKey.GetValue("MouseDataQueueSize")).ToString("x");
            }
            catch
            {
                this.keyboardBufferSizeBox.Text = "64";
                this.mouseBufferSizeBox.Text = "64";
            }
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

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                KeyboardBufferSizeKey.SetValue("KeyboardDataQueueSize", Convert.ToInt32(this.keyboardBufferSizeBox.Text, 16), RegistryValueKind.DWord);
                MouseBufferSizeKey.SetValue("MouseDataQueueSize", Convert.ToInt32(this.mouseBufferSizeBox.Text, 16), RegistryValueKind.DWord);

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
