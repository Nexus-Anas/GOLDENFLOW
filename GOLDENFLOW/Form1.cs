using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GOLDENFLOW
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();





        /*****************************Global***************************/
        /**/ private Task _automationTask;
        /**/ private bool _mouseDown;
        /**/ private Point _startPoint = new Point(0, 0);
        /**/ private readonly int _Value = 15;
        /**/ private int _pcs = 1;
        /**/ private int _h, _m, _s;
        /**/ private System.Timers.Timer _t;
        /**************************************************************/




        /**************************************************************/
        /**************************Form Load***************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTaskTimer.Text = _Value.ToString();
            _t = new System.Timers.Timer();
            _t.Interval = 1000;
            _t.Elapsed += OnTimeEvent;
        }
        /**************************************************************/




        /**************************************************************/
        /***************************settings***************************/

        //Exit, minimize buttons
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;


        //Coinbase button
        private void btnCoinbase_MouseEnter(object sender, EventArgs e) => btnCoinBase.BaseColor = Color.FromArgb(76, 75, 105);
        private void btnCoinbase_MouseLeave(object sender, EventArgs e) => btnCoinBase.BaseColor = Color.FromArgb(52, 51, 73);
        private void btnCoinBase_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://www.coinbase.com/");

        private void lblCoinbase_MouseEnter(object sender, EventArgs e) => btnCoinBase.BaseColor = Color.FromArgb(76, 75, 105);
        private void lblCoinbase_MouseLeave(object sender, EventArgs e) => btnCoinBase.BaseColor = Color.FromArgb(52, 51, 73);
        private void lblCoinbase_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://www.coinbase.com/");

        private void logoCoinbase_MouseEnter(object sender, EventArgs e) => btnCoinBase.BaseColor = Color.FromArgb(76, 75, 105);
        private void logoCoinbase_MouseLeave(object sender, EventArgs e) => btnCoinBase.BaseColor = Color.FromArgb(52, 51, 73);
        private void logoCoinbase_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://www.coinbase.com/");


        //Panel cursor move
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _startPoint = new Point(e.X, e.Y);
        }
        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void panelHeader_MouseUp(object sender, MouseEventArgs e)=> _mouseDown = false;
        /**************************************************************/


        /**************************************************************/
        /*******************Begin, End and TimerEvent******************/
        




        /**************************************************************/
        /***********************duration settings**********************/

        private void btnTaskTimerPos_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTaskTimer.Text) >= 1500)
                return;
            txtTaskTimer.Text = (Convert.ToInt32(txtTaskTimer.Text) + (_Value * 2)).ToString();
            _pcs++;
        }

        private void btnTaskTimerNeg_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTaskTimer.Text) == 15)
                return;
            txtTaskTimer.Text = (Convert.ToInt32(txtTaskTimer.Text) - (_Value * 2)).ToString();
            _pcs--;
        }
        /**************************************************************/




        /**************************************************************/
        /*************************buttons settings*********************/

        private async void btnStart_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtWallet.Text))
            {
                MessageBox.Show("Please type your wallet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }


            try
            {
                if (ToggleInfinite.Checked)
                {
                    try { _automationTask = Task.Run(() => { MiningInfinity(); }); }
                    catch (Exception) { CloseTask(); }
                    return;
                }

                if (_pcs == 1)
                {
                    try { _automationTask = Task.Run(() => { MiningOnce(); }); }
                    catch (Exception) { CloseTask(); }
                    return;
                }

                if (_pcs > 1)
                {
                    try { _automationTask = Task.Run(() => { Mining(); }); }
                    catch (Exception) { CloseTask(); }
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("The application will shut down and restart!\nConfirm restart?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
                return;
            try
            {
                DisableAll();
                CloseTask();
                CleanUp();
                Application.Restart();
            }
            catch (Exception)
            {
                CleanUp();
                Application.Restart();
            }
        }

        //Toggle button
        private void ToggleInfinite_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleInfinite.Checked)
            {
                txtTaskTimer.Enabled = false;
                btnTaskTimerPos.Enabled = false;
                btnTaskTimerNeg.Enabled = false;
                return;
            }
            txtTaskTimer.Enabled = true;
            btnTaskTimerPos.Enabled = true;
            btnTaskTimerNeg.Enabled = true;
        }
        /**************************************************************/




        /**************************************************************/
        /*************************Selenium Functions*******************/

        private bool LoadDriver()
        {
            var driver = BrowsersSettings.UpdateTitle();
            if (driver == "Chrome")
            {
                MainDriver.Driver = new ChromeDriver(Service());
                return true;
            }

            if (driver == "Edge")
            {
                MainDriver.Driver = new EdgeDriver();
                return true;
            }

            if (driver == "Firefox")
            {
                MainDriver.Driver = new FirefoxDriver();
                return true;
            }

            return false;
        } 
        private void Init() => MainDriver.Driver.Navigate().GoToUrl("https://www.moonbitcoins.com/");
        private void SetUp()
        {
            SeleniumSet.SetText("//*[@id=\"btcId\"]", "XPath", txtWallet.Text);
            Sleep(3, 1); // sleep 3 seconds
            SeleniumSet.Click("//*[@id=\"formControl\"]/div[2]/input", "XPath");
            Sleep(3, 1); // sleep 3 seconds
            SeleniumSet.Click("/html/body/div[3]/div/div/div[3]/button[2]", "XPath");
            Sleep(9, 1); // sleep 9 seconds
        }
        private void RefreshTab() => MainDriver.Driver.Navigate().Refresh();
        private void Execute() => SeleniumSet.Click("//*[@id=\"about\"]/div/div[1]/div[2]/button", "XPath");
        private void Sleep(int sec, int min) => Thread.Sleep(sec * 1000 * min);
        private void Wait_600()
        {
            while (true)
            {
                try
                {
                    var timer = SeleniumGet.GetText("//*[@id=\"end-time\"]", "XPath");
                    if (timer == "The amount earned has been transferred to your account")
                        break;
                }
                catch (NoSuchElementException) { }
                Thread.Sleep(1000);
            }
        }
        private void CleanUp()
        {
            try { MainDriver.Driver.Quit(); }
            catch (Exception) { }
        }
        private void CloseTask()
        {
            _automationTask?.Wait(TimeSpan.FromSeconds(5));
            MainDriver.Driver?.Quit();
        }
        private void UpdatePcs()
        {
            txtPcs.Invoke(new Action(() => {
                txtPcs.Text = (Convert.ToInt32(txtPcs.Text) + 1).ToString();
            }));
        }
        /**************************************************************/




        /**************************************************************/
        /*************************Selenium Tasks***********************/
        private void MiningOnce()
        {
            var driver = LoadDriver();
            if (!driver)
            {
                MessageBox.Show("Browser does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            Begin();
            Init();
            SetUp();
            Execute();
            Wait_600();
            UpdatePcs();
            CleanUp();
            End();
        }
        private void Mining()
        {
            var driver = LoadDriver();
            if (!driver)
            {
                MessageBox.Show("Browser does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            Begin();
            Init();
            SetUp();
            for (int i = 0; i < _pcs; i++)
            {
                Execute();
                Wait_600();
                UpdatePcs();
                RefreshTab();
                if ((i + 1) != _pcs)
                {
                    Sleep(60, 15);
                    RefreshTab();
                    Sleep(15, 1);
                }
            }
            CleanUp();
            End();
        }
        private void MiningInfinity()
        {
            var driver = LoadDriver();
            if (!driver)
            {
                MessageBox.Show("Browser does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            Begin();
            Init();
            SetUp();
            for (int i = 0; i < 999999999; i++)
            {
                Execute();
                Wait_600();
                UpdatePcs();
                if ((i + 1) != _pcs)
                {
                    Sleep(60, 15);
                    RefreshTab();
                    Thread.Sleep(15000);
                }
            }
            CleanUp();
            End();
        }
        /**************************************************************/



        
        /**************************************************************/
        /***************************Edge Settings**********************/

        private ChromeOptions Options() //Hide window
        {
            var options = new ChromeOptions();
            options.AddArgument("--window-position=-32000,-32000");
            return options;
        }

        private ChromeDriverService Service() //Hide cmd
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            return service;
        }
        /**************************************************************/




        /**************************************************************/
        /*************************Buttons Methods*********************/
        
        private void Begin()
        {
            // Use Invoke to update the UI controls from the UI thread
            _s = 0; _m = 0; _h = 0;
            lblWatch.Invoke(new Action(() => {
                lblWatch.Text = "00 : 00 : 00";
            }));

            txtPcs.Invoke(new Action(() => {
                txtPcs.Text = "0";
            }));
            btnStart.Invoke(new Action(() => {
                btnStart.Enabled = false;
            }));
            btnStop.Invoke(new Action(() => {
                btnStop.Enabled = true;
            }));
            btnExit.Invoke(new Action(() => {
                btnExit.Enabled = false;
            }));
            panelDuration.Invoke(new Action(() => {
                panelDuration.Enabled = false;
            }));
            Indicator.Invoke(new Action(() => {
                Indicator.Start();
            }));
            _t.Start(); // start timer
        }

        private void End()
        {
            // Use Invoke to update the UI controls from the UI thread
            btnStart.Invoke(new Action(() => {
                btnStart.Enabled = true;
            }));
            btnStop.Invoke(new Action(() => {
                btnStop.Enabled = false;
            }));
            btnExit.Invoke(new Action(() => {
                btnExit.Enabled = true;
            }));
            panelDuration.Invoke(new Action(() => {
                panelDuration.Enabled = true;
            }));
            Indicator.Invoke(new Action(() => {
                Indicator.Stop();
            }));
            _t.Stop(); // stop timer
        }

        private void btnSettings_Click(object sender, EventArgs e) => new AppSettings().ShowDialog();

        

        private void DisableAll()
        {
            txtPcs.Invoke(new Action(() => {
                txtPcs.Text = (Convert.ToInt32(txtPcs.Text) + 1).ToString();
            }));
            MainPanel.Invoke(new Action(() => {
                MainPanel.Enabled = false;
            }));
            DownPanel.Invoke(new Action(() => {
                DownPanel.Enabled = false;
            }));
            btnExit.Invoke(new Action(() => {
                btnExit.Enabled = false;
            }));
            btnMinimize.Invoke(new Action(() => {
                btnMinimize.Enabled = false;
            }));
            btnAbout.Invoke(new Action(() => {
                btnAbout.Enabled = false;
            }));
            lblWait.Invoke(new Action(() => {
                lblWait.Visible = true;
            }));
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                _s++;
                if (_s == 60)
                {
                    _s = 0;
                    _m++;
                }
                if (_m == 60)
                {
                    _m = 0;
                    _h++;
                }
                lblWatch.Text = string.Format("{0} : {1} : {2}", _h.ToString().ToString().PadLeft(2, '0'), _m.ToString().ToString().PadLeft(2, '0'), _s.ToString().ToString().PadLeft(2, '0'));
            }));
        }
        /**************************************************************/

    }
}
