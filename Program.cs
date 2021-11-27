using System;
using System.Diagnostics;
using System.Windows.Forms;

using UnixcornTweakingUtility.Forms;
using AntiCrack;

namespace UnixcornTweakingUtility
{
    static class Program
    {
        public static string webhook = Utils.getDecryptedWebhook();
        public static string version = "0.5";
        
        public static void InitializeAnti()
        {
            AntiCrack.Main.Send2Hook = true; //Send to discord webhook if true
            AntiCrack.Main.HookLink = webhook; // Set if Send2Hook is true
            AntiCrack.Main.DetectVirtualMachineAndAnyRun = true; // Detect VM and App.Any.Run
            AntiCrack.Main.AntiSandBoxie = true; // Detect Sandboxie Usage
            AntiCrack.Main.AntiDebugT = true; // Enables anti debug when true
            AntiCrack.Main.BSOD = true; // BSOD when crack (not harmful will only reset pc)
            AntiCrack.Main.BeAdmin = true; // Force Admin
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeAnti();
            if (!Environment.Is64BitOperatingSystem)
            {
                if (MessageBox.Show(
                "This program supports only 64bit systems.\nDo you want to talk with support ?",
                "Operating System Error",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                0
                ) == DialogResult.Yes)
                {
                    Process.Start("https://twitter.com/un1xcorn");
                }
                return;
            }
            if (!Utils.isLicensed())
            {
                if (MessageBox.Show(
                "It seems that you are not licensed.\nDo you want to talk with support ?",
                "License Error",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                0
                ) == DialogResult.Yes)
                {
                    Process.Start("https://twitter.com/un1xcorn");
                }
                return;
            }
            if (!Utils.isLatestUpdate())
            {
                if (MessageBox.Show(
                "A new update is available.\nDo you want to talk with support ?",
                "Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                0
                ) == DialogResult.Yes)
                {
                    Process.Start("https://twitter.com/un1xcorn");
                }
            }
            if (!Utils.sendWebhookLog(webhook))
            {
                if (MessageBox.Show(
                "An error happened.\nDo you want to talk with support ?",
                "Error",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                0
                ) == DialogResult.Yes)
                {
                    Process.Start("https://twitter.com/un1xcorn");
                }
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
