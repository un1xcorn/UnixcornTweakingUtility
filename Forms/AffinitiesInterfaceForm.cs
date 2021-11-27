using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnixcornTweakingUtility.Forms
{
    public partial class AffinitiesInterfaceForm : Form
    {
        RegistryKey DevicesPath = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\");
        Dictionary<string, string> DevicesPathList = new Dictionary<string, string>();
        public AffinitiesInterfaceForm()
        {
            InitializeComponent();
            CheckBox[] cores = {
                cpu0, cpu1, cpu2, cpu3, cpu4,
                cpu5, cpu6, cpu7, cpu8, cpu9,
                cpu10, cpu11, cpu12, cpu13, cpu14,
                cpu15, cpu16, cpu17, cpu18, cpu19,
                cpu20, cpu21, cpu22, cpu23, cpu24,
                cpu25, cpu26, cpu27, cpu28, cpu29,
                cpu30, cpu31, cpu32, cpu33, cpu34,
                cpu35, cpu36, cpu37, cpu38, cpu39,
                cpu40, cpu41, cpu42, cpu43, cpu44,
                cpu45, cpu46, cpu47, cpu48, cpu49,
                cpu50, cpu51, cpu52, cpu53, cpu54,
                cpu55, cpu56, cpu57, cpu58, cpu59,
                cpu60, cpu61, cpu62, cpu63,
            };
            foreach (int core_number in Enumerable.Range(0, Environment.ProcessorCount))
            {
                CheckBox core = cores[core_number];
                core.Enabled = true;
            }
            loadDevices();
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

        private void deviceNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDevicePath();
            updateCores();
            updateMsiMode();
        }

        private void setMask_Click(object sender, EventArgs e)
        {
            CheckBox[] cores = {
                cpu0, cpu1, cpu2, cpu3, cpu4,
                cpu5, cpu6, cpu7, cpu8, cpu9,
                cpu10, cpu11, cpu12, cpu13, cpu14,
                cpu15, cpu16, cpu17, cpu18, cpu19,
                cpu20, cpu21, cpu22, cpu23, cpu24,
                cpu25, cpu26, cpu27, cpu28, cpu29,
                cpu30, cpu31, cpu32, cpu33, cpu34,
                cpu35, cpu36, cpu37, cpu38, cpu39,
                cpu40, cpu41, cpu42, cpu43, cpu44,
                cpu45, cpu46, cpu47, cpu48, cpu49,
                cpu50, cpu51, cpu52, cpu53, cpu54,
                cpu55, cpu56, cpu57, cpu58, cpu59,
                cpu60, cpu61, cpu62, cpu63,
            };
            int mask = 0;
            List<bool> enabledCheckBoxes = new List<bool>();

            foreach (int core_number in Enumerable.Range(0, Environment.ProcessorCount))
            {
                CheckBox core = cores[core_number];
                if (core.Checked == true)
                {
                    mask |= (1 << core_number);
                    enabledCheckBoxes.Add(core.Checked);
                }
            }
            if (enabledCheckBoxes.Count() < 1)
            {
                MessageBox.Show(
                "Please select atleast one core.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                0
                );
            }
            else
            {
                try
                {
                    string path = this.DevicesPathList.FirstOrDefault(x => x.Value == this.deviceNameBox.Text).Key + @"\Device Parameters\Interrupt Management\Affinity Policy";
                    RegistryKey pathKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\" + path, true);

                    pathKey.SetValue("DevicePolicy", 4);
                    pathKey.SetValue("AssignmentSetOverride", mask);

                    MessageBox.Show(
                    "Tweak has been applied.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    0
                    );
                    updateCores();
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

        private void deleteMask_Click(object sender, EventArgs e)
        {
            try
            {
                string path = this.DevicesPathList.FirstOrDefault(x => x.Value == this.deviceNameBox.Text).Key + @"\Device Parameters\Interrupt Management\Affinity Policy";
                RegistryKey pathKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\" + path, true);

                pathKey.DeleteValue("DevicePolicy");
                pathKey.DeleteValue("AssignmentSetOverride");;

                MessageBox.Show(
                "Tweak has been deleted.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                0
                );
                updateCores();
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

        private void msiMode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string path = this.DevicesPathList.FirstOrDefault(x => x.Value == this.deviceNameBox.Text).Key + @"\Device Parameters\Interrupt Management\MessageSignaledInterruptProperties";
                RegistryKey pathKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\" + path, true);
                if (msiMode.Checked == true)
                {
                    pathKey.SetValue("MSISupported", 1);
                }
                else
                {
                    pathKey.SetValue("MSISupported", 0);
                }
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
            updateMsiMode();
        }

        private void loadDevices()
        {
            List<string> loadedDevices = new List<string>();
            foreach (string deviceType in DevicesPath.GetSubKeyNames())
            {
                RegistryKey deviceTypePath = DevicesPath.OpenSubKey(deviceType);
                foreach (string device in deviceTypePath.GetSubKeyNames())
                {
                    RegistryKey devicePath = deviceTypePath.OpenSubKey(device);
                    foreach (string deviceSubname in devicePath.GetSubKeyNames())
                    {
                        RegistryKey deviceSubnamePath = devicePath.OpenSubKey(deviceSubname);
                        if (deviceSubnamePath.OpenSubKey(@"Device Parameters\Interrupt Management\Affinity Policy") != null
                            &&
                            deviceSubnamePath.OpenSubKey(@"Device Parameters\Interrupt Management\MessageSignaledInterruptProperties") != null
                            )
                        {
                            string deviceName = deviceSubnamePath.GetValue("DeviceDesc").ToString().Split(';')[1];
                            loadedDevices.Add(deviceName);

                            int count = loadedDevices.Where(x => x.Equals(deviceName)).Count();
                            if (count > 1)
                                deviceName += " (" + count.ToString() + ")";
                            this.DevicesPathList.Add(deviceSubnamePath.ToString().Replace(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Enum\", ""), deviceName);
                            this.deviceNameBox.Items.Add(deviceName);
                        }
                    }
                }
            }
            this.deviceNameBox.SelectedIndex = 0;

            string str = this.DevicesPathList.First().Key;
            if (str.Contains("REV_"))
                str = str.Remove(str.IndexOf("REV_"));
            if (str.Contains("SUBSYS_"))
                str = str.Remove(str.IndexOf("SUBSYS_"));
            this.devicePathLabel.Text = str;
            updateCores();
        }

        private void updateDevicePath()
        {
            string str = this.DevicesPathList.FirstOrDefault(x => x.Value == this.deviceNameBox.Text).Key;
            if (str.Contains("REV_"))
                str = str.Remove(str.IndexOf("REV_"));
            if (str.Contains("SUBSYS_"))
                str = str.Remove(str.IndexOf("SUBSYS_"));
            this.devicePathLabel.Text = str;
        }

        private void updateCores()
        {
            CheckBox[] cores = {
                cpu0, cpu1, cpu2, cpu3, cpu4,
                cpu5, cpu6, cpu7, cpu8, cpu9,
                cpu10, cpu11, cpu12, cpu13, cpu14,
                cpu15, cpu16, cpu17, cpu18, cpu19,
                cpu20, cpu21, cpu22, cpu23, cpu24,
                cpu25, cpu26, cpu27, cpu28, cpu29,
                cpu30, cpu31, cpu32, cpu33, cpu34,
                cpu35, cpu36, cpu37, cpu38, cpu39,
                cpu40, cpu41, cpu42, cpu43, cpu44,
                cpu45, cpu46, cpu47, cpu48, cpu49,
                cpu50, cpu51, cpu52, cpu53, cpu54,
                cpu55, cpu56, cpu57, cpu58, cpu59,
                cpu60, cpu61, cpu62, cpu63,
            };
            string path = this.DevicesPathList.FirstOrDefault(x => x.Value == this.deviceNameBox.Text).Key + @"\Device Parameters\Interrupt Management\Affinity Policy";
            RegistryKey pathKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\" + path, true);
            object affinity = pathKey.GetValue("AssignmentSetOverride");

            if (affinity == null)
            {
                foreach (int value in Enumerable.Range(0, Environment.ProcessorCount))
                {
                    CheckBox core = cores[value];
                    core.Checked = false;
                }
            }
            else
            {
                int mask = int.Parse(affinity.ToString());

                foreach (int core_number in Enumerable.Range(0, Environment.ProcessorCount))
                {
                    int core_bit = (1 << core_number);
                    if ((mask & core_bit) == core_bit)
                    {
                        CheckBox core = cores[core_number];
                        core.Checked = true;
                    }
                }
            }
        }

        private void updateMsiMode()
        {
            try
            {
                string path = this.DevicesPathList.FirstOrDefault(x => x.Value == this.deviceNameBox.Text).Key + @"\Device Parameters\Interrupt Management\MessageSignaledInterruptProperties";
                RegistryKey pathKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\" + path, true);
                if (pathKey.GetValue("MSISupported") == null)
                {
                    msiMode.Checked = false;
                }
                if (pathKey.GetValue("MSISupported").ToString() == "1")
                {
                    msiMode.Checked = true;
                }
                else
                {
                    msiMode.Checked = false;
                }
            }
            catch
            {
                msiMode.Checked = false;
            }
        }
        
    }
}
