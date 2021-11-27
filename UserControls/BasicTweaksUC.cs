using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UnixcornTweakingUtility.Forms;

namespace UnixcornTweakingUtility.UserControls
{
    public partial class BasicTweaksUC : UserControl
    {
        public string WindowsVersion = Utils.getWindowsVersion();
        
        public BasicTweaksUC()
        {
            InitializeComponent();
            ToolTip ttbcdedit = new ToolTip();
            ttbcdedit.SetToolTip(this.bcdedit, "Optimize BCDEdit settings.");

            ToolTip ttfsutil = new ToolTip();
            ttfsutil.SetToolTip(this.fsutil, "Optimize FSUtil settings.");

            ToolTip ttvisualeffects = new ToolTip();
            ttvisualeffects.SetToolTip(this.visualEffects, "Optimize visual effects settings.");

            ToolTip ttcpuscheduling = new ToolTip();
            ttcpuscheduling.SetToolTip(this.cpuScheduling, "Edit CPU Scheduling (Win32, NetworkThrottling, SystemResponsiveness).");

            ToolTip ttpowerplan = new ToolTip();
            ttpowerplan.SetToolTip(this.powerPlan, "Import UnixcornTweakingUtility's power plan and set it as active.");

            ToolTip ttperipheralsbuffers = new ToolTip();
            ttperipheralsbuffers.SetToolTip(this.peripheralsBuffers, "Edit peripherals buffers (mouse and keyboard).");

            ToolTip ttstartupoptimizer = new ToolTip();
            ttstartupoptimizer.SetToolTip(this.startupOptimizer, "Add a start-up optimizer (clear ram, clear temp folders...).");

            ToolTip ttprocesses = new ToolTip();
            ttprocesses.SetToolTip(this.processes, "Adjust system processes priorities for reducing peripherals latency.");

            ToolTip ttsecurity = new ToolTip();
            ttsecurity.SetToolTip(this.security, "Disable security features (Kernel SEHOP, Spectre and Meltdown...).");

            ToolTip ttcontrol = new ToolTip();
            ttcontrol.SetToolTip(this.controlPanel, "Clean control-panel.");

            ToolTip ttpowersaving = new ToolTip();
            ttpowersaving.SetToolTip(this.powerSaving, "Disable power-saving features of devices (USB, DISKS, NIC...).");

            ToolTip ttnetwork = new ToolTip();
            ttnetwork.SetToolTip(this.network, "Tweak network settings.");

            ToolTip ttfullscreen = new ToolTip();
            ttfullscreen.SetToolTip(this.fullscreen, "Disable full screen optimizations.");

            ToolTip ttdrivers = new ToolTip();
            ttdrivers.SetToolTip(this.drivers, "Disable useless drivers.");

            ToolTip ttservices = new ToolTip();
            ttservices.SetToolTip(this.services, "Disable useless services.");

            ToolTip ttmicrocodes = new ToolTip();
            ttmicrocodes.SetToolTip(this.microcodes, "Delete microcodes.");
        }

        private void bcdedit_Click(object sender, EventArgs e)
        {
            if (this.WindowsVersion == Utils.Windows7)
            {
                if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883817875629047838/bcdedit_cmds_7.bat",
                    @"C:\bcdedit.bat"
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
                    process.StartInfo.Arguments = @"/c C:\bcdedit.bat";
                    process.Start();
                    process.WaitForExit();
                    File.Delete(@"C:\bcdedit.bat");

                    MessageBox.Show(
                    "Tweak has been applied.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    0
                    );
                }
            }
            else if (this.WindowsVersion == Utils.Windows10)
            {
                if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883817889050804244/bcdedit_cmds_10.bat",
                    @"C:\bcdedit.bat"
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
                    process.StartInfo.Arguments = @"/c C:\bcdedit.bat";
                    process.Start();
                    process.WaitForExit();
                    File.Delete(@"C:\bcdedit.bat");

                    MessageBox.Show(
                    "Tweak has been applied.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    0
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "Only Windows 7 and Windows 10 are supported for this tweak.",
                "Windows Version Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
        }

        private void fsutil_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883817994956984331/fsutil_cmds.bat",
                @"C:\fsutil.bat"
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
                process.StartInfo.Arguments = @"/c C:\fsutil.bat";
                process.Start();
                process.WaitForExit();
                File.Delete(@"C:\fsutil.bat");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void visualEffects_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883818074736832562/visualeffects.reg",
                @"C:\visualeffects.reg"
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
                process.StartInfo.FileName = "regedit.exe";
                process.StartInfo.Arguments = @"/S C:\visualeffects.reg";
                process.Start();
                process.WaitForExit();
                File.Delete(@"C:\visualeffects.reg");

                if(this.WindowsVersion == Utils.Windows10)
                {
                    Process process2 = new Process();
                    process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process2.StartInfo.CreateNoWindow = true;
                    process2.StartInfo.UseShellExecute = false;
                    process2.StartInfo.FileName = "cmd.exe";
                    process2.StartInfo.Arguments = @"/c reg.exe add HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer /v AltTabSettings /t REG_DWORD /d 1 /f";
                    process2.Start();
                    process2.WaitForExit();
                }

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void cpuScheduling_Click(object sender, EventArgs e)
        {
            CpuSchedulingForm cpu = new CpuSchedulingForm();
            cpu.ShowDialog();
        }

        private void powerPlan_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883818246774616134/powerplan.pow",
                    @"C:\powerplan.pow"
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
                Random rd = new Random();
                int first_numbers = rd.Next(0, 99999999);
                Process process = new Process();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "powercfg.exe";
                process.StartInfo.Arguments = "-import C:\\powerplan.pow " + first_numbers.ToString() + "-7777-7777-7777-777777777777";
                process.Start();
                process.WaitForExit();
                File.Delete(@"C:\powerplan.pow");

                Process process2 = new Process();
                process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process2.StartInfo.CreateNoWindow = true;
                process2.StartInfo.UseShellExecute = false;
                process2.StartInfo.FileName = "powercfg.exe";
                process2.StartInfo.Arguments = "-setactive " + first_numbers.ToString() + "-7777-7777-7777-777777777777";
                process2.Start();
                process2.WaitForExit();


                if (MessageBox.Show(
                "Do you want to disable idle ?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                0
                ) == DialogResult.Yes)
                {
                    Process process3 = new Process();
                    process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process3.StartInfo.CreateNoWindow = true;
                    process3.StartInfo.UseShellExecute = false;
                    process3.StartInfo.FileName = "powercfg.exe";
                    process3.StartInfo.Arguments = "-setacvalueindex scheme_current sub_processor 5d76a2ca-e8c0-402f-a133-2158492d58ad 1";
                    process3.Start();
                    process3.WaitForExit();
                }
                else
                {
                    Process process3 = new Process();
                    process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process3.StartInfo.CreateNoWindow = true;
                    process3.StartInfo.UseShellExecute = false;
                    process3.StartInfo.FileName = "powercfg.exe";
                    process3.StartInfo.Arguments = "-setacvalueindex scheme_current sub_processor 5d76a2ca-e8c0-402f-a133-2158492d58ad 0";
                    process3.Start();
                    process3.WaitForExit();
                }

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void peripheralsBuffers_Click(object sender, EventArgs e)
        {
            PeripheralsBuffersForm periphs = new PeripheralsBuffersForm();
            periphs.ShowDialog();
        }

        private void startupOptimizer_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883818364684890163/Start-up_optimizer.bat",
                    @"C:\startup-optimizer.bat"
            ) == false ||
            Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883818478275026944/EmptyStandbyList.exe",
                    @"C:\EmptyStandbyList.exe"
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
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                    key.SetValue("Start-up Optimizer", @"C:\startup-optimizer.bat"); 
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
                    MessageBoxIcon.Information,
                    0
                    );
                }
            }
        }

        private void processes_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883818546856091648/mouse_keyboard.reg",
                @"C:\mouse_keyboard.reg"
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
                process.StartInfo.FileName = "regedit.exe";
                process.StartInfo.Arguments = @"/S C:\mouse_keyboard.reg";
                process.Start();
                process.WaitForExit();
                File.Delete(@"C:\mouse_keyboard.reg");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void security_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883818643459297280/security.reg",
                @"C:\security.reg"
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
                process.StartInfo.FileName = "regedit.exe";
                process.StartInfo.Arguments = @"/S C:\security.reg";
                process.Start();
                process.WaitForExit();
                File.Delete(@"C:\security.reg");

                if (this.WindowsVersion == Utils.Windows10)
                {
                    Process process2 = new Process();
                    process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process2.StartInfo.CreateNoWindow = true;
                    process2.StartInfo.UseShellExecute = false;
                    process2.StartInfo.FileName = "cmd.exe";
                    process2.StartInfo.Arguments = "/c reg.exe add \"HKLM\\Software\\Policies\\Microsoft\\Windows\\Kernel DMA Protection\" /v DeviceEnumerationPolicy /t REG_DWORD /d 0 /f";
                    process2.Start();
                    process2.WaitForExit();
                }

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void controlPanel_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883818745926131722/Clean_context-menu.reg",
                @"C:\clean_control_panel.reg"
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
                process.StartInfo.FileName = "regedit.exe";
                process.StartInfo.Arguments = @"/S C:\clean_control_panel.reg";
                process.Start();
                process.WaitForExit();
                File.Delete(@"C:\clean_control_panel.reg");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void powerSaving_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883818896400990238/remove_power_saving_features.bat",
                "remove_power_saving_features.bat"
            ) == false ||
            Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883818912200937502/SetACL.exe",
                "SetACL.exe"
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
                process.StartInfo.Arguments = "/c remove_power_saving_features.bat";
                process.Start();
                process.WaitForExit();
                File.Delete("remove_power_saving_features.bat");
                File.Delete("SetACL.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void network_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883819058968014900/Network_Tweaks.reg",
                @"C:\network.reg"
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
                process.StartInfo.FileName = "regedit.exe";
                process.StartInfo.Arguments = @"/S C:\network.reg";
                process.Start();
                process.WaitForExit();
                File.Delete(@"C:\network.reg");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void fullscreen_Click(object sender, EventArgs e)
        {
            if (this.WindowsVersion == Utils.Windows10)
            {
                if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883819115079426058/fullscreen.reg",
                @"C:\fullscreen.reg"
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
                    process.StartInfo.FileName = "regedit.exe";
                    process.StartInfo.Arguments = @"/S C:\fullscreen.reg";
                    process.Start();
                    process.WaitForExit();
                    File.Delete(@"C:\fullscreen.reg");

                    MessageBox.Show(
                    "Tweak has been applied.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    0
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "Only Windows 10 is supported for this tweak.",
                "Windows Version Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            if (this.WindowsVersion == Utils.Windows10 || this.WindowsVersion == Utils.Windows8)
            {
            }
            else if (this.WindowsVersion == Utils.Windows7)
            {
                if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883819180363743252/Bare_drivers_7.reg",
                @"C:\drivers.reg"
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
                    process.StartInfo.FileName = "regedit.exe";
                    process.StartInfo.Arguments = @"/S C:\drivers.reg";
                    process.Start();
                    process.WaitForExit();
                    File.Delete(@"C:\drivers.reg");

                    MessageBox.Show(
                    "Tweak has been applied.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    0
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "Only Windows 7/8/10 are supported for this tweak.",
                "Windows Version Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
        }

        private void services_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "For using this feature you must have:\n-Set a static IP",
            "Requirements",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            0
            );
            if (this.WindowsVersion == Utils.Windows10 || this.WindowsVersion == Utils.Windows8)
            {
            }
            else if (this.WindowsVersion == Utils.Windows7)
            {
                if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883819338971353139/Bare_services_7.reg",
                @"C:\services.reg"
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
                    process.StartInfo.FileName = "regedit.exe";
                    process.StartInfo.Arguments = @"/S C:\services.reg";
                    process.Start();
                    process.WaitForExit();
                    File.Delete(@"C:\services.reg");

                    MessageBox.Show(
                    "Tweak has been applied.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    0
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "Only Windows 7/8/10 are supported for this tweak.",
                "Windows Version Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
        }

        private void microcodes_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = @"/c del C:\Windows\System32\mcupdate_GenuineIntel.dll & del C:\Windows\System32\mcupdate_authenticamd.dll";
            process.Start();
            process.WaitForExit();

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
