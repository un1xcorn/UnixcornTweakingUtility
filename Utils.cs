using System;
using System.Collections.Specialized;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace UnixcornTweakingUtility
{
    class Utils
    {
        public static string Windows7 = "7";
        public static string Windows8 = "8";
        public static string Windows10 = "10";
       
        public static string getMotherboardId()
        {
            string serial = "";
            try
            {
                using (ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard"))
                {
                    ManagementObjectCollection moc = mos.Get();

                    foreach (ManagementObject mo in moc)
                    {
                        serial = mo["SerialNumber"].ToString();
                    }
                    return serial;
                }
            }
            catch
            {
                return serial;
            }
        }
        
        public static string getLicenseKey()
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(getMotherboardId() + 1337);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        
        public static bool isLicensed()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/un1xcorn/UnixcornTweakingUtility-Licenses/main/licenses.txt");
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Proxy = null;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    if (reader.ReadToEnd().Contains(getLicenseKey()))
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        
        public static bool isLatestUpdate()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/un1xcorn/UnixcornTweakingUtility-Licenses/main/version.txt");
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Proxy = null;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    if (reader.ReadToEnd().Replace("\n", "") == Program.version)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }
        
        public static string getWindowsVersion()
        {
            string version = "";
            try
            {
                using (ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection moc = mos.Get();

                    foreach (ManagementObject mo in moc)
                    {
                        version = mo["Caption"].ToString();
                    }
                    if (version.Contains("7"))
                        return "7";
                    if (version.Contains("8"))
                        return "8";
                    else
                        return "10";
                }
            }
            catch
            {
                return version;
            }
        }

        public static bool DownloadFile(string url, string filename)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(url), filename);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public static bool sendWebhookLog(string webhook)
        {
            try
            {
                using (WebClient dcWeb = new WebClient())
                {
                    NameValueCollection discord = new NameValueCollection();
                    discord.Add("username", "Users connection logger");
                    discord.Add("content", "License key: " + getLicenseKey() + "\nIP Address: " + new WebClient().DownloadString("https://api.ipify.org"));
                    dcWeb.UploadValues(webhook, discord);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string getDecryptedWebhook()
        {
            string encrypted_webhook = "";
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://raw.githubusercontent.com/un1xcorn/UnixcornTweakingUtility-Licenses/main/webhook.txt");
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Proxy = null;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    encrypted_webhook = reader.ReadToEnd().Replace("\n", "");
                }
            }
            catch
            {
                return "";
            }
            byte[] src = Convert.FromBase64String(encrypted_webhook);
            RijndaelManaged aes = new RijndaelManaged();
            byte[] key = Encoding.ASCII.GetBytes("/k5j}L.|N?mt5>6fCp(oCr<(G|PJZ(ah");
            aes.KeySize = 256;
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.ECB;
            using (ICryptoTransform decrypt = aes.CreateDecryptor(key, null))
            {
                byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                decrypt.Dispose();
                string decrypted_webhook = Encoding.UTF8.GetString(dest);
                return decrypted_webhook;
            }
        }
        
    }
}
