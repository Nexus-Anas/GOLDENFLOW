using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GOLDENFLOW
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();
        }

        private void btnChrome_Click(object sender, EventArgs e)
        {
            BrowsersSettings.CurrentBrowser("Chrome");
            txtBrowser.Text = BrowsersSettings.UpdateTitle();
        }

        private void btnFox_Click(object sender, EventArgs e)
        {
            BrowsersSettings.CurrentBrowser("Firefox");
            txtBrowser.Text = BrowsersSettings.UpdateTitle();
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            BrowsersSettings.CurrentBrowser("Edge");
            txtBrowser.Text = BrowsersSettings.UpdateTitle();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void AppSettings_Load(object sender, EventArgs e) => txtBrowser.Text = BrowsersSettings.UpdateTitle();
    }
}
