using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace UnixcornTweakingUtility.UserControls
{
    public partial class InstallersUC : UserControl
    {
        public string path = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\";
        public InstallersUC()
        {
            InitializeComponent();
        }

        private void googleChrome_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883823351087366214/googlechromestandaloneenterprise64.msi",
                    "googlechromestandaloneenterprise64.msi"
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
                process.StartInfo.FileName = "msiexec.exe";
                process.StartInfo.Arguments = "/qn /i googlechromestandaloneenterprise64.msi";
                process.Start();
                process.WaitForExit();
                File.Delete("googlechromestandaloneenterprise64.msi");

                if (MessageBox.Show(
                "Do you want to apply Google Chrome tweaks ?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                0
                ) == DialogResult.Yes)
                {
                    if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883824989407686666/Google_Chrome_Tweaks.reg",
                    @"C:\googlechrome.reg"
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
                        process2.StartInfo.FileName = "regedit.exe";
                        process2.StartInfo.Arguments = @"/S C:\googlechrome.reg";
                        process2.Start();
                        process2.WaitForExit();
                        File.Delete(@"C:\googlechrome.reg");

                        MessageBox.Show(
                        "Tweak has been applied.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        0
                        );
                    }
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

        private void geekUninstaller_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883825436986048582/geek.zip",
                    "geek.zip"
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
                    ZipFile.ExtractToDirectory("geek.zip", path);
                } 
                catch (IOException)
                { 

                }
                File.Delete("geek.zip");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void firefox_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883829403656806460/Firefox_Setup_91.0.2.msi",
                    "Firefox_Setup_91.0.2.msi"
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
                process.StartInfo.FileName = "msiexec.exe";
                process.StartInfo.Arguments = "/qn /i Firefox_Setup_91.0.2.msi /q /norestart";
                process.Start();
                process.WaitForExit();
                File.Delete("Firefox_Setup_91.0.2.msi");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void chromium_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883839489494114354/mini_installer.sync.exe",
                    "mini_installer.sync.exe"
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
                process.StartInfo.FileName = "mini_installer.sync.exe";
                process.StartInfo.Arguments = "--install --silent --system-level";
                process.Start();
                process.WaitForExit();
                File.Delete("mini_installer.sync.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void directx9_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883832639868526592/DirectX.zip",
                    "directx.zip"
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
                    ZipFile.ExtractToDirectory("directx.zip", "directx");
                    Process process = new Process();
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = @"directx\DXSETUP.exe";
                    process.StartInfo.Arguments = "/silent";
                    process.Start();
                    process.WaitForExit();
                    File.Delete("directx.zip");
                    Directory.Delete("directx");
                }
                catch (IOException)
                {

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

        private void nvCleanInstall_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883830253192089610/NVCleanstall_1.10.0.exe",
                    "nvcleaninstall.exe"
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
                    File.Move("nvcleaninstall.exe", path + "nvcleaninstall.exe");
                }
                catch (IOException)
                {

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

        private void notepad_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883830199047823380/npp.7.Installer.x64.exe",
                    "notepadinstaller.exe"
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
                process.StartInfo.FileName = "notepadinstaller.exe";
                process.StartInfo.Arguments = "/S";
                process.Start();
                process.WaitForExit();
                File.Delete("notepadinstaller.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void autoruns_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883830513540935710/Autoruns.exe",
                    "autoruns.exe"
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
                    File.Move("autoruns.exe", path + "autoruns.exe");
                }
                catch (IOException)
                {

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

        private void zip_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883830733653811210/7z1900-x64.exe",
                    "7zip.exe"
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
                process.StartInfo.FileName = "7zip.exe";
                process.StartInfo.Arguments = "/S";
                process.Start();
                process.WaitForExit();
                File.Delete("7zip.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void processExplorer_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883831196684021791/procexp.exe",
                    "procexp.exe"
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
                    File.Move("procexp.exe", path + "procexp.exe");
                }
                catch (IOException)
                {

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

        private void vlcplayer_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883837214658818078/vlc-3.0.16-win64.exe",
                    "vlc.exe"
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
                process.StartInfo.FileName = "vlc.exe";
                process.StartInfo.Arguments = "/L=1033 /S";
                process.Start();
                process.WaitForExit();
                File.Delete("vlc.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void visual_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883839387132117042/visual.exe",
                    "visual.exe"
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
                process.StartInfo.FileName = "visual.exe";
                process.StartInfo.Arguments = "/ai /gm2";
                process.Start();
                process.WaitForExit();
                File.Delete("visual.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void net48_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://download.visualstudio.microsoft.com/download/pr/2d6bb6b2-226a-4baa-bdec-798822606ff1/8494001c276a4b96804cde7829c04d7f/ndp48-x86-x64-allos-enu.exe",
                    "net48.exe"
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
                process.StartInfo.FileName = "net48.exe";
                process.StartInfo.Arguments = "/q /norestart";
                process.Start();
                process.WaitForExit();
                File.Delete("net48.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void ripcord_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883836932684120074/Ripcord_Win_0.4.29.zip",
                    "ripcord.zip"
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
                    ZipFile.ExtractToDirectory("ripcord.zip", path + "ripcord");
                }
                catch (IOException)
                {

                }
                File.Delete("ripcord.zip");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void cru_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883833327268806726/CRU.exe",
                    "cru.exe"
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
                    File.Move("cru.exe", path + "cru.exe");
                }
                catch (IOException)
                {

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

        private void memoryCleaner_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883833055108796436/Memory_Cleaner.exe",
                    "memory_cleaner.exe"
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
                    File.Move("memory_cleaner.exe", path + "memory_cleaner.exe");
                }
                catch (IOException)
                {

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

        private void deviceCleanup_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883832914813550622/DeviceCleanup.exe",
                    "dev_clnp.exe"
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
                    File.Move("dev_clnp.exe", path + "dev_clnp.exe");
                }
                catch (IOException)
                {

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

        private void msiUtility_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883832850724573244/MSI_Mode_Utility.exe",
                    "msi_utility.exe"
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
                    File.Move("msi_utility.exe", path + "msi_utility.exe");
                }
                catch (IOException)
                {

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

        private void discord_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883840978807562260/DiscordSetup.exe",
                    "discordsetup.exe"
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
                process.StartInfo.FileName = "discordsetup.exe";
                process.StartInfo.Arguments = "-s";
                process.Start();
                process.WaitForExit();
                File.Delete("discordsetup.exe");

                MessageBox.Show(
                "Tweak has been applied.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
            }
        }

        private void ddu_Click(object sender, EventArgs e)
        {
            if (Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883832893015724042/Display_Driver_Uninstaller.zip",
                    "ddu.zip"
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
                    ZipFile.ExtractToDirectory("ddu.zip", path + "ddu");
                }
                catch (IOException)
                {

                }
                File.Delete("ddu.zip");

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
