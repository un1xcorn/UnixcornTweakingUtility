using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace UnixcornTweakingUtility.Forms
{
    public partial class DWMForm : Form
    {
        public DWMForm()
        {
            InitializeComponent();
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

        private void killDWM_Click(object sender, EventArgs e)
        {
            if (
            Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/887014711013560380/pssuspend64.exe",
                "pssuspend64.exe"
            ) == false ||
            Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/887014813149044786/pskill64.exe",
                "pskill64.exe"
            ) == false
                )
            {
                MessageBox.Show(
                "An error happened while downloading required files.",
                "Download error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
            else
            {
                Process process = new Process();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = @"/c pssuspend64.exe -nobanner winlogon.exe & pskill64.exe -nobanner explorer.exe & pskill64.exe -nobanner dwm.exe & explorer.exe";
                process.Start();
                Thread.Sleep(2000);
                process.Kill();
                File.Delete("pssuspend64.exe");
                File.Delete("pskill64.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void startDWM_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/887014711013560380/pssuspend64.exe",
                    "pssuspend64.exe"
            ) == false)
            {
                MessageBox.Show(
                "An error happened while downloading required files.",
                "Download error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
            else
            {
                Process process = new Process();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = @"/c pssuspend64.exe -r winlogon.exe & dwm.exe";
                process.Start();
                process.WaitForExit();
                File.Delete("pssuspend64.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }
        
    }
}
