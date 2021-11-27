using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnixcornTweakingUtility.Forms
{
    public partial class BIOSInterfaceForm : Form
    {
        List<string> modifiedVariables = new List<string>();
        public BIOSInterfaceForm()
        {
            InitializeComponent();
            this.methodBox.SelectedIndex = 0;
            MessageBox.Show(
            "For using this feature you must have:\n-Python >= v3.7 installed.\n-Python added to the PATH.\n-Aptio V BIOS",
            "Requirements",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            0
            );
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

        private void modify_Click(object sender, EventArgs e)
        {
            modifiedVariables = new List<string>();
            if (this.variableNameBox.Text == "" || this.variableValueBox.Text == "")
            {
                MessageBox.Show(
                "Please complete all required boxes.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
            else
            {
                if (
                Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883816516548698162/amifldrv64.sys",
                    "amifldrv64.sys"
                ) == false ||
                Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883816542788264026/SCEWIN_64.exe",
                    "SCEWIN_64.exe"
                ) == false ||
                Utils.DownloadFile(
                    "https://cdn.discordapp.com/attachments/883815771371876362/883816537084014662/varnametomapstring.py",
                    "varnametomapstring.py"
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
                    string line_varmaptomapstring = getMapStringsFromVariableName(this.variableNameBox.Text, this.methodBox.Text);
                    if (line_varmaptomapstring.Contains("[Error]"))
                    {
                        MessageBox.Show(
                        "An error happened:" + line_varmaptomapstring,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        0
                        );
                    }
                    else
                    {
                        string[] mapStrings = line_varmaptomapstring.Replace("[Success]", "").Replace("\n", "").Replace("\r", "").Replace("\t", "").Split(',');
                        List<string> failed = new List<string>();
                        List<string> success = new List<string>();
                        foreach (string mapString in mapStrings)
                        {
                            string mapStringName = mapString.Split(':')[0];
                            string mapStringValue = mapString.Split(':')[1];

                            bool result = modifyMapString(mapStringValue, this.variableValueBox.Text);
                            if (result == false)
                            {
                                failed.Add("failed");
                                modifiedVariables.Add("//" + mapStringName + " [" + mapStringValue + "]: " + this.variableValueBox.Text);
                            }
                            else
                            {
                                success.Add("success");
                                modifiedVariables.Add(mapStringName + " [" + mapStringValue + "]: " + this.variableValueBox.Text);
                            }
                        }
                        MessageBox.Show(
                        "Number of variables not edited: " + failed.Count(),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        0
                        );
                        MessageBox.Show(
                        "Number of variables edited " + success.Count(),
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        0
                        );
                    }
                    File.Delete("amifldrv64.sys");
                    File.Delete("varnametomapstring.py");
                    File.Delete("SCEWIN_64.exe");
                    File.Delete("BIOSSettings.txt");
                }
            }
        }
        
        private void modifyByFile_Click(object sender, EventArgs e)
        {
            modifiedVariables = new List<string>();
            if (Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883816516548698162/amifldrv64.sys",
                "amifldrv64.sys"
            ) == false ||
            Utils.DownloadFile(
                "https://cdn.discordapp.com/attachments/883815771371876362/883816542788264026/SCEWIN_64.exe",
                "SCEWIN_64.exe"
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
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Select A File";
                openDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    string firstLine = File.ReadLines(openDialog.FileName).First();
                    if (firstLine.Contains("UnixcornTweakingUtility - BIOSInterface Backup File " + Program.version))
                    {
                        string[] lines = File.ReadAllLines(openDialog.FileName);
                        List<string> failed = new List<string>();
                        List<string> success = new List<string>();
                        foreach (string line in lines)
                        {
                            if (line.Contains(":"))
                            {
                                if (line.StartsWith("//"))
                                {
                                    failed.Add(line);
                                }
                                else
                                {
                                    string mapStringName = line.Split('[', ']')[0].Replace("//", "").Split(':')[0].Replace(" ", "");
                                    string mapStringValue = line.Split('[', ']')[1];
                                    string variableValue = line.Split(':')[1].Replace(" ", "");

                                    bool result = modifyMapString(mapStringValue, variableValue);
                                    if (result == false)
                                    {
                                        failed.Add("failed");
                                        modifiedVariables.Add("//" + mapStringName + " [" + mapStringValue + "]: " + variableValue);
                                    }
                                    else
                                    {
                                        success.Add("success");
                                        modifiedVariables.Add(mapStringName + " [" + mapStringValue + "]: " + variableValue);
                                    }
                                }
                            }
                        }
                        MessageBox.Show(
                        "Number of variables not edited: " + failed.Count(),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        0
                        );
                        MessageBox.Show(
                        "Number of variables edited " + success.Count(),
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        0
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                        "Please select a valid file.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        0
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Please choose a file.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    0
                    );
                }
                File.Delete("amifldrv64.sys");
                File.Delete("SCEWIN_64.exe");
            }
        }
        
        private void saveVariables_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("modifiedVariables.txt"))
            {
                writer.WriteLine("UnixcornTweakingUtility - BIOSInterface Backup File " + Program.version);
                foreach (string modifiedVariable in modifiedVariables.ToArray())
                {
                    writer.WriteLine(modifiedVariable);
                }
            }
            MessageBox.Show(
            "Modified variables have been saved in the utility's location folder.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            0
            );
        }
        
        public static bool modifyMapString(string mapString, string value)
        {
            Process amisce = new Process();
            amisce.StartInfo.RedirectStandardError = true;
            amisce.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            amisce.StartInfo.CreateNoWindow = true;
            amisce.StartInfo.UseShellExecute = false;
            amisce.StartInfo.FileName = "SCEWIN_64.exe";
            amisce.StartInfo.Arguments = "/i /ms " + mapString + " /qv 0x" + value;
            amisce.Start();
            string line_amisce = amisce.StandardError.ReadToEnd().ToString();
            if (line_amisce.Contains("not found") || line_amisce.Contains("Error in writing") || line_amisce.Contains("not modified"))
            {
                amisce.WaitForExit();
                return false;
            }
            else
            {
                amisce.WaitForExit();
                return true;
            }
        }

        public static string getMapStringsFromVariableName(string name, string method)
        {
            Process varmaptomapstring = new Process();
            varmaptomapstring.StartInfo.RedirectStandardOutput = true;
            varmaptomapstring.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            varmaptomapstring.StartInfo.CreateNoWindow = true;
            varmaptomapstring.StartInfo.UseShellExecute = false;
            varmaptomapstring.StartInfo.FileName = "cmd.exe";
            varmaptomapstring.StartInfo.Arguments = "/c varnametomapstring.py " + method + " \"" + name + "\"";
            varmaptomapstring.Start();
            string line_varmaptomapstring = varmaptomapstring.StandardOutput.ReadToEnd();
            varmaptomapstring.WaitForExit();
            return line_varmaptomapstring;
        }
        
    }
}
