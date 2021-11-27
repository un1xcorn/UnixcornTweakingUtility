using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Windows.Forms;

using UnixcornTweakingUtility.Forms;

namespace UnixcornTweakingUtility.UserControls
{
    public partial class AdvancedTweaksUC : UserControl
    {
    
        public AdvancedTweaksUC()
        {
            InitializeComponent();
            ToolTip ttbios = new ToolTip();
            ttbios.SetToolTip(this.biosInterface, "Edit every settings of your BIOS with a user-friendly UI.");

            ToolTip ttaffinities = new ToolTip();
            ttaffinities.SetToolTip(this.affinities, "Manage cores jobs.");

            ToolTip ttgpu = new ToolTip();
            ttgpu.SetToolTip(this.gpuTweaks, "Tweak GPU settings.");

            ToolTip ttnip = new ToolTip();
            ttnip.SetToolTip(this.importNip, "Import NIP Profile.");
        }

        private void biosInterface_Click(object sender, EventArgs e)
        {
            BIOSInterfaceForm bios = new BIOSInterfaceForm();
            bios.ShowDialog();
        }

        private void affinities_Click(object sender, EventArgs e)
        {
            AffinitiesInterfaceForm aff = new AffinitiesInterfaceForm();
            aff.ShowDialog();
        }

        private void gpuTweaks_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> cards = new Dictionary<string, string>();
            try
            {
                using (ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
                {
                    ManagementObjectCollection moc = mos.Get();

                    foreach (ManagementObject mo in moc)
                    {
                        cards.Add(mo["Name"].ToString(), mo["DriverVersion"].ToString());
                    }
                }
            }
            catch
            {
            }
            foreach (KeyValuePair<string, string> entry in cards)
            {
                string name = entry.Key;
                if (name.ToLower().Contains("amd"))
                {
                    if (Utils.DownloadFile(
                        "https://cdn.discordapp.com/attachments/883815771371876362/883817120327143455/AMD_GPU_Tweaks.reg",
                        @"C:\gpu_tweak.reg"
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
                        process.StartInfo.Arguments = @"/S C:\gpu_tweak.reg";
                        process.Start();
                        process.WaitForExit();
                        File.Delete(@"C:\gpu_tweak.reg");

                        MessageBox.Show(
                        "(AMD) Tweak has been applied.\nDebug: " + name,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        0
                        );
                    }
                }
                else if (name.ToLower().Contains("nvidia"))
                {
                    if (Utils.DownloadFile(
                        "https://cdn.discordapp.com/attachments/883815771371876362/883817308433313802/FOR_457.30_and_below_LAPTOP.bat",
                        @"C:\gpu_tweak.bat"
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
                        process.StartInfo.Arguments = @"/c C:\gpu_tweak.bat";
                        process.Start();
                        process.WaitForExit();
                        File.Delete(@"C:\gpu_tweak.bat");

                        MessageBox.Show(
                        "(Nvidia) Tweak has been applied.\nDebug: " + name,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        0
                        );
                    }
                }
                else if (name.ToLower().Contains("intel"))
                {
                    if (Utils.DownloadFile(
                        "https://cdn.discordapp.com/attachments/883815771371876362/883817414851198996/intel_igpu.reg",
                        @"C:\gpu_tweak.reg"
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
                        process.StartInfo.Arguments = @"/S C:\gpu_tweak.reg";
                        process.Start();
                        process.WaitForExit();
                        File.Delete(@"C:\gpu_tweak.reg");

                        MessageBox.Show(
                        "(Intel) Tweak has been applied.\nDebug: " + name,
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
                    "An error happened.\nDebug: " + name,
                    "Download error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    0
                    );
                }
            }
        }

        private void importNip_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> cards = new Dictionary<string, string>();
            try
            {
                using (ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController"))
                {
                    ManagementObjectCollection moc = mos.Get();

                    foreach (ManagementObject mo in moc)
                    {
                        cards.Add(mo["Name"].ToString(), mo["DriverVersion"].ToString());
                    }
                }
            }
            catch
            {
            }
            foreach (KeyValuePair<string, string> entry in cards)
            {
                string name = entry.Key;
                string version = entry.Value;
                if (name.ToLower().Contains("nvidia"))
                {
                    version = version.Substring(version.Length - 6).Replace(".", "").Insert(3, @".");
                    float converted = float.Parse(version);
                    Process process = new Process();
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/c del \"C:\\ProgramData\\NVIDIA Corporation\\Drs\\nvdrsdb0.bin\" & del \"C:\\ProgramData\\NVIDIA Corporation\\Drs\\nvdrsdb1.bin\"";
                    process.Start();
                    process.WaitForExit();
                    if (converted > 457.30)
                    {
                        if (Utils.DownloadFile(
                            "https://cdn.discordapp.com/attachments/883815771371876362/883817550998294588/nvidiaProfileInspector.exe",
                            @"C:\nvidiaProfileInspector.exe"
                        ) == false ||
                        Utils.DownloadFile(
                            "https://cdn.discordapp.com/attachments/883815771371876362/883817513132122142/above_457.30.nip",
                            @"C:\profile.nip"
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
                            Process process2 = new Process();
                            process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            process2.StartInfo.CreateNoWindow = true;
                            process2.StartInfo.UseShellExecute = false;
                            process2.StartInfo.FileName = @"C:\nvidiaProfileInspector.exe";
                            process2.StartInfo.Arguments = @"/S C:\profile.nip";
                            process2.Start();
                            process2.WaitForExit();
                            File.Delete(@"C:\nvidiaProfileInspector.exe");
                            File.Delete(@"C:\profile.nip");

                            MessageBox.Show(
                            "(Nvidia) Tweak has been applied.\nDebug: " + name + " | > 457.30",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            0
                            );
                        }
                    }
                    else
                    {
                        if (Utils.DownloadFile(
                            "https://cdn.discordapp.com/attachments/883815771371876362/883817550998294588/nvidiaProfileInspector.exe",
                            @"C:\nvidiaProfileInspector.exe"
                        ) == false ||
                        Utils.DownloadFile(
                            "https://cdn.discordapp.com/attachments/883815771371876362/883817520203718656/below_or_457.30.nip",
                            @"C:\profile.nip"
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
                            Process process2 = new Process();
                            process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            process2.StartInfo.CreateNoWindow = true;
                            process2.StartInfo.UseShellExecute = false;
                            process2.StartInfo.FileName = @"C:\nvidiaProfileInspector.exe";
                            process2.StartInfo.Arguments = @"/S C:\profile.nip";
                            process2.Start();
                            process2.WaitForExit();
                            File.Delete(@"C:\nvidiaProfileInspector.exe");
                            File.Delete(@"C:\profile.nip");

                            MessageBox.Show(
                            "(Nvidia) Tweak has been applied.\nDebug: " + name + " | =< 457.30",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            0
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                    "An error happened.\nDebug: " + name,
                    "Download error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    0
                    );
                }
            }
        }
        
    }
}
