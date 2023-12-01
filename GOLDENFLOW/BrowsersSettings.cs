using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GOLDENFLOW
{
    sealed public class BrowsersSettings
    {
        public static void CurrentBrowser(string browser)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "browsers.xml");
            var doc = XDocument.Load(path);
            var element = doc.Root.Element("CURRENTBROWSER");

            bool Check = IsBrowserInstalled(browser);
            if (Check)
                switch (browser)
                {
                    case "Chrome":
                        element.Value = "Chrome";
                        break;
                    case "Edge":
                        element.Value = "Edge";
                        break;
                    case "Firefox":
                        element.Value = "Firefox";
                        break;
                }
            else
                MessageBox.Show("Browser does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            doc.Save("browsers.xml");
        }




        public static bool IsBrowserInstalled(string browser)
        {
            bool Chrome, Firefox, Edge;
            switch (browser)
            {
                case "Chrome":
                    Chrome = CheckIfSoftwareInstalled(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", "Google Chrome");
                    if (Chrome) return true;
                    else return false;
                
                case "Edge":
                    Edge = CheckIfSoftwareInstalled(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", "Microsoft Edge");
                    if (Edge) return true;
                    else return false;

                case "FireFox":
                    Firefox = CheckIfSoftwareInstalled(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", "Mozilla Firefox");
                    if (Firefox) return true;
                    else return false;

                default: return false;
            }
        }

        static bool CheckIfSoftwareInstalled(string registryPath, string softwareName)
        {
            using (var key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                if (key != null)
                    foreach (string subKeyName in key.GetSubKeyNames())
                        using (var subKey = key.OpenSubKey(subKeyName))
                        {
                            if (subKey != null && subKey.GetValue("DisplayName") as string == softwareName)
                                return true;
                        }
            }
            return false;
        }




        public static string UpdateTitle()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "browsers.xml");
            var doc = XDocument.Load(path);
            var browserName = doc.Descendants("CURRENTBROWSER").FirstOrDefault()?.Value;
            return browserName;
        }
    }
}
